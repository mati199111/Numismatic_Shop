using System;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatic_Shop
{

    public partial class helper : Form
    {
        
        public helper()
        {
            InitializeComponent();
            InitializeEvent();
        }
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
        #endregion
        #region chowane_menu
        private void przywróćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            notifyIcon1.Visible = false;
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ekranLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            {
                start.Show();
                Thread.Sleep(1000);
                this.Hide();
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

        private void zakończToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
        
        
        protected virtual void onWait()
        {
            //wait.Invoke();
        }

        private void helper_Load(object sender, EventArgs e)
        {
           
            
        }
        #region thread
        private void button1_Click(object sender, EventArgs e)
        {
            var thread = new Thread(startCounting);
            thread.IsBackground = true;
            thread.Start();
            button1.Enabled = false;
        }
        private delegate void DisplayCount(int i);
        private delegate void EnableButton();
        private void startCounting()
        {
            for(var i = 0; i < 10; i++)
            {
                textBox1.Invoke(new DisplayCount(display), 1);
                Thread.Sleep(300);
            }
            button1.Invoke(new EnableButton(Enable));
        }
        private void Enable()
        {
            button1.Enabled = true;
        }
        private void display(int i)
        {
            textBox1.Text = i.ToString();
        }
        #endregion
        #region delegaty_cd.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = event_test.onCalculate(this.textBox2.Text, this.textBox3.Text).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = event_test.onCalculate(this.textBox2.Text, this.textBox3.Text).ToString();
        }
        
        #region asynchronicznosc
        public async Task<int> InstallAsync(int value)
        {
            int x = 0;
            return await Task.Factory.StartNew(()=>
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
            txtStatus.Text += "\r\nCoffe now...";
            for(int i = 0; i<100;i++)
                Thread.Sleep(5);
        }
        public void Relax()
        {
            txtStatus.Text += "\r\nrelax";
            //for (int i = 0; i < 100; i++)
                Thread.Sleep(100);
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Installing..";
            //Thread.Sleep(300);
            Task<int> task = InstallAsync(200);
            DoSom();
            Relax();
            int total = await task;
            txtStatus.Text += string.Format("\r\nCompleete.. total installed: {0}", total);
        }
        #endregion
    }
    #endregion

}
