using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Numismatic_Shop
{
    public partial class administrator_logon : Form
    {
        public administrator_logon()
        {
            InitializeComponent();
            
        }
        #region logowanie
        private void login_button_Click(object sender, EventArgs e)
        {
            Bitmap image1;
            
            if (user_box.Text == "admin" & pass_box.Text == "admin")
            {
                help_window.Text = "Witaj na koncie admin, logowanie przebieglo pomyslnie";
                label5.BackColor = System.Drawing.Color.Green;
                label6.BackColor = System.Drawing.Color.Green;
                logon_box.Dispose();
                Admin_Panel admin2 = new Admin_Panel();
                {
                    admin2.Show();
                    Thread.Sleep(100);
                    this.Hide();
                }
            }
            else
            {
                help_window.Text = "Hasło lub login nie jest poprawne";
                #region bitmapa
                image1 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image252.bmp", true);
                logon_box.Image = image1;
                #endregion
                #region kwadraty obok logowania
                label5.BackColor = System.Drawing.Color.Red;
                label6.BackColor = System.Drawing.Color.Red;

                
            }
        }
        #endregion
        #endregion
        private void user_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_box_TextChanged(object sender, EventArgs e)
        {
            pass_box.PasswordChar = '*';
            pass_box.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void help_window_TextChanged(object sender, EventArgs e)
        {

        }
        #region stripe menu + minimalizowanie
        private void powrótToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            {
                start.Show();
                this.Hide();
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void przywróćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            notifyIcon1.Visible = false;
        }
        #endregion
        #region clear
        private void Clear_button_Click_1(object sender, EventArgs e)
        {
            help_window.Clear();
            user_box.Clear();
            pass_box.Clear();
            label5.BackColor = System.Drawing.Color.White;
            label6.BackColor = System.Drawing.Color.White;
            logon_box.Dispose();
        }
        #endregion
    }
}
