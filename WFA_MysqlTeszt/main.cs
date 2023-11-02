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

namespace WFA_MysqlTeszt
{
    public partial class main : Form
    {
        public string Username { get; set; }
        public main(string username)
        {
            Username = username;
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            string connString = "server=localhost;uid=root;pwd=;database=test";
            var conn = new MySqlConnection(connString);
            conn.Open();
            string lekeres = $"SELECT * FROM users WHERE username = @Name";
            var cmd = new MySqlCommand(lekeres,conn);
            cmd.Parameters.AddWithValue("@Name",Username);
            var reader = cmd.ExecuteReader();
            if (reader.Read()) 
            {
                username.Text = "Username: " + reader["username"].ToString();
                telNumb.Text = "Telephone: " + reader["number"].ToString();
                gender.Text = "Gender: " + reader["gender"].ToString();
            }
        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}
