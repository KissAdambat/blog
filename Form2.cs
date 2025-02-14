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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        internal static Connect Conn = new Connect();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = (string)textBox2.Text;
            string jelszo = (string)textBox1.Text;

            if(username == "" || jelszo == "")
            {
                MessageBox.Show("Nem adott meg egy vagy több adatot");
            }
            else
            {
                Conn.Connection.Open();

                string sql = "SELECT `UserName`, `Password` FROM `usertable` WHERE 1";

                MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);

                MySqlDataReader dr = cmd.ExecuteReader();

                bool regisztralt = false;

                dr.Read();

                do
                {
                    var felhasznalo = new
                    {
                        UserNameAdatbazis = dr.GetString(0),
                        JelszoAdatbazis = dr.GetString(1),
                    };

                    if (username == felhasznalo.UserNameAdatbazis && jelszo == felhasznalo.JelszoAdatbazis)
                    {
                        regisztralt = true;
                    }


                }
                while (dr.Read());

                if (regisztralt == true)
                {
                    MessageBox.Show("Sikeres Bejelentkezés");
                }
                else
                {
                    MessageBox.Show("Téves felhasználónév vagy jelszó");

                }

                dr.Close();



                Conn.Connection.Close();

                Form1 form1 = new Form1();
                form1.Show();
                this.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;

            label7.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            textBox5.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            button2.Visible = true;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = (string)textBox5.Text;
            string email = (string)textBox4.Text;
            string jelszo = (string)textBox3.Text;

            if (username == "" || email == "" || jelszo == "")
            {
                MessageBox.Show("Nem adott meg egy adatot");
            }
            else
            {
                try
                {

                    Conn.Connection.Open();

                    string sql = $"INSERT INTO `usertable`(`UserName`, `Email`, `Password`) VALUES ('{username}','{email}','{jelszo}')";

                    MySqlCommand cmd = new MySqlCommand(sql, Conn.Connection);
                    cmd.ExecuteNonQuery();

                    Conn.Connection.Close();

                    MessageBox.Show("Sikeres Regisztráció");
                }
                catch (Exception)
                {
                    MessageBox.Show("Nem jó az adatbázis kapcsolódása");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            button3.Visible = true;

            label7.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            textBox5.Visible = false;
            textBox4.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
        }
    }
}
