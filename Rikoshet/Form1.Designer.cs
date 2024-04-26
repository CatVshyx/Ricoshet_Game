namespace Rikoshet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mainPanel = new Panel();
            settingsOpen = new Button();
            button1 = new Button();
            start = new Button();
            exit = new Button();
            settingsPanel = new Panel();
            textBox2 = new TextBox();
            resolutionsList = new ComboBox();
            closeSettings = new Button();
            panel2 = new Panel();
            losesText = new TextBox();
            winsText = new TextBox();
            closeStatistics = new Button();
            enemiesStatistic = new TextBox();
            gamesStatistic = new TextBox();
            textBox1 = new TextBox();
            InfoPanel = new Panel();
            infoText = new TextBox();
            closeInfo = new Button();
            mainPanel.SuspendLayout();
            settingsPanel.SuspendLayout();
            panel2.SuspendLayout();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.None;
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Controls.Add(settingsOpen);
            mainPanel.Controls.Add(button1);
            mainPanel.Controls.Add(start);
            mainPanel.Controls.Add(exit);
            mainPanel.Location = new Point(245, 140);
            mainPanel.Margin = new Padding(100, 50, 100, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(789, 464);
            mainPanel.TabIndex = 0;
            // 
            // settingsOpen
            // 
            settingsOpen.BackColor = Color.Black;
            settingsOpen.FlatAppearance.BorderColor = Color.IndianRed;
            settingsOpen.FlatAppearance.BorderSize = 0;
            settingsOpen.FlatAppearance.MouseDownBackColor = Color.Transparent;
            settingsOpen.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            settingsOpen.ForeColor = Color.FromArgb(0, 192, 0);
            settingsOpen.Location = new Point(237, 225);
            settingsOpen.Name = "settingsOpen";
            settingsOpen.Size = new Size(277, 82);
            settingsOpen.TabIndex = 4;
            settingsOpen.Text = "Settings";
            settingsOpen.UseVisualStyleBackColor = false;
            settingsOpen.Click += OpenSettings;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(237, 121);
            button1.Name = "button1";
            button1.Size = new Size(277, 82);
            button1.TabIndex = 3;
            button1.Text = "Statistics";
            button1.UseVisualStyleBackColor = false;
            button1.Click += OpenStatistics;
            // 
            // start
            // 
            start.BackColor = Color.Black;
            start.FlatAppearance.BorderColor = Color.IndianRed;
            start.FlatAppearance.BorderSize = 0;
            start.FlatAppearance.MouseDownBackColor = Color.Transparent;
            start.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            start.ForeColor = Color.FromArgb(0, 192, 0);
            start.Location = new Point(237, 22);
            start.Name = "start";
            start.Size = new Size(277, 82);
            start.TabIndex = 2;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            start.Click += EnterGamePanel;
            // 
            // exit
            // 
            exit.BackColor = Color.Black;
            exit.FlatAppearance.BorderColor = Color.IndianRed;
            exit.FlatAppearance.BorderSize = 0;
            exit.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            exit.ForeColor = Color.FromArgb(0, 192, 0);
            exit.Location = new Point(237, 336);
            exit.Name = "exit";
            exit.Size = new Size(277, 82);
            exit.TabIndex = 1;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += ExitGame;
            // 
            // settingsPanel
            // 
            settingsPanel.Anchor = AnchorStyles.None;
            settingsPanel.BackColor = Color.Transparent;
            settingsPanel.Controls.Add(textBox2);
            settingsPanel.Controls.Add(resolutionsList);
            settingsPanel.Controls.Add(closeSettings);
            settingsPanel.Location = new Point(875, 49);
            settingsPanel.Name = "settingsPanel";
            settingsPanel.Size = new Size(387, 420);
            settingsPanel.TabIndex = 4;
            settingsPanel.Visible = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InfoText;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(0, 192, 0);
            textBox2.Location = new Point(36, 18);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(218, 39);
            textBox2.TabIndex = 7;
            textBox2.Text = "Settings";
            // 
            // resolutionsList
            // 
            resolutionsList.BackColor = SystemColors.MenuText;
            resolutionsList.DropDownStyle = ComboBoxStyle.DropDownList;
            resolutionsList.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            resolutionsList.ForeColor = Color.FromArgb(0, 192, 0);
            resolutionsList.FormattingEnabled = true;
            resolutionsList.Location = new Point(36, 99);
            resolutionsList.Name = "resolutionsList";
            resolutionsList.Size = new Size(191, 40);
            resolutionsList.TabIndex = 6;
            resolutionsList.SelectedIndexChanged += onSelectedOptionResolution;
            // 
            // closeSettings
            // 
            closeSettings.BackColor = Color.Black;
            closeSettings.FlatAppearance.BorderColor = Color.IndianRed;
            closeSettings.FlatAppearance.BorderSize = 0;
            closeSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeSettings.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeSettings.ForeColor = Color.FromArgb(0, 192, 0);
            closeSettings.Location = new Point(211, 328);
            closeSettings.Name = "closeSettings";
            closeSettings.Size = new Size(157, 54);
            closeSettings.TabIndex = 5;
            closeSettings.Text = "Close";
            closeSettings.UseVisualStyleBackColor = false;
            closeSettings.Click += CloseSettings;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(losesText);
            panel2.Controls.Add(winsText);
            panel2.Controls.Add(closeStatistics);
            panel2.Controls.Add(enemiesStatistic);
            panel2.Controls.Add(gamesStatistic);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(27, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 445);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // losesText
            // 
            losesText.BackColor = SystemColors.InfoText;
            losesText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            losesText.ForeColor = Color.FromArgb(0, 192, 0);
            losesText.Location = new Point(282, 172);
            losesText.Name = "losesText";
            losesText.ReadOnly = true;
            losesText.Size = new Size(218, 39);
            losesText.TabIndex = 6;
            losesText.Text = "Loses:";
            // 
            // winsText
            // 
            winsText.BackColor = SystemColors.InfoText;
            winsText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            winsText.ForeColor = Color.FromArgb(0, 192, 0);
            winsText.Location = new Point(282, 115);
            winsText.Name = "winsText";
            winsText.ReadOnly = true;
            winsText.Size = new Size(218, 39);
            winsText.TabIndex = 5;
            winsText.Text = "Wins:";
            // 
            // closeStatistics
            // 
            closeStatistics.BackColor = Color.Black;
            closeStatistics.FlatAppearance.BorderColor = Color.IndianRed;
            closeStatistics.FlatAppearance.BorderSize = 0;
            closeStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeStatistics.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeStatistics.ForeColor = Color.FromArgb(0, 192, 0);
            closeStatistics.Location = new Point(420, 345);
            closeStatistics.Name = "closeStatistics";
            closeStatistics.Size = new Size(157, 54);
            closeStatistics.TabIndex = 4;
            closeStatistics.Text = "Close";
            closeStatistics.UseVisualStyleBackColor = false;
            closeStatistics.Click += CloseStatistics;
            // 
            // enemiesStatistic
            // 
            enemiesStatistic.BackColor = SystemColors.InfoText;
            enemiesStatistic.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            enemiesStatistic.ForeColor = Color.FromArgb(0, 192, 0);
            enemiesStatistic.Location = new Point(23, 172);
            enemiesStatistic.Name = "enemiesStatistic";
            enemiesStatistic.ReadOnly = true;
            enemiesStatistic.Size = new Size(218, 39);
            enemiesStatistic.TabIndex = 2;
            enemiesStatistic.Text = "Enemies killed:";
            // 
            // gamesStatistic
            // 
            gamesStatistic.BackColor = SystemColors.InfoText;
            gamesStatistic.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gamesStatistic.ForeColor = Color.FromArgb(0, 192, 0);
            gamesStatistic.Location = new Point(23, 115);
            gamesStatistic.Name = "gamesStatistic";
            gamesStatistic.ReadOnly = true;
            gamesStatistic.Size = new Size(218, 39);
            gamesStatistic.TabIndex = 1;
            gamesStatistic.Text = "Games played:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(0, 192, 0);
            textBox1.Location = new Point(23, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(218, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "User Statistics";
            // 
            // InfoPanel
            // 
            InfoPanel.Anchor = AnchorStyles.None;
            InfoPanel.BackColor = Color.Transparent;
            InfoPanel.Controls.Add(infoText);
            InfoPanel.Controls.Add(closeInfo);
            InfoPanel.Location = new Point(482, 49);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(387, 486);
            InfoPanel.TabIndex = 5;
            InfoPanel.Visible = false;
            // 
            // infoText
            // 
            infoText.BackColor = SystemColors.InfoText;
            infoText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            infoText.ForeColor = Color.FromArgb(0, 192, 0);
            infoText.Location = new Point(89, 91);
            infoText.Name = "infoText";
            infoText.ReadOnly = true;
            infoText.Size = new Size(218, 39);
            infoText.TabIndex = 7;
            infoText.Text = "You won!!!";
            // 
            // closeInfo
            // 
            closeInfo.BackColor = Color.Black;
            closeInfo.FlatAppearance.BorderColor = Color.IndianRed;
            closeInfo.FlatAppearance.BorderSize = 0;
            closeInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            closeInfo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            closeInfo.ForeColor = Color.FromArgb(0, 192, 0);
            closeInfo.Location = new Point(116, 317);
            closeInfo.Name = "closeInfo";
            closeInfo.Size = new Size(157, 54);
            closeInfo.TabIndex = 6;
            closeInfo.Text = "Close";
            closeInfo.UseVisualStyleBackColor = false;
            closeInfo.Click += CloseInfo;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(InfoPanel);
            Controls.Add(settingsPanel);
            Controls.Add(panel2);
            Controls.Add(mainPanel);
            Name = "Form1";
            Load += Form1_Load;
            mainPanel.ResumeLayout(false);
            settingsPanel.ResumeLayout(false);
            settingsPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button exit;
        private Button start;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox gamesStatistic;
        private TextBox enemiesStatistic;
        private Button closeStatistics;
        private Panel settingsPanel;
        private Button closeSettings;
        private Button settingsOpen;
        private TextBox textBox2;
        private ComboBox resolutionsList;
        private Panel InfoPanel;
        private TextBox infoText;
        private Button closeInfo;
        private TextBox losesText;
        private TextBox winsText;
    }
}