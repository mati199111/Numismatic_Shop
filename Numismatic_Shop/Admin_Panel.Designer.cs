namespace Numismatic_Shop
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.przywróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranLogowaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimalizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.order_numismaticDataSet1 = new Numismatic_Shop.Order_numismaticDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrodzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordernumismaticDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new Numismatic_Shop.Order_numismaticDataSetTableAdapters.ProduktTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_numismaticDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordernumismaticDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.zakończToolStripMenuItem1.Click += new System.EventHandler(this.zakończToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranLogowaniaToolStripMenuItem,
            this.minimalizujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ekranLogowaniaToolStripMenuItem
            // 
            this.ekranLogowaniaToolStripMenuItem.Name = "ekranLogowaniaToolStripMenuItem";
            this.ekranLogowaniaToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.ekranLogowaniaToolStripMenuItem.Text = "Ekran logowania";
            this.ekranLogowaniaToolStripMenuItem.Click += new System.EventHandler(this.ekranLogowaniaToolStripMenuItem_Click);
            // 
            // minimalizujToolStripMenuItem
            // 
            this.minimalizujToolStripMenuItem.Name = "minimalizujToolStripMenuItem";
            this.minimalizujToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.minimalizujToolStripMenuItem.Text = "Minimalizuj";
            this.minimalizujToolStripMenuItem.Click += new System.EventHandler(this.minimalizujToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Witaj w panelu admina";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // order_numismaticDataSet1
            // 
            this.order_numismaticDataSet1.DataSetName = "Order_numismaticDataSet";
            this.order_numismaticDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduktDataGridViewTextBoxColumn,
            this.idrodzajDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 424);
            this.dataGridView1.TabIndex = 4;
            // 
            // idproduktDataGridViewTextBoxColumn
            // 
            this.idproduktDataGridViewTextBoxColumn.DataPropertyName = "id_produkt";
            this.idproduktDataGridViewTextBoxColumn.HeaderText = "id_produkt";
            this.idproduktDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproduktDataGridViewTextBoxColumn.Name = "idproduktDataGridViewTextBoxColumn";
            this.idproduktDataGridViewTextBoxColumn.Width = 125;
            // 
            // idrodzajDataGridViewTextBoxColumn
            // 
            this.idrodzajDataGridViewTextBoxColumn.DataPropertyName = "id_rodzaj";
            this.idrodzajDataGridViewTextBoxColumn.HeaderText = "id_rodzaj";
            this.idrodzajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrodzajDataGridViewTextBoxColumn.Name = "idrodzajDataGridViewTextBoxColumn";
            this.idrodzajDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            this.ilośćDataGridViewTextBoxColumn.Width = 125;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.ordernumismaticDataSet1BindingSource;
            // 
            // ordernumismaticDataSet1BindingSource
            // 
            this.ordernumismaticDataSet1BindingSource.DataSource = this.order_numismaticDataSet1;
            this.ordernumismaticDataSet1BindingSource.Position = 0;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(831, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Helper";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(865, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forms do ćwiczeń";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(831, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "User_database";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1087, 605);
            this.MinimumSize = new System.Drawing.Size(1087, 605);
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_numismaticDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordernumismaticDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem przywróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranLogowaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimalizujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private Order_numismaticDataSet order_numismaticDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ordernumismaticDataSet1BindingSource;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private Order_numismaticDataSetTableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrodzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}