using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Browser
{
    public partial class FormSettings : Form
    {
        private readonly string _searchDefaultEngine = "Google";

        private readonly string _searchDefaultPage = "https://google.com";

        private readonly string _saveTypeHistory = "Адрес страницы";

        private string[] _history;
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                var settingsParams = new SettingsPar()
                {
                    searchEngine = comboBoxSearchEngine.Text == "Выбор" ? _searchDefaultEngine : comboBoxSearchEngine.Text,
                    searchDefaultPage = comboBoxDefaultPage.Text == "Выбор" ? _searchDefaultPage : comboBoxDefaultPage.Text,
                    saveHistory = checkBoxSaveHistory.Checked,
                    saveDate = checkBoxSaveDate.Checked,
                    saveTypeHistory = comboBoxTypeSaveHistory.Text == "Выбор" ? _saveTypeHistory : comboBoxTypeSaveHistory.Text,
                };

                var jsonParams = JsonSerializer.Serialize(settingsParams);

                File.WriteAllText("browser/settings.json", jsonParams);

                if (File.Exists("browser/settings.json"))
                {
                    MessageBox.Show("Сохранение прошло успешно!", "Процесс завершен");
                }
                else
                {
                    MessageBox.Show("Сохранение прошло неуспешно!", "Процесс завершен");
                }

                // Обновить defaultPage в Браузере
                if (Owner.GetType() == typeof(Form1))
                {
                    ((Form1)Owner).UpdateSettingParams();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            _history = File.ReadAllLines("browser/history.txt");
            listBox1.Items.AddRange(_history);

            try
            {
                var settingParams = JsonSerializer.Deserialize<SettingsPar>(File.ReadAllText("browser/settings.json"));

                comboBoxSearchEngine.Text = settingParams.searchEngine;
                comboBoxDefaultPage.Text = settingParams.searchDefaultPage;
                checkBoxSaveHistory.Checked = settingParams.saveHistory;
                checkBoxSaveDate.Checked = settingParams.saveDate;
                comboBoxTypeSaveHistory.Text = settingParams.saveTypeHistory;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            File.WriteAllText("browser/history.txt", "");
            listBox1.Items.Clear();
            this.OnLoad(e);
        }
    }
}
