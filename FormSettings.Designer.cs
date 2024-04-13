namespace Browser
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBoxSearchEngine = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.comboBoxDefaultPage = new System.Windows.Forms.ComboBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.checkBoxSaveDate = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveHistory = new System.Windows.Forms.CheckBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.comboBoxTypeSaveHistory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxHistory.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabel1.Location = new System.Drawing.Point(15, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 37);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Поисковая система";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSearchEngine
            // 
            this.comboBoxSearchEngine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSearchEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSearchEngine.FormattingEnabled = true;
            this.comboBoxSearchEngine.ItemHeight = 29;
            this.comboBoxSearchEngine.Items.AddRange(new object[] {
            "Google",
            "Mail.ru",
            "Яндекс",
            "Bing",
            "Yahoo",
            "DuckDuckGo"});
            this.comboBoxSearchEngine.Location = new System.Drawing.Point(243, 52);
            this.comboBoxSearchEngine.Name = "comboBoxSearchEngine";
            this.comboBoxSearchEngine.Size = new System.Drawing.Size(267, 37);
            this.comboBoxSearchEngine.TabIndex = 1;
            this.comboBoxSearchEngine.Text = "Выбор";
            // 
            // linkLabel2
            // 
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabel2.Location = new System.Drawing.Point(15, 123);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(222, 37);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Стартовая страница";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel3
            // 
            this.linkLabel3.BackColor = System.Drawing.Color.White;
            this.linkLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabel3.Location = new System.Drawing.Point(15, 60);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(222, 37);
            this.linkLabel3.TabIndex = 0;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Сохранить историю";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxDefaultPage
            // 
            this.comboBoxDefaultPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDefaultPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDefaultPage.FormattingEnabled = true;
            this.comboBoxDefaultPage.ItemHeight = 29;
            this.comboBoxDefaultPage.Items.AddRange(new object[] {
            "https://google.com",
            "https://mail.ru",
            "https://www.yandex.by",
            "https://bing.com",
            "https://yahoo.com",
            "https://duckduckgo.com"});
            this.comboBoxDefaultPage.Location = new System.Drawing.Point(243, 123);
            this.comboBoxDefaultPage.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxDefaultPage.Name = "comboBoxDefaultPage";
            this.comboBoxDefaultPage.Size = new System.Drawing.Size(267, 37);
            this.comboBoxDefaultPage.TabIndex = 1;
            this.comboBoxDefaultPage.Text = "Выбор";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxSearchEngine);
            this.groupBoxSearch.Controls.Add(this.linkLabel1);
            this.groupBoxSearch.Controls.Add(this.comboBoxDefaultPage);
            this.groupBoxSearch.Controls.Add(this.linkLabel2);
            this.groupBoxSearch.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.ForeColor = System.Drawing.Color.White;
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 0);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxSearch.Size = new System.Drawing.Size(522, 203);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Поиск";
            // 
            // groupBoxHistory
            // 
            this.groupBoxHistory.Controls.Add(this.buttonClearHistory);
            this.groupBoxHistory.Controls.Add(this.buttonSaveSettings);
            this.groupBoxHistory.Controls.Add(this.checkBoxSaveDate);
            this.groupBoxHistory.Controls.Add(this.checkBoxSaveHistory);
            this.groupBoxHistory.Controls.Add(this.linkLabel5);
            this.groupBoxHistory.Controls.Add(this.linkLabel4);
            this.groupBoxHistory.Controls.Add(this.comboBoxTypeSaveHistory);
            this.groupBoxHistory.Controls.Add(this.linkLabel3);
            this.groupBoxHistory.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxHistory.ForeColor = System.Drawing.Color.White;
            this.groupBoxHistory.Location = new System.Drawing.Point(12, 209);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(522, 348);
            this.groupBoxHistory.TabIndex = 3;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "История браузера";
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.BackColor = System.Drawing.Color.DimGray;
            this.buttonClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonClearHistory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearHistory.ForeColor = System.Drawing.Color.White;
            this.buttonClearHistory.Location = new System.Drawing.Point(3, 211);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(516, 67);
            this.buttonClearHistory.TabIndex = 4;
            this.buttonClearHistory.Text = "Очистить историю";
            this.buttonClearHistory.UseVisualStyleBackColor = false;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.BackColor = System.Drawing.Color.DimGray;
            this.buttonSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSaveSettings.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSaveSettings.Location = new System.Drawing.Point(3, 278);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(516, 67);
            this.buttonSaveSettings.TabIndex = 3;
            this.buttonSaveSettings.Text = "Сохранить";
            this.buttonSaveSettings.UseVisualStyleBackColor = false;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // checkBoxSaveDate
            // 
            this.checkBoxSaveDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSaveDate.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSaveDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSaveDate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBoxSaveDate.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSaveDate.Location = new System.Drawing.Point(243, 155);
            this.checkBoxSaveDate.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSaveDate.MinimumSize = new System.Drawing.Size(37, 37);
            this.checkBoxSaveDate.Name = "checkBoxSaveDate";
            this.checkBoxSaveDate.Size = new System.Drawing.Size(37, 37);
            this.checkBoxSaveDate.TabIndex = 2;
            this.checkBoxSaveDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSaveDate.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveHistory
            // 
            this.checkBoxSaveHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSaveHistory.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSaveHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSaveHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.checkBoxSaveHistory.Font = new System.Drawing.Font("Segoe UI Historic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSaveHistory.Location = new System.Drawing.Point(243, 60);
            this.checkBoxSaveHistory.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxSaveHistory.MinimumSize = new System.Drawing.Size(37, 37);
            this.checkBoxSaveHistory.Name = "checkBoxSaveHistory";
            this.checkBoxSaveHistory.Size = new System.Drawing.Size(37, 37);
            this.checkBoxSaveHistory.TabIndex = 2;
            this.checkBoxSaveHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSaveHistory.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.BackColor = System.Drawing.Color.White;
            this.linkLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabel5.Location = new System.Drawing.Point(15, 155);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(222, 37);
            this.linkLabel5.TabIndex = 0;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Сохранять дату";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel4
            // 
            this.linkLabel4.BackColor = System.Drawing.Color.White;
            this.linkLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.SystemColors.WindowFrame;
            this.linkLabel4.Location = new System.Drawing.Point(15, 108);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(222, 37);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Тип сохранения";
            this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxTypeSaveHistory
            // 
            this.comboBoxTypeSaveHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxTypeSaveHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeSaveHistory.FormattingEnabled = true;
            this.comboBoxTypeSaveHistory.ItemHeight = 29;
            this.comboBoxTypeSaveHistory.Items.AddRange(new object[] {
            "Адрес страницы",
            "Заголовок страницы"});
            this.comboBoxTypeSaveHistory.Location = new System.Drawing.Point(243, 108);
            this.comboBoxTypeSaveHistory.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTypeSaveHistory.Name = "comboBoxTypeSaveHistory";
            this.comboBoxTypeSaveHistory.Size = new System.Drawing.Size(267, 37);
            this.comboBoxTypeSaveHistory.TabIndex = 1;
            this.comboBoxTypeSaveHistory.Text = "Выбор";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(848, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(389, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(389, 561);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "История";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(383, 527);
            this.listBox1.TabIndex = 0;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1237, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxHistory);
            this.Controls.Add(this.groupBoxSearch);
            this.MinimumSize = new System.Drawing.Size(945, 600);
            this.Name = "FormSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxHistory.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox comboBoxSearchEngine;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ComboBox comboBoxDefaultPage;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.CheckBox checkBoxSaveHistory;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.ComboBox comboBoxTypeSaveHistory;
        private System.Windows.Forms.CheckBox checkBoxSaveDate;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.ListBox listBox1;
    }
}