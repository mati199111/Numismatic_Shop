using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Numismatic_Shop;

namespace Numismatic_Shop
{
    public partial class database_order : Form
    {
        #region contructor form + event
        public database_order()
        {
            InitializeComponent();
            InitializeEvent();
        }
        #endregion
        #region menu
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ekranLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 start2 = new Form1();
            {
                start2.Show();
                this.Hide();
                MessageBox.Show("Zostałes wylogowany");
            }
        }

        private void minimalizujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Logowanie Sklepu";
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            this.ShowInTaskbar = false;
            this.Visible = false;
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void przywróćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            notifyIcon1.Visible = false;
        }

        private void zakończToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region database+menu-cd
        private void database_order_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'order_numismaticDataSet.Rodzaj' . Możesz go przenieść lub usunąć.
            this.rodzajTableAdapter.Fill(this.order_numismaticDataSet.Rodzaj);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'order_numismaticDataSet.Produkt' . Możesz go przenieść lub usunąć.
            this.produktTableAdapter.Fill(this.order_numismaticDataSet.Produkt);

            #region baza recznie
            /*
            order_numismaticDataSet nowa = new order_numismaticDataSet();
            dataGridView1.DataSource = nowa.Produkt;
            string connectionString = "Data Source =.; Initial Catalog = Order_numismatic; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand sql = new SqlCommand("Select * from Produkt", conn);
            conn.Open();
            SqlDataReader r = sql.ExecuteReader();

            while (r.Read()) { nowa.Produkt.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5]); }
            conn.Close();
                */
            #endregion


        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produktTableAdapter.Fill(this.order_numismaticDataSet.Produkt);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.produktTableAdapter.FillBy(this.order_numismaticDataSet.Produkt);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region delegaty
        private void InitializeEvent()
        {
            event_test.kalk += event_test_kalk;
        }
        private int event_test_kalk(object ob1, object ob2)
        {
            int x = 0;
            int y = 0;
            int.TryParse(ob1.ToString(), out x);
            int.TryParse(ob2.ToString(), out y);
            return event_test.Add(x, y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label5.Text = event_test.onCalculate(this.textBox1.Text, this.textBox2.Text).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.label5.Text = event_test.onCalculate(this.textBox1.Text, this.textBox2.Text).ToString();
        }
        #endregion
    }
}
