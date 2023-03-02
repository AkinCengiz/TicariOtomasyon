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
    public partial class FrmEmployees : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmEmployees()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadCities();
            cmbCities.SelectedIndex = 0;
        }

        private void LoadEmployees()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Employees", _connection.Connection());
            adapter.Fill(dataTable);
            dgvEmployees.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "insert into Employees (FirstName, LastName,Telephone, IdentityNumber,City,Town,Mail,Address,Duty) values (@FirstName, @LastName,@Telephone, @IdentityNumber,@City,@Town,@Mail,@Address,@Duty)",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            _sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone", mtxtTelephone.Text);
            _sqlCommand.Parameters.AddWithValue("@IdentityNumber", mtxtIdentityNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Mail", txtMail.Text);
            _sqlCommand.Parameters.AddWithValue("@Address", rtxtAddress.Text);
            _sqlCommand.Parameters.AddWithValue("@Duty", txtDuty.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadEmployees();
            LoadCities();
            FormControlsClear();
        }

        void LoadCities()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Cities", _connection.Connection());
            adapter.Fill(dataTable);
            cmbCities.DataSource = dataTable;
            cmbCities.DisplayMember = "CityName";
            cmbCities.ValueMember = "CityId";
        }

        void LoadTowns(int id)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter =
                new SqlDataAdapter("select * from Towns where City=" + id, _connection.Connection());
            adapter.Fill(dataTable);
            cmbTowns.DataSource = dataTable;
            cmbTowns.DisplayMember = "TownName";
            cmbTowns.ValueMember = "TownId";
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTowns(Convert.ToInt32(cmbCities.SelectedIndex + 1));
            cmbTowns.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "update Employees set FirstName=@FirstName, LastName=@LastName, Telephone=@Telephone, IdentityNumber=@IdentityNumber, City=@City, Town=@Town, Mail=@Mail, Address=@Address, Duty=@Duty where EmployeeId=@EmployeeId",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            _sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone", mtxtTelephone.Text);
            _sqlCommand.Parameters.AddWithValue("@IdentityNumber", mtxtIdentityNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Mail", txtMail.Text);
            _sqlCommand.Parameters.AddWithValue("@Address", rtxtAddress.Text);
            _sqlCommand.Parameters.AddWithValue("@Duty", txtDuty.Text);
            _sqlCommand.Parameters.AddWithValue("@EmployeeId", txtId.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadEmployees();
            LoadCities();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("delete from Employees where EmployeeId=@EmployeeId",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@EmployeeId", Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            LoadEmployees();
            LoadCities();
            FormControlsClear();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                try
                {
                    txtId.Text = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
                    txtFirstName.Text = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
                    txtLastName.Text = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
                    mtxtTelephone.Text = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
                    mtxtIdentityNumber.Text = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
                    cmbCities.SelectedValue = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[5].Value);
                    cmbTowns.SelectedValue = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[6].Value);
                    txtMail.Text = dgvEmployees.CurrentRow.Cells[7].Value.ToString();
                    rtxtAddress.Text = dgvEmployees.CurrentRow.Cells[8].Value.ToString();
                    txtDuty.Text = dgvEmployees.CurrentRow.Cells[9].Value.ToString();
                }
                catch 
                {
                    
                }
                
            }
        }

        void FormControlsClear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMail.Clear();
            txtDuty.Clear();
            mtxtIdentityNumber.Clear();
            mtxtTelephone.Clear();
            cmbCities.SelectedIndex = 0;
            rtxtAddress.Clear();
        }
    }
}
