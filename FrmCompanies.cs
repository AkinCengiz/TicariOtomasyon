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
    public partial class FrmCompanies : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmCompanies()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmCompanies_Load(object sender, EventArgs e)
        {
            LoadCompanies();
            LoadCities();
        }

        private void LoadCities()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Cities",_connection.Connection());
            adapter.Fill(dataTable);
            cmbCities.DataSource = dataTable;
            cmbCities.DisplayMember = "CityName";
            cmbCities.ValueMember = "CityId";
        }

        private void LoadCompanies()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Companies", _connection.Connection());
            adapter.Fill(dataTable);
            dgvCompanies.DataSource = dataTable;
        }

        private void LoadTowns(int id)
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
            LoadTowns(Convert.ToInt32(cmbCities.SelectedIndex+1));
            cmbTowns.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("insert into Companies (CompanyName, OfficialStatu, OfficialName, OfficialSurname, Telephone, Telephone2, Telephone3, Fax, Mail, Address, City, Town, TaxAdministration, TaxNumber) values (@CompanyName, @OfficialStatu, @OfficialName, @OfficialSurname, @Telephone, @Telephone2, @Telephone3, @Fax, @Mail, @Address, @City, @Town, @TaxAdministration, @TaxNumber)", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            _sqlCommand.Parameters.AddWithValue("@OfficialStatu", txtOffficialStatu.Text);
            _sqlCommand.Parameters.AddWithValue("@OfficialName", txtFirstName.Text);
            _sqlCommand.Parameters.AddWithValue("@OfficialSurname", txtLastName.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone", mtxtTelephone1.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone2", mtxtTelephone2.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone3", mtxtTelephone3.Text);
            _sqlCommand.Parameters.AddWithValue("@Fax", mtxtFax.Text);
            _sqlCommand.Parameters.AddWithValue("@Mail", txtMail.Text);
            _sqlCommand.Parameters.AddWithValue("@Address", rtxtAddress.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@TaxAdministration", txtTaxAdminisration.Text);
            _sqlCommand.Parameters.AddWithValue("@TaxNumber", mtxtTaxNumber.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadCompanies();
            LoadCities();
            FormControlsClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("update Companies set CompanyName=@CompanyName, OfficialStatu=@OfficialStatu, OfficialName=@OfficialName, OfficialSurname=@OfficialSurname, Telephone=@Telephone, Telephone2=@Telephone2, Telephone3=@Telephone3, Fax=@Fax, Mail=@Mail, Address=@Address, City=@City, Town=@Town, TaxAdministration=@TaxAdministration, TaxNumber=@TaxNumber where CompanyId=@CompanyId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            _sqlCommand.Parameters.AddWithValue("@OfficialStatu", txtOffficialStatu.Text);
            _sqlCommand.Parameters.AddWithValue("@OfficialName", txtFirstName.Text);
            _sqlCommand.Parameters.AddWithValue("@OfficialSurname", txtLastName.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone", mtxtTelephone1.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone2", mtxtTelephone2.Text);
            _sqlCommand.Parameters.AddWithValue("@Telephone3", mtxtTelephone3.Text);
            _sqlCommand.Parameters.AddWithValue("@Fax", mtxtFax.Text);
            _sqlCommand.Parameters.AddWithValue("@Mail", txtMail.Text);
            _sqlCommand.Parameters.AddWithValue("@Address", rtxtAddress.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@TaxAdministration", txtTaxAdminisration.Text);
            _sqlCommand.Parameters.AddWithValue("@TaxNumber", mtxtTaxNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@CompanyId",Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadCompanies();
            LoadCities();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("Delete from Companies where CompanyId=@CompanyId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@CompanyId",Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadCompanies();
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
            txtMail.Clear();
            txtLastName.Clear();
            txtTaxAdminisration.Clear();
            txtCompanyName.Clear();
            txtOffficialStatu.Clear();
            rtxtAddress.Clear();
            mtxtTaxNumber.Clear();
            mtxtFax.Clear();
            mtxtTelephone1.Clear();
            mtxtTelephone2.Clear();
            mtxtTelephone3.Clear();
            cmbCities.SelectedIndex = 0;
        }

        private void dgvCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCompanies.CurrentRow != null)
            {
                try
                {
                    txtId.Text = dgvCompanies.CurrentRow.Cells[0].Value.ToString();
                    txtCompanyName.Text = dgvCompanies.CurrentRow.Cells[1].Value.ToString();
                    txtOffficialStatu.Text = dgvCompanies.CurrentRow.Cells[2].Value.ToString();
                    txtFirstName.Text = dgvCompanies.CurrentRow.Cells[3].Value.ToString();
                    txtLastName.Text = dgvCompanies.CurrentRow.Cells[4].Value.ToString();
                    mtxtTelephone1.Text = dgvCompanies.CurrentRow.Cells[5].Value.ToString();
                    mtxtTelephone2.Text = dgvCompanies.CurrentRow.Cells[6].Value.ToString();
                    mtxtTelephone3.Text = dgvCompanies.CurrentRow.Cells[7].Value.ToString();
                    mtxtFax.Text = dgvCompanies.CurrentRow.Cells[8].Value.ToString();
                    txtMail.Text = dgvCompanies.CurrentRow.Cells[9].Value.ToString();
                    rtxtAddress.Text = dgvCompanies.CurrentRow.Cells[10].Value.ToString();
                    cmbCities.SelectedValue = Convert.ToInt32(dgvCompanies.CurrentRow.Cells[11].Value);
                    cmbTowns.SelectedValue = Convert.ToInt32(dgvCompanies.CurrentRow.Cells[12].Value);
                    txtTaxAdminisration.Text = dgvCompanies.CurrentRow.Cells[13].Value.ToString();
                    mtxtTaxNumber.Text = dgvCompanies.CurrentRow.Cells[14].Value.ToString();
                }
                catch 
                {
                    
                }
            }
        }
    }
}
