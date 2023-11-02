using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MysqlTeszt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;uid=root;pwd=;database=test";
            var conn = new MySqlConnection(connString);

            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Mindkét mezőt ki kell tölteni ahhoz hogy be tudj jelentkezni!");
            }
            else
            {
                conn.Open();
                string lekeres = $"SELECT username,password FROM users WHERE username = @Name AND password = @Pass";
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(lekeres, conn);

                adapter.SelectCommand.Parameters.AddWithValue("@Name",usernameInput.Text);
                adapter.SelectCommand.Parameters.AddWithValue("@Pass",passwordInput.Text);
                DataTable dataTable = new DataTable();

                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    main_form();
                }
                else 
                {
                    MessageBox.Show("Nem jó username/password!");
                }

            }
        }
        private void main_form() 
        {
            this.Hide();
            main frm = new main(usernameInput.Text);
            frm.ShowDialog();
            Application.Exit();
        }
    }
}
