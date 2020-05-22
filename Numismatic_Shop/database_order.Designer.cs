namespace Numismatic_Shop
{
    partial class database_order
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekranLogowaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimalizujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.przywróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idproduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrodzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordernumismaticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_numismaticDataSet = new Numismatic_Shop.Order_numismaticDataSet();
            this.fKRodzajProduktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKRodzajProduktBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produktBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.produktTableAdapter = new Numismatic_Shop.Order_numismaticDataSetTableAdapters.ProduktTableAdapter();
            this.rodzajTableAdapter = new Numismatic_Shop.Order_numismaticDataSetTableAdapters.RodzajTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordernumismaticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_numismaticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRodzajProduktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRodzajProduktBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekranLogowaniaToolStripMenuItem,
            this.minimalizujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduktDataGridViewTextBoxColumn,
            this.idrodzajDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 445);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idproduktDataGridViewTextBoxColumn
            // 
            this.idproduktDataGridViewTextBoxColumn.DataPropertyName = "id_produkt";
            this.idproduktDataGridViewTextBoxColumn.HeaderText = "id_produkt";
            this.idproduktDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idproduktDataGridViewTextBoxColumn.Name = "idproduktDataGridViewTextBoxColumn";
            this.idproduktDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproduktDataGridViewTextBoxColumn.Width = 125;
            // 
            // idrodzajDataGridViewTextBoxColumn
            // 
            this.idrodzajDataGridViewTextBoxColumn.DataPropertyName = "id_rodzaj";
            this.idrodzajDataGridViewTextBoxColumn.HeaderText = "id_rodzaj";
            this.idrodzajDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idrodzajDataGridViewTextBoxColumn.Name = "idrodzajDataGridViewTextBoxColumn";
            this.idrodzajDataGridViewTextBoxColumn.ReadOnly = true;
            this.idrodzajDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.cenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            this.ilośćDataGridViewTextBoxColumn.ReadOnly = true;
            this.ilośćDataGridViewTextBoxColumn.Width = 125;
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataMember = "Produkt";
            this.produktBindingSource.DataSource = this.ordernumismaticDataSetBindingSource;
            // 
            // ordernumismaticDataSetBindingSource
            // 
            this.ordernumismaticDataSetBindingSource.DataSource = this.order_numismaticDataSet;
            this.ordernumismaticDataSetBindingSource.Position = 0;
            // 
            // order_numismaticDataSet
            // 
            this.order_numismaticDataSet.DataSetName = "Order_numismaticDataSet";
            this.order_numismaticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKRodzajProduktBindingSource
            // 
            this.fKRodzajProduktBindingSource.DataMember = "FK_Rodzaj_Produkt";
            this.fKRodzajProduktBindingSource.DataSource = this.produktBindingSource;
            // 
            // produktBindingSource1
            // 
            this.produktBindingSource1.DataMember = "Produkt";
            this.produktBindingSource1.DataSource = this.ordernumismaticDataSetBindingSource;
            // 
            // fKRodzajProduktBindingSource1
            // 
            this.fKRodzajProduktBindingSource1.DataMember = "FK_Rodzaj_Produkt";
            this.fKRodzajProduktBindingSource1.DataSource = this.produktBindingSource;
            // 
            // produktBindingSource2
            // 
            this.produktBindingSource2.DataMember = "Produkt";
            this.produktBindingSource2.DataSource = this.ordernumismaticDataSetBindingSource;
            // 
            // produktTableAdapter
            // 
            this.produktTableAdapter.ClearBeforeFill = true;
            // 
            // rodzajTableAdapter
            // 
            this.rodzajTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kalkulator podręczny do ceny";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(800, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ilość";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(800, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Do zapłaty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            // 
            // database_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1087, 605);
            this.MinimumSize = new System.Drawing.Size(1087, 605);
            this.Name = "database_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "database_order";
            this.Load += new System.EventHandler(this.database_order_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordernumismaticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_numismaticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRodzajProduktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRodzajProduktBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekranLogowaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimalizujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem przywróćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ordernumismaticDataSetBindingSource;
        private Order_numismaticDataSet order_numismaticDataSet;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private Order_numismaticDataSetTableAdapters.ProduktTableAdapter produktTableAdapter;
        private System.Windows.Forms.BindingSource fKRodzajProduktBindingSource;
        private Order_numismaticDataSetTableAdapters.RodzajTableAdapter rodzajTableAdapter;
        private System.Windows.Forms.BindingSource produktBindingSource1;
        private System.Windows.Forms.BindingSource fKRodzajProduktBindingSource1;
        private System.Windows.Forms.BindingSource produktBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrodzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}