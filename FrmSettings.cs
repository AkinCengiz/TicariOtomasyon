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
    public partial class FrmSettings : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmSettings()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Users", _connection.Connection());
            adapter.Fill(dataTable);
            dgvUsers.DataSource = dataTable;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "GÜNCELLE";
            if (dgvUsers.CurrentRow != null)
            {
                txtUserName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "KAYDET")
            {
                _sqlCommand = new SqlCommand("insert into Users (UserName,UserPassword) values (@User,@Password)",
                    _connection.Connection());
                _sqlCommand.Parameters.AddWithValue("@User", txtUserName.Text);
                _sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                _sqlCommand.ExecuteNonQuery();
                _connection.Connection().Close();
                LoadUsers();
                txtUserName.Clear();
                txtPassword.Clear();
            }
            else
            {
                _sqlCommand = new SqlCommand("update Users set UserPassword=@Password where UserName=@User",
                    _connection.Connection());
                _sqlCommand.Parameters.AddWithValue("@Password", txtPassword.Text);
                _sqlCommand.Parameters.AddWithValue("@User", txtUserName.Text);
                _sqlCommand.ExecuteNonQuery();
                _connection.Connection().Close();
                LoadUsers();
                txtPassword.Clear();
                txtUserName.Clear();
            }
        }
    }
}
