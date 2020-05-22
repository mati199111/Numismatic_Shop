using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatic_Shop
{
    public partial class User_Panel : Form
    {
        public User_Panel()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        #region notyficon + menu stripe
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
        #region buttons
        private void monety_Click(object sender, EventArgs e)
        {
            Bitmap image2;
            Bitmap image3;
            Bitmap image4;
            Bitmap image5;
            Bitmap image6;
            Bitmap image7;

            #region chwilowe - brak guzikow
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            label9.ResetText();
            #endregion
            #region image
            image2 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image2.bmp", false);
            pictureBox1.Image = image2;
            label2.Text = "1szt. 25 zł";

            image3 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image3.bmp", true);
            pictureBox2.Image = image3;
            label3.Text = "1szt. 30 zł";

            image4 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image4.bmp", true);
            pictureBox3.Image = image4;
            label4.Text = "1szt. 10 zł";

            image5 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image5.bmp", true);
            pictureBox4.Image = image5;
            label5.Text = "1szt. 80 zł";

            image6 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image6.bmp", true);
            pictureBox5.Image = image6;
            label6.Text = "1szt. 25 zł";

            image7 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image7.bmp", true);
            pictureBox6.Image = image7;
            label7.Text = "1szt. 45 zł";
            #endregion

        }

        private void banknoty1_Click(object sender, EventArgs e)
        {

            Bitmap image8;
            Bitmap image9;
            Bitmap image10;
            Bitmap image11;
            Bitmap image12;
            Bitmap image13;
            #region image

            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            label9.ResetText();

            image8 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image8.bmp", false);
            pictureBox1.Image = image8;
            label2.Text = "1szt. 725 zł";

            image9 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image9.bmp", true);
            pictureBox2.Image = image9;
            label3.Text = "1szt. 330 zł";

            image10 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image10.bmp", true);
            pictureBox3.Image = image10;
            label4.Text = "1szt. 210 zł";

            image11 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image11.bmp", true);
            pictureBox4.Image = image11;
            label5.Text = "1szt. 180 zł";

            image12 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image12.bmp", true);
            pictureBox5.Image = image12;
            label6.Text = "1szt. 125 zł";

            image13 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image13.bmp", true);
            pictureBox6.Image = image13;
            label7.Text = "1szt. 95 zł";
            #endregion

        }

        private void banknoty2_Click(object sender, EventArgs e)
        {

            Bitmap image14;
            Bitmap image15;
            Bitmap image16;
            Bitmap image17;
            Bitmap image18;
            Bitmap image19;
            #region image
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            label9.ResetText();

            image14 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image14.bmp", false);
            pictureBox1.Image = image14;
            label2.Text = "1szt. 325 zł";

            image15 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image15.bmp", true);
            pictureBox2.Image = image15;
            label3.Text = "1szt. 230 zł";

            image16 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image16.bmp", true);
            pictureBox3.Image = image16;
            label4.Text = "1szt. 110 zł";

            image17 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image17.bmp", true);
            pictureBox4.Image = image17;
            label5.Text = "1szt. 125 zł";

            image18 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image18.bmp", true);
            pictureBox5.Image = image18;
            label6.Text = "1szt. 525 zł";

            image19 = new Bitmap(@"C:\Users\m_rac\Desktop\do ogarniecia\source\Numismatic_Shop\Numismatic_Shop\image19.bmp", true);
            pictureBox6.Image = image19;
            label7.Text = "1szt. 15 zł";
            #endregion
        }

        private void banknoty3_Click(object sender, EventArgs e)
        {
            label9.Text = "Strona w przygotowaniu / Site under construction";

            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();

            label2.ResetText();
            label3.ResetText();
            label4.ResetText();
            label5.ResetText();
            label6.ResetText();
            label7.ResetText();

        }

        private void banknoty4_Click(object sender, EventArgs e)
        {
            label9.Text = "Strona w przygotowaniu / Site under construction";
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();

            label2.ResetText();
            label3.ResetText();
            label4.ResetText();
            label5.ResetText();
            label6.ResetText();
            label7.ResetText();
        }

        private void banknoty5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region async_button
        private async void order__Click(object sender, EventArgs e)
        {
            database_order user3 = new database_order();
            txtStatus.Text = "Loading database...";
            //Thread.Sleep(300);
            Task<int> task = InstallAsync(200);
            DoSom();
            Relax();
            int total = await task;
            txtStatus.Text += string.Format("\r\nCompleete.. total loaded: {0}", total);
            MessageBox.Show("done");
            user3.Show();
            this.Hide();
        }
        #endregion
        #region progres_bar+timer
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }
        #endregion
        #region async
        public async Task<int> InstallAsync(int value)
        {
            int x = 0;
            return await Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < value; i++)
                {
                    x++;
                    Thread.Sleep(30);
                }
                return x;
            });
        }
        public void DoSom()
        {
            txtStatus.Text += "\r\nWaiting...";
            for (int i = 0; i < 100; i++)
                Thread.Sleep(5);
        }
        public void Relax()
        {
            txtStatus.Text += "\r\nAlmost ready";
            //for (int i = 0; i < 100; i++)
            Thread.Sleep(100);
            #endregion
        }
    }
}
