using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class FrmLogin : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmLogin()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("select * from Users where UserName=@UserName and UserPassword=@Password", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@UserName", txtUser.Text);
            _sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtUser.Clear();
            }
            reader.Close();
            _connection.Connection().Close();

        }
    }
}
