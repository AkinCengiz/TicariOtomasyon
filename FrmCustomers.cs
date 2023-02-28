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
            _connection.Connection().Close();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            txtFirstName.Text = dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            mtxtTelephone1.Text = dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            mtxtTelephone2.Text = dgvCustomers.CurrentRow.Cells[4].Value.ToString();
            mtxtIdentityNumber.Text = dgvCustomers.CurrentRow.Cells[5].Value.ToString();
            txtMail.Text = dgvCustomers.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter =
                new SqlDataAdapter("select * from Towns where City=" + cmbCities.SelectedValue.ToString(),
                    _connection.Connection());
            adapter.Fill(dataTable);
            cmbTowns.DataSource = dataTable;
            cmbTowns.DisplayMember = "TownName";
            cmbTowns.ValueMember = "TownId";
        }
    }
}
