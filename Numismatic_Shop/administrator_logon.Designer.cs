namespace Numismatic_Shop
{
    partial class administrator_logon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(administrator_logon));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.user_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.help_window = new System.Windows.Forms.TextBox();
            this.logon_box = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powrótToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimalizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.przywróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logon_box)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.user_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pass_box, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 79);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // user_box
            // 
            this.user_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_box.Location = new System.Drawing.Point(180, 4);
            this.user_box.Margin = new System.Windows.Forms.Padding(4);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(169, 22);
            this.user_box.TabIndex = 2;
            this.user_box.TextChanged += new System.EventHandler(this.user_box_TextChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Użytkownik";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pass_box
            // 
            this.pass_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pass_box.Location = new System.Drawing.Point(180, 43);
            this.pass_box.Margin = new System.Windows.Forms.Padding(4);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(169, 22);
            this.pass_box.TabIndex = 5;
            this.pass_box.UseSystemPasswordChar = true;
            this.pass_box.TextChanged += new System.EventHandler(this.pass_box_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasło";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button.Location = new System.Drawing.Point(243, 149);
            this.login_button.Margin = new System.Windows.Forms.Padding(4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(137, 50);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(16, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 53);
            this.button1.TabIndex = 11;
            this.button1.Text = "Zakończ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(392, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 27);
            this.label6.TabIndex = 14;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(392, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 27);
            this.label5.TabIndex = 13;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help_window
            // 
            this.help_window.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.help_window.Location = new System.Drawing.Point(129, 31);
            this.help_window.Margin = new System.Windows.Forms.Padding(4);
            this.help_window.Name = "help_window";
            this.help_window.Size = new System.Drawing.Size(392, 22);
            this.help_window.TabIndex = 15;
            this.help_window.TextChanged += new System.EventHandler(this.help_window_TextChanged);
            // 
            // logon_box
            // 
            this.logon_box.Location = new System.Drawing.Point(396, 175);
            this.logon_box.Margin = new System.Windows.Forms.Padding(4);
            this.logon_box.Name = "logon_box";
            this.logon_box.Size = new System.Drawing.Size(139, 95);
            this.logon_box.TabIndex = 16;
            this.logon_box.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powrótToolStripMenuItem,
            this.zakończToolStripMenuItem,
            this.minimalizujToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // powrótToolStripMenuItem
            // 
            this.powrótToolStripMenuItem.Name = "powrótToolStripMenuItem";
            this.powrótToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.powrótToolStripMenuItem.Text = "Powrót";
            this.powrótToolStripMenuItem.Click += new System.EventHandler(this.powrótToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // minimalizujToolStripMenuItem
            // 
            this.minimalizujToolStripMenuItem.Name = "minimalizujToolStripMenuItem";
            this.minimalizujToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.minimalizujToolStripMenuItem.Text = "Minimalizuj";
            this.minimalizujToolStripMenuItem.Click += new System.EventHandler(this.minimalizujToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przywróćToolStripMenuItem,
            this.zakończToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 52);
            // 
            // przywróćToolStripMenuItem
            // 
            this.przywróćToolStripMenuItem.Name = "przywróćToolStripMenuItem";
            this.przywróćToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.przywróćToolStripMenuItem.Text = "Przywróć";
            this.przywróćToolStripMenuItem.Click += new System.EventHandler(this.przywróćToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem1
            // 
            this.zakończToolStripMenuItem1.Name = "zakończToolStripMenuItem1";
            this.zakończToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
            this.zakończToolStripMenuItem1.Text = "Zakończ";
            // 
            // Clear_button
            // 
            this.Clear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear_button.Location = new System.Drawing.Point(152, 155);
            this.Clear_button.Margin = new System.Windows.Forms.Padding(4);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(64, 38);
            this.Clear_button.TabIndex = 19;
            this.Clear_button.Text = "Kasuj";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click_1);
            // 
            // administrator_logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 274);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.logon_box);
            this.Controls.Add(this.help_window);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(554, 321);
            this.MinimumSize = new System.Drawing.Size(554, 321);
            this.Name = "administrator_logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "administrator_logon";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logon_box)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox user_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox help_window;
        private System.Windows.Forms.PictureBox logon_box;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powrótToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimalizujToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przywróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem1;
        private System.Windows.Forms.Button Clear_button;
    }
}