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
using DevExpress.CodeParser;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.Extensions;

namespace TicariOtomasyon
{
    public partial class FrmCustomers : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        
        public FrmCustomers()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCities();
            cmbCities.SelectedIndex = 0;
        }

        private void LoadCities()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Cities", _connection.Connection());
            adapter.Fill(dataTable);
            cmbCities.DataSource = dataTable;
            cmbCities.DisplayMember = "CityName";
            cmbCities.ValueMember = "CityId";
        }


        private void LoadCustomers()
        {

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Customers",_connection.Connection());
            adapter.Fill(dataTable);
            dgvCustomers.DataSource = dataTable;
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomers.CurrentRow != null)
            {
                try
                {
                    txtId.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
                    txtFirstName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
                    txtLastName.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
                    mtxtTelephone1.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
                    mtxtTelephone2.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
                    mtxtIdentityNumber.Text = dgvCustomers.CurrentRow.Cells[5].Value.ToString();
                    txtMail.Text = dgvCustomers.CurrentRow.Cells[6].Value.ToString();
                    cmbCities.SelectedValue = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[7].Value);
                    cmbTowns.SelectedValue = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[8].Value);
                    rtxtAddress.Text = dgvCustomers.CurrentRow.Cells[9].Value.ToString();
                    txtTaxAdminisration.Text = dgvCustomers.CurrentRow.Cells[10].Value.ToString();
                }
                catch 
                {
                    
                }
                
            }
        }
        

        private void LoadTowns(int id)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Towns where City="+id, _connection.Connection());
            adapter.Fill(dataTable);
            cmbTowns.DataSource = dataTable;
            cmbTowns.DisplayMember = "TownName";
            cmbTowns.ValueMember = "TownId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "insert into Customers (FirstName,LastName,Telephone,Telephone2,IdentificationNumber,Mail,City,Town,Address,TaxAdministration) values (@FirstName,@LastName,@Telephone,@Telephone2,@IdentificationNumber,@Mail,@City,@Town,@Address,@TaxAdministration)",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            _sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone", mtxtTelephone1.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone2", mtxtTelephone2.Text);
            _sqlCommand.Parameters.AddWithValue("@IdentificationNumber", mtxtIdentityNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@Mail", txtMail.Text);
            _sqlCommand.Parameters.AddWithValue("@City",Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Address", rtxtAddress.Text);
            _sqlCommand.Parameters.AddWithValue("@TaxAdministration", txtTaxAdminisration.Text);
            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Connection.Close();
            LoadCustomers();
            LoadCities();
            FormControlsClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "update  Customers set FirstName=@FirstName,LastName=@LastName,Telephone=@Telephone,Telephone2=@Telephone2,IdentificationNumber=@IdentificationNumber,Mail=@Mail,City=@City,Town=@Town,Address=@Address,TaxAdministration=@TaxAdministration where CustomerId=@CustomerId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            _sqlCommand.Parameters.AddWithValue("@LastName", txtLastName.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone", mtxtTelephone1.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone2", mtxtTelephone2.Text);
            _sqlCommand.Parameters.AddWithValue("@IdentificationNumber", mtxtIdentityNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@Mail", txtMail.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Address", rtxtAddress.Text);
            _sqlCommand.Parameters.AddWithValue("@TaxAdministration", txtTaxAdminisration.Text);
            _sqlCommand.Parameters.AddWithValue("@CustomerId", txtId.Text);
            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Connection.Close();
            LoadCustomers();
            LoadCities();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("delete from Customers where CustomerID=@CustomerId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@CustomerId",Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            LoadCustomers();
            LoadCities();
            FormControlsClear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }

        private void FormControlsClear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTaxAdminisration.Clear();
            txtMail.Clear();
            mtxtIdentityNumber.Clear();
            mtxtTelephone1.Clear();
            mtxtTelephone2.Clear();
            cmbCities.SelectedValue = 1;
            cmbTowns.SelectedIndex = 0;
            rtxtAddress.Clear();
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            LoadTowns(Convert.ToInt32(cmbCities.SelectedIndex+1));
            
            cmbTowns.SelectedIndex = 0;
        }

        void GetTown(int id,int city)
        {
            _sqlCommand = new SqlCommand("select * from Towns where TownId=@Id and City=@City",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Id", id);
            _sqlCommand.Parameters.AddWithValue("@City", city);
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                cmbTowns.SelectedItem = reader["TownName"];
            }
        }
    }
}
