using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Numismatic_Shop
{
    //delegate void sprawdz(string nazwa);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region gdi+
        private void Paint(object sender, PaintEventArgs c)
        {
            Graphics grafika = c.Graphics;
            GraphicsPath mygraphicsPath = new GraphicsPath();
            Point[] myPointArray =
            {
                new Point(5, 30),
                new Point(20, 40),
                new Point(50, 30)
            };
            FontFamily fontFamily = new FontFamily("Times New Roman");
            PointF mypointF = new PointF(50, 20);
            StringFormat mystringFormat = new StringFormat();


            mygraphicsPath.StartFigure();
            mygraphicsPath.AddCurve(myPointArray);
            mygraphicsPath.AddString("Numismatic", fontFamily, 0, 24, mypointF, mystringFormat);
            Pen mypen = new Pen(Color.Black);
            grafika.DrawPath(mypen, mygraphicsPath);
        }
        #endregion
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void user_box_TextChanged(object sender, EventArgs e)
        {

        }
        #region passwordchar
        private void pass_box_TextChanged(object sender, EventArgs e)
        {
           // pass_box.Text = " ";
            pass_box.PasswordChar = '*';
            pass_box.MaxLength = 14;
        }
        #endregion
        #region login button
        private void login_button_Click(object sender, EventArgs e)
        {
            Bitmap image1;
                #region login user
                if (user_box.Text == "user" & pass_box.Text == "user")
                {
                    help_window.Text = "Witaj na koncie użytkownika, logowanie przebieglo pomyslnie";
                    label5.BackColor = System.Drawing.Color.Green;
                    label6.BackColor = System.Drawing.Color.Green;
                logon_box.Dispose();

                User_Panel user2 = new User_Panel();
                {
                    user2.Show();
                    Thread.Sleep(200);
                    this.Hide();
                }

            }
                else
                {
                    help_window.Text = "Hasło lub login nie jest poprawne";
                    #region bitmapa
                    image1 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image1.bmp", true);
                    logon_box.Image = image1;
                    #endregion
                    #region kwadraty obok logowania
                    label5.BackColor = System.Drawing.Color.Red;
                    label6.BackColor = System.Drawing.Color.Red;

                    #endregion
                }
        }
        #endregion
        /*private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }*/
        #region stary guzik
        private void administrator_button_Click(object sender, EventArgs e)
        {
            administrator_logon admin = new administrator_logon();
            {
                admin.Show();
                this.Hide();
            }
        }
        #endregion
        #region tool strip menu + notyficon
        private void minimalizujToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            notifyIcon1.Visible = false;
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimalizujToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Logowanie Sklepu";
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            this.ShowInTaskbar = false;
            this.Visible = false;
        }

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            administrator_logon admin = new administrator_logon();
            {
                admin.Show();
                this.Hide();
            }
        }

        #endregion
        #region przycisk clear
        private void Clear_button_Click(object sender, EventArgs e)
        {
            help_window.Clear();
            user_box.Clear();
            pass_box.Clear();
            label5.BackColor = System.Drawing.Color.White;
            label6.BackColor = System.Drawing.Color.White;
            logon_box.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        #region dymki
        private void login_button_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(login_button, "wpisz login i hasło aby sie zalogować");
        }

        private void Clear_button_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Clear_button, "skasuj wszystko i zacznij od nowa");
        }

        private void administratorToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            //toolTip1.SetToolTip(administrator_logon, "Przejscie do logowania dla admina");
        }
        #endregion



        #endregion

        // #endregion
    }
    /*private void logon_box_Click(object sender, EventArgs e)
    {

    }*/

    #region delegaty
    /// <summary>
    /// delegaty
    /// </summary>
    /// <returns></returns>
    /// 
   

    

    #endregion
}
#endregion