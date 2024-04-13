using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.DevTools.CSS;
using CefSharp.DevTools.IndexedDB;
using CefSharp.WinForms;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;

namespace Browser
{
    public partial class Form1 : Form
    {
        private SettingsPar _settingsParams;

        public Form1()
        {
            InitializeComponent();

            UpdateSettingParams();
        }

        private void AddHistory(string site)
        {
            if (_settingsParams.saveHistory)
            {
                if (_settingsParams.saveDate)
                {
                    File.AppendAllText("browser/history.txt", $"{site}\t{DateTime.UtcNow:dd.MM.yy HH:MM:ss}\n");
                }
                else
                {
                    File.AppendAllText("browser/history.txt", $"{site}\n");
                }
            }
        }
        public void UpdateSettingParams()
        {
            _settingsParams = JsonSerializer.Deserialize<SettingsPar>(File.ReadAllText("browser/settings.json"));
        }

        #region Event_Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация движка сайта
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
            // Создание обьекта ChromiumWebBrowser
            ChromiumWebBrowser browser = new ChromiumWebBrowser(_settingsParams.searchDefaultPage);
            // Добавление Events для изменения строки URL
            // и названия сайта во вкладке
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;
            // Добавить в Страницу DefaultTabPage элемент ChromiumWebBrowser
            PagesTab.SelectedTab.Controls.Add(browser);
        }
        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            // Преобразование аголовка вкладки до 65 символов
            this.Invoke(new MethodInvoker(() => {
                PagesTab.SelectedTab.Text = e.Title.Length <= 35 ? e.Title : e.Title.Substring(0, 35);

                if (_settingsParams.saveTypeHistory == "Заголовок страницы")
                {
                    AddHistory(e.Title);
                }
            }));
        }
        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() => {
                SearchTextBox.Text = e.Address;

                if (_settingsParams.saveTypeHistory == "Адрес страницы")
                {
                    AddHistory(e.Address);
                }
            }));
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Завершение процесса. Освобождение памяти
            Cef.Shutdown();
        }
        #endregion

        #region Event_Button
        private void AddNewPageButton_Click(object sender, EventArgs e)
        {
            // Создание сраницы
            TabPage tabPage = new TabPage();
            // Создание обьекта ChromiumWebBrowser
            ChromiumWebBrowser browser = new ChromiumWebBrowser(_settingsParams.searchDefaultPage);
            // Добавление Events для изменения строки URL
            // и названия сайта во вкладке
            browser.AddressChanged += Browser_AddressChanged;
            browser.TitleChanged += Browser_TitleChanged;
            // Добавить в Страницу элемент ChromiumWebBrowser
            tabPage.Controls.Add(browser);
            // Добавить в Страницу в коллекцию вкладок PagesTab
            PagesTab.TabPages.Add(tabPage);
            // Фокус на новую вкладку
            PagesTab.SelectTab(PagesTab.TabCount - 1);
        }
        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                StartButton.PerformClick();
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Получаем ссылку на обьект ChromiumWebBrowser
            // в текущей выбранной вкладке PagesTab
            ChromiumWebBrowser browser = PagesTab.SelectedTab.Controls[0] as ChromiumWebBrowser;

            // Проверка на наличие окна браузера, если его нет
            // тогда нет смысла что-либо делать дальше
            if (browser == null) return;

            if (Regex.IsMatch(SearchTextBox.Text, @"^http\w*"))
            {
                // Загружаем в текущей вкладке страницу по URL из TextBox
                browser.Load(SearchTextBox.Text);
            }
            else
            {
                // Загружаем в текущей вкладке страницу по текстовому запросу из TextBox
                browser.Load(GetSearchRequest(SearchTextBox.Text));
            }

            string GetSearchRequest(string query)
            {
                switch (_settingsParams.searchEngine)
                {
                    case "Google": return $"https://www.google.com/search?q={query}";
                    case "Mail.ru": return $"https://go.mail.ru/search?q={query}";
                    case "Яндекс": return $"https://www.yandex.by/search/?text={query}";
                    case "Bing": return $"https://www.bing.com/search?q={query}";
                    case "Yahoo": return $"https://search.yahoo.com/search?p={query}";
                    case "DuckDuckGo": return $"https://duckduckgo.com/?q={query}";
                    default: return $"https://www.google.com/search?q={query}";
                }
            }
        }
        private void buttonPageClose_Click(object sender, EventArgs e)
        {
            PagesTab.Enabled = false;
            // Количество страниц
            var countPage = PagesTab.TabCount;

            if (countPage > 1)
            {
                // Индекс текущей вкладки для удаления
                int currentPageIndex = PagesTab.SelectedIndex;

                if (currentPageIndex == 0)
                {
                    PagesTab.SelectTab(currentPageIndex + 1);
                }
                else
                {
                    PagesTab.SelectTab(currentPageIndex - 1);
                }

                PagesTab.TabPages.RemoveAt(currentPageIndex);
            }
            PagesTab.Enabled = true;
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settings = new FormSettings() { Owner = this };
            settings.ShowDialog();
        }
        private void refreshPageButton_Click(object sender, EventArgs e)
        {
            // Получаем ссылку на обьект ChromiumWebBrowser
            // в текущей выбранной вкладке PagesTab
            ChromiumWebBrowser browser = PagesTab.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (browser != null)
            {
                // Перезагрузить страницу
                browser.Reload();
            }
        }
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            // Получаем ссылку на обьект ChromiumWebBrowser
            // в текущей выбранной вкладке PagesTab
            ChromiumWebBrowser browser = PagesTab.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (browser != null && browser.CanGoBack)
            {
                // Вернуться к вкладке - назад
                browser.Back();
            }
        }
        private void nextPageButton_Click(object sender, EventArgs e)
        {
            // Получаем ссылку на обьект ChromiumWebBrowser
            // в текущей выбранной вкладке PagesTab
            ChromiumWebBrowser browser = PagesTab.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (browser != null && browser.CanGoForward)
            {
                // Вернуться к вкладке - вперёд
                browser.Forward();
            }
        }
        #endregion

    }
}
