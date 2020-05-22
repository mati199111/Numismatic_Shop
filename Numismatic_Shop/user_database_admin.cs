using System;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Numismatic_Shop
{
    public partial class user_database_admin : Form
    {
        #region sqlconnection
        SqlConnection Connect = new SqlConnection("Data Source=.;Initial Catalog=helper;Persist Security Info=True;User ID=sa;Password=mateusz");
        #endregion
        #region contructor
        public user_database_admin()
        {
            InitializeComponent();
        }
        #endregion
        #region notyficon + menu
        private void ekranLogowaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 start = new Form1();
            {
                start.Show();
                Thread.Sleep(300);
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        #endregion
        #region display_database
        private void button2_Click(object sender, EventArgs e)
        {
            display_mode();
        }
        #endregion
        public void display_mode()
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("select * from user2", Connect);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connect.Close();
            
        }
        #region insert_data
        private void button1_Click(object sender, EventArgs e)
        {
            Connect.Open();
            SqlCommand cmd = Connect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into user2 (id, imie, nazwisko) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            Connect.Close();
            MessageBox.Show("Dopisano");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        #endregion

        #region delete
        private void button3_Click(object sender, EventArgs e)
        {
            Connect.Open();
            SqlCommand cmd = new SqlCommand("delete dbo.user2 where id=@id", Connect);
            cmd.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            Connect.Close();
            MessageBox.Show("Skasowano");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }
        #endregion


    }
}
