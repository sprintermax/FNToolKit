namespace FNToolKit
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.RootPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.TabScreen = new System.Windows.Forms.TabControl();
            this.StartTab = new System.Windows.Forms.TabPage();
            this.FriendsTab = new System.Windows.Forms.TabPage();
            this.OperationsTab = new System.Windows.Forms.TabPage();
            this.AccountsTab = new System.Windows.Forms.TabPage();
            this.DetailsTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchGameFolderBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SaveCfgBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GitHubSourceBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OpenGameFolderBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteAllAccountsBtn = new System.Windows.Forms.Button();
            this.ResetConfigsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LaunchGameBtn = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.RootPanel.SuspendLayout();
            this.TabScreen.SuspendLayout();
            this.StartTab.SuspendLayout();
            this.DetailsTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RootPanel
            // 
            this.RootPanel.ColumnCount = 3;
            this.RootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.RootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.RootPanel.Controls.Add(this.label2, 0, 3);
            this.RootPanel.Controls.Add(this.TabScreen, 1, 1);
            this.RootPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.RootPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootPanel.Location = new System.Drawing.Point(0, 0);
            this.RootPanel.Name = "RootPanel";
            this.RootPanel.RowCount = 4;
            this.RootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.RootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.RootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.RootPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RootPanel.Size = new System.Drawing.Size(584, 361);
            this.RootPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 351);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(7, 7);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apoie um Criador - Sprintermax";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TabScreen
            // 
            this.TabScreen.AccessibleName = "";
            this.TabScreen.Controls.Add(this.StartTab);
            this.TabScreen.Controls.Add(this.FriendsTab);
            this.TabScreen.Controls.Add(this.OperationsTab);
            this.TabScreen.Controls.Add(this.AccountsTab);
            this.TabScreen.Controls.Add(this.DetailsTab);
            this.TabScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabScreen.HotTrack = true;
            this.TabScreen.Location = new System.Drawing.Point(13, 8);
            this.TabScreen.Multiline = true;
            this.TabScreen.Name = "TabScreen";
            this.TabScreen.SelectedIndex = 0;
            this.TabScreen.Size = new System.Drawing.Size(558, 324);
            this.TabScreen.TabIndex = 0;
            this.TabScreen.SelectedIndexChanged += new System.EventHandler(this.TabScreen_TabClicked);
            // 
            // StartTab
            // 
            this.StartTab.Controls.Add(this.LaunchGameBtn);
            this.StartTab.Location = new System.Drawing.Point(4, 22);
            this.StartTab.Name = "StartTab";
            this.StartTab.Padding = new System.Windows.Forms.Padding(3);
            this.StartTab.Size = new System.Drawing.Size(550, 298);
            this.StartTab.TabIndex = 0;
            this.StartTab.Text = "Launcher";
            this.StartTab.UseVisualStyleBackColor = true;
            // 
            // FriendsTab
            // 
            this.FriendsTab.Location = new System.Drawing.Point(4, 22);
            this.FriendsTab.Name = "FriendsTab";
            this.FriendsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FriendsTab.Size = new System.Drawing.Size(550, 298);
            this.FriendsTab.TabIndex = 1;
            this.FriendsTab.Text = "Friends";
            this.FriendsTab.UseVisualStyleBackColor = true;
            // 
            // OperationsTab
            // 
            this.OperationsTab.Location = new System.Drawing.Point(4, 22);
            this.OperationsTab.Name = "OperationsTab";
            this.OperationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.OperationsTab.Size = new System.Drawing.Size(550, 298);
            this.OperationsTab.TabIndex = 2;
            this.OperationsTab.Text = "Operactions";
            this.OperationsTab.UseVisualStyleBackColor = true;
            // 
            // AccountsTab
            // 
            this.AccountsTab.Location = new System.Drawing.Point(4, 22);
            this.AccountsTab.Name = "AccountsTab";
            this.AccountsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsTab.Size = new System.Drawing.Size(550, 298);
            this.AccountsTab.TabIndex = 3;
            this.AccountsTab.Text = "Accounts";
            this.AccountsTab.UseVisualStyleBackColor = true;
            // 
            // DetailsTab
            // 
            this.DetailsTab.Controls.Add(this.checkBox3);
            this.DetailsTab.Controls.Add(this.label6);
            this.DetailsTab.Controls.Add(this.SearchGameFolderBtn);
            this.DetailsTab.Controls.Add(this.checkBox1);
            this.DetailsTab.Controls.Add(this.label5);
            this.DetailsTab.Controls.Add(this.label4);
            this.DetailsTab.Controls.Add(this.checkBox2);
            this.DetailsTab.Controls.Add(this.SaveCfgBtn);
            this.DetailsTab.Controls.Add(this.textBox1);
            this.DetailsTab.Controls.Add(this.label1);
            this.DetailsTab.Controls.Add(this.panel1);
            this.DetailsTab.Location = new System.Drawing.Point(4, 22);
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTab.Size = new System.Drawing.Size(550, 298);
            this.DetailsTab.TabIndex = 4;
            this.DetailsTab.Text = "Options";
            this.DetailsTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Location = new System.Drawing.Point(150, 283);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Saved!";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // SearchGameFolderBtn
            // 
            this.SearchGameFolderBtn.Location = new System.Drawing.Point(323, 26);
            this.SearchGameFolderBtn.Name = "SearchGameFolderBtn";
            this.SearchGameFolderBtn.Size = new System.Drawing.Size(43, 23);
            this.SearchGameFolderBtn.TabIndex = 2;
            this.SearchGameFolderBtn.Text = "Find";
            this.SearchGameFolderBtn.UseVisualStyleBackColor = true;
            this.SearchGameFolderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 162);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Force Easy Anti Cheat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(369, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Game Launch Options:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(369, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "ToolKit Options:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(169, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Auto close after game launch";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SaveCfgBtn
            // 
            this.SaveCfgBtn.Location = new System.Drawing.Point(129, 259);
            this.SaveCfgBtn.Name = "SaveCfgBtn";
            this.SaveCfgBtn.Size = new System.Drawing.Size(102, 23);
            this.SaveCfgBtn.TabIndex = 7;
            this.SaveCfgBtn.Text = "Save Changes";
            this.SaveCfgBtn.UseVisualStyleBackColor = true;
            this.SaveCfgBtn.Click += new System.EventHandler(this.SaveCfgBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(6, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.GotFocus += new System.EventHandler(this.textbox1_Enter);
            this.textBox1.LostFocus += new System.EventHandler(this.textbox1_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(369, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Fortnite Path:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.GitHubSourceBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.OpenGameFolderBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DeleteAllAccountsBtn);
            this.panel1.Controls.Add(this.ResetConfigsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(372, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 292);
            this.panel1.TabIndex = 1;
            // 
            // GitHubSourceBtn
            // 
            this.GitHubSourceBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GitHubSourceBtn.Location = new System.Drawing.Point(0, 269);
            this.GitHubSourceBtn.Name = "GitHubSourceBtn";
            this.GitHubSourceBtn.Size = new System.Drawing.Size(175, 23);
            this.GitHubSourceBtn.TabIndex = 11;
            this.GitHubSourceBtn.Text = "GitHub Repository";
            this.GitHubSourceBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 23);
            this.panel3.TabIndex = 5;
            // 
            // OpenGameFolderBtn
            // 
            this.OpenGameFolderBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenGameFolderBtn.Location = new System.Drawing.Point(0, 76);
            this.OpenGameFolderBtn.Name = "OpenGameFolderBtn";
            this.OpenGameFolderBtn.Size = new System.Drawing.Size(175, 23);
            this.OpenGameFolderBtn.TabIndex = 10;
            this.OpenGameFolderBtn.Text = "Open Fortnite installation folder";
            this.OpenGameFolderBtn.UseVisualStyleBackColor = true;
            this.OpenGameFolderBtn.Click += new System.EventHandler(this.OpenGameFolderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 30);
            this.panel2.TabIndex = 4;
            // 
            // DeleteAllAccountsBtn
            // 
            this.DeleteAllAccountsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteAllAccountsBtn.Location = new System.Drawing.Point(0, 23);
            this.DeleteAllAccountsBtn.Name = "DeleteAllAccountsBtn";
            this.DeleteAllAccountsBtn.Size = new System.Drawing.Size(175, 23);
            this.DeleteAllAccountsBtn.TabIndex = 9;
            this.DeleteAllAccountsBtn.Text = "Remove all saved accounts";
            this.DeleteAllAccountsBtn.UseVisualStyleBackColor = true;
            this.DeleteAllAccountsBtn.Click += new System.EventHandler(this.DeleteAllAccountsBtn_Click);
            // 
            // ResetConfigsBtn
            // 
            this.ResetConfigsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResetConfigsBtn.Location = new System.Drawing.Point(0, 0);
            this.ResetConfigsBtn.Name = "ResetConfigsBtn";
            this.ResetConfigsBtn.Size = new System.Drawing.Size(175, 23);
            this.ResetConfigsBtn.TabIndex = 8;
            this.ResetConfigsBtn.Text = "Restore default settings";
            this.ResetConfigsBtn.UseVisualStyleBackColor = true;
            this.ResetConfigsBtn.Click += new System.EventHandler(this.ResetConfigsBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 335);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 16);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Support A Creator - Sprintermax";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel1.Location = new System.Drawing.Point(407, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 16);
            this.linkLabel1.TabIndex = 100;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://twitter.com/Sprintermax";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TwitterLinkClicked);
            // 
            // LaunchGameBtn
            // 
            this.LaunchGameBtn.Location = new System.Drawing.Point(224, 138);
            this.LaunchGameBtn.Name = "LaunchGameBtn";
            this.LaunchGameBtn.Size = new System.Drawing.Size(102, 23);
            this.LaunchGameBtn.TabIndex = 8;
            this.LaunchGameBtn.Text = "Temp Launch";
            this.LaunchGameBtn.UseVisualStyleBackColor = true;
            this.LaunchGameBtn.Click += new System.EventHandler(this.LaunchGameBtn_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 142);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox3.Size = new System.Drawing.Size(177, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Launch with Epic Games Store";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.RootPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Text = "FNToolKit";
            this.RootPanel.ResumeLayout(false);
            this.TabScreen.ResumeLayout(false);
            this.StartTab.ResumeLayout(false);
            this.DetailsTab.ResumeLayout(false);
            this.DetailsTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel RootPanel;
        private System.Windows.Forms.TabControl TabScreen;
        private System.Windows.Forms.TabPage StartTab;
        private System.Windows.Forms.TabPage FriendsTab;
        private System.Windows.Forms.TabPage OperationsTab;
        private System.Windows.Forms.TabPage AccountsTab;
        private System.Windows.Forms.TabPage DetailsTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GitHubSourceBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OpenGameFolderBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteAllAccountsBtn;
        private System.Windows.Forms.Button ResetConfigsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveCfgBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button SearchGameFolderBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LaunchGameBtn;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

