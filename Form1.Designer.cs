using System.Drawing;
using System.Windows.Forms;

namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AddNewPageButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.refreshPageButton = new System.Windows.Forms.Button();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.PagesTab = new System.Windows.Forms.TabControl();
            this.DefaultTabPage = new System.Windows.Forms.TabPage();
            this.buttonPageClose = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            this.PagesTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.SettingsButton);
            this.SearchPanel.Controls.Add(this.buttonPageClose);
            this.SearchPanel.Controls.Add(this.AddNewPageButton);
            this.SearchPanel.Controls.Add(this.StartButton);
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.refreshPageButton);
            this.SearchPanel.Controls.Add(this.nextPageButton);
            this.SearchPanel.Controls.Add(this.prevPageButton);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1053, 45);
            this.SearchPanel.TabIndex = 3;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::Browser.Properties.Resources.settings;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SettingsButton.Location = new System.Drawing.Point(1009, 0);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(42, 43);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AddNewPageButton
            // 
            this.AddNewPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewPageButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewPageButton.Location = new System.Drawing.Point(841, 5);
            this.AddNewPageButton.Name = "AddNewPageButton";
            this.AddNewPageButton.Size = new System.Drawing.Size(32, 32);
            this.AddNewPageButton.TabIndex = 6;
            this.AddNewPageButton.Text = "+";
            this.AddNewPageButton.UseVisualStyleBackColor = true;
            this.AddNewPageButton.Click += new System.EventHandler(this.AddNewPageButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.Location = new System.Drawing.Point(770, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(65, 34);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Поиск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(150, 4);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(614, 32);
            this.SearchTextBox.TabIndex = 4;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // refreshPageButton
            // 
            this.refreshPageButton.BackgroundImage = global::Browser.Properties.Resources.refresh;
            this.refreshPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPageButton.Location = new System.Drawing.Point(68, 3);
            this.refreshPageButton.Name = "refreshPageButton";
            this.refreshPageButton.Size = new System.Drawing.Size(34, 34);
            this.refreshPageButton.TabIndex = 0;
            this.refreshPageButton.UseVisualStyleBackColor = true;
            this.refreshPageButton.Click += new System.EventHandler(this.refreshPageButton_Click);
            // 
            // nextPageButton
            // 
            this.nextPageButton.BackgroundImage = global::Browser.Properties.Resources.arrow_right;
            this.nextPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nextPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageButton.Location = new System.Drawing.Point(108, 4);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(34, 34);
            this.nextPageButton.TabIndex = 2;
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // prevPageButton
            // 
            this.prevPageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevPageButton.BackgroundImage")));
            this.prevPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.prevPageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevPageButton.Location = new System.Drawing.Point(28, 3);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(34, 34);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.prevPageButton_Click);
            // 
            // PagesTab
            // 
            this.PagesTab.Controls.Add(this.DefaultTabPage);
            this.PagesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagesTab.Location = new System.Drawing.Point(0, 45);
            this.PagesTab.Name = "PagesTab";
            this.PagesTab.SelectedIndex = 0;
            this.PagesTab.Size = new System.Drawing.Size(1053, 596);
            this.PagesTab.TabIndex = 4;
            // 
            // DefaultTabPage
            // 
            this.DefaultTabPage.Location = new System.Drawing.Point(4, 22);
            this.DefaultTabPage.Name = "DefaultTabPage";
            this.DefaultTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultTabPage.Size = new System.Drawing.Size(1045, 570);
            this.DefaultTabPage.TabIndex = 0;
            this.DefaultTabPage.Text = "Новая вкладка";
            this.DefaultTabPage.UseVisualStyleBackColor = true;
            // 
            // buttonPageClose
            // 
            this.buttonPageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPageClose.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPageClose.ForeColor = System.Drawing.Color.Black;
            this.buttonPageClose.Location = new System.Drawing.Point(879, 5);
            this.buttonPageClose.Name = "buttonPageClose";
            this.buttonPageClose.Size = new System.Drawing.Size(32, 32);
            this.buttonPageClose.TabIndex = 6;
            this.buttonPageClose.Text = "x";
            this.buttonPageClose.UseVisualStyleBackColor = true;
            this.buttonPageClose.Click += new System.EventHandler(this.buttonPageClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1053, 641);
            this.Controls.Add(this.PagesTab);
            this.Controls.Add(this.SearchPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(975, 680);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.PagesTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button refreshPageButton;
        private Button prevPageButton;
        private Button nextPageButton;
        private Panel SearchPanel;
        private TextBox SearchTextBox;
        private Button StartButton;
        private TabControl PagesTab;
        private TabPage DefaultTabPage;
        private Button AddNewPageButton;
        private Button SettingsButton;
        private Button buttonPageClose;
    }
}

