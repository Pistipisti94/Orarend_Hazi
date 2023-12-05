using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tanorarend
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nev = textBox_nev.Text;
            string jelszo = textBox_jelszo.Text;
            if (string.IsNullOrEmpty(nev) || string.IsNullOrEmpty(jelszo))
            {
                MessageBox.Show("Nem maradhat üres mező!","Not today",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return;
            }
            string parancs = "SELECT `tanarid`, `jelszo` FROM `tanarok` WHERE `tanarnev` = @nev";
            Server.cmd.CommandText = parancs;
            Server.cmd.Parameters.Clear();
            Server.cmd.Parameters.AddWithValue("@nev",nev);
            MySqlDataReader myr =  Server.cmd.ExecuteReader();
            if (myr.Read())
            {
                string lekertjelszo = myr.GetString("jelszo");
                if (lekertjelszo.Equals(jelszo))
                {
                    Server.userId = myr.GetInt32("tanarid").ToString();
                    myr.Close();
                    Program.orarend.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            
        
    }
}
