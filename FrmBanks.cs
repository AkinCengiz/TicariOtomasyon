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
using DevExpress.Mvvm.Native;

namespace TicariOtomasyon
{
    public partial class FrmBanks : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmBanks()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            LoadBanks();
            LoadCompanies();
            LoadCities();
            cmbTowns.Text = "";
        }

        private void LoadCities()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Cities", _connection.Connection());
            adapter.Fill(dataTable);
            cmbCities.DataSource = dataTable;
            cmbCities.DisplayMember = "CityName";
            cmbCities.ValueMember = "CityId";
            cmbCities.Text = "Seçiniz...";
        }

        private void LoadCompanies()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Companies", _connection.Connection());
            adapter.Fill(dataTable);
            cmbCompanies.DataSource = dataTable;
            cmbCompanies.DisplayMember = "CompanyName";
            cmbCompanies.ValueMember = "CompanyId";
            cmbCompanies.Text = "Seçiniz...";
        }

        private void LoadBanks()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select b.BankId as [Banka ID], b.BankName as [Banka Adı],c.CityName as [Şehir], t.TownName as [İlçe], b.Branch as [Şube], b.IBAN as [IBAN Numarası], b.AccountNumber as [Hesap Numarası],b.Official as [Yetkili],b.Date as [Tarih], b.AccountType as [Hesap Türü], com.CompanyName as [Şirket Ünvanı] from Banks as b inner join Cities as c on b.City=c.CityId inner join Towns as t on b.Town=t.TownId inner join Companies as com on b.Company=com.CompanyId", _connection.Connection());
            adapter.Fill(dataTable);
            dgvBanks.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "insert into Banks (BankName, City, Town, Branch, IBAN, AccountNumber, Official, Date, AccountType, Company) values (@BankName, @City, @Town, @Branch, @IBAN, @AccountNumber, @Official, @Date, @AccountType, @Company)",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@BankName", txtBankName.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Branch", txtBranch.Text);
            _sqlCommand.Parameters.AddWithValue("@IBAN", mtxtIban.Text);
            _sqlCommand.Parameters.AddWithValue("@AccountNumber", mtxtAccountNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@Official", txtOfficial.Text);
            _sqlCommand.Parameters.AddWithValue("@Date", dtpBanksDate.Value);
            _sqlCommand.Parameters.AddWithValue("@AccountType", txtAccountType.Text);
            _sqlCommand.Parameters.AddWithValue("@Company", Convert.ToInt32(cmbCompanies.SelectedValue));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadBanks();
            LoadCities();
            LoadCompanies();
            FormControlsClear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "update Banks set BankName=@BankName, City=@City, Town=@Town, Branch=@Branch, IBAN=@IBAN, AccountNumber=@AccountNumber, Official=@Official, Date=@Date, AccountType=@AccountType, Company=@Company where BankId=@BankId",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@BankName", txtBankName.Text);
            _sqlCommand.Parameters.AddWithValue("@City", Convert.ToInt32(cmbCities.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Town", Convert.ToInt32(cmbTowns.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Branch", txtBranch.Text);
            _sqlCommand.Parameters.AddWithValue("@IBAN", mtxtIban.Text);
            _sqlCommand.Parameters.AddWithValue("@AccountNumber", mtxtAccountNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@Official", txtOfficial.Text);
            _sqlCommand.Parameters.AddWithValue("@Date", dtpBanksDate.Value);
            _sqlCommand.Parameters.AddWithValue("@AccountType", txtAccountType.Text);
            _sqlCommand.Parameters.AddWithValue("@Company", Convert.ToInt32(cmbCompanies.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@BankId", txtId.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadBanks();
            LoadCities();
            LoadCompanies();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("delete from Banks where BankId=@BankId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@BankId", Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadBanks();
            LoadCities();
            LoadCompanies();
            FormControlsClear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTowns(Convert.ToInt32(cmbCities.SelectedIndex + 1));
        }

        private void LoadTowns(int id)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Towns where City=" + id, _connection.Connection());
            adapter.Fill(dataTable);
            cmbTowns.DataSource = dataTable;
            cmbTowns.DisplayMember = "TownName";
            cmbTowns.ValueMember = "TownId";
        }

        void FormControlsClear()
        {
            txtId.Clear();
            txtAccountType.Clear();
            txtBranch.Clear();
            txtOfficial.Clear();
            txtBankName.Clear();
            mtxtAccountNumber.Clear();
            dtpBanksDate.ResetText();
            mtxtIban.Clear();
            cmbCities.SelectedIndex = 0;
            cmbCompanies.Text = "Seçiniz...";
            cmbCities.Text = "Seçiniz...";
            cmbTowns.Text = "";
        }

        private void dgvBanks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBanks.CurrentRow != null)
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "select City,Town,Company from Banks where BankId=" +
                        dgvBanks.CurrentRow.Cells[0].Value.ToString(), _connection.Connection());
                adapter.Fill(dataTable);
                try
                {
                    txtId.Text = dgvBanks.CurrentRow.Cells[0].Value.ToString();
                    txtBankName.Text = dgvBanks.CurrentRow.Cells[1].Value.ToString();
                    cmbCities.SelectedValue = dataTable.Rows[0][0].ToString();
                    cmbTowns.SelectedValue = dataTable.Rows[0][1].ToString();
                    txtBranch.Text = dgvBanks.CurrentRow.Cells[4].Value.ToString();
                    mtxtIban.Text = dgvBanks.CurrentRow.Cells[5].Value.ToString();
                    mtxtAccountNumber.Text = dgvBanks.CurrentRow.Cells[6].Value.ToString();
                    txtOfficial.Text = dgvBanks.CurrentRow.Cells[7].Value.ToString();
                    dtpBanksDate.Value = Convert.ToDateTime(dgvBanks.CurrentRow.Cells[8].Value);
                    txtAccountType.Text = dgvBanks.CurrentRow.Cells[9].Value.ToString();
                    cmbCompanies.SelectedValue = dataTable.Rows[0][2].ToString();
                }
                catch 
                {
                    
                }
            }
        }
    }
}
