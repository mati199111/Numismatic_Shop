using System;
using System.Windows.Forms;
using System.Threading;

namespace Numismatic_Shop
{
    
    public partial class Admin_Panel : Form
    {
        //private Thread thread2;

        public Admin_Panel()
        {
            InitializeComponent();
        }
        #region strip menu + notifyicon
        private void ekranLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            {
                start.Show();
                Thread.Sleep(500);
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
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        #region database
        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'order_numismaticDataSet1.Produkt' . Możesz go przenieść lub usunąć.
            this.produktTableAdapter.Fill(this.order_numismaticDataSet1.Produkt);

        }
        #endregion
        #region helper_test
        private void button1_Click(object sender, EventArgs e)
        {
            helper uss = new helper();
            uss.Show();
            this.Close();
        }
        #endregion
        #region database_admin
        private void button2_Click(object sender, EventArgs e)
        {
            user_database_admin now = new user_database_admin();
            now.Show();
            this.Hide();
        }
        #endregion
    }
}
