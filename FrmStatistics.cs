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
    public partial class FrmStatistics : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmStatistics()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            GetCustomerMovements();
            GetCompanyMovements();
            GetTotal();
            GetPayment();
            GetCityCount();
            GetCustomerCityCount();
            GetCustomerCount();
            GetCompanyCount();
            GetEmployeeCount();
            GetTotalStocks();
        }

        private void GetTotalStocks()
        {
            _sqlCommand = new SqlCommand("select sum(Amount) from Products", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblStockCount.Text = reader[0].ToString();
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void GetEmployeeCount()
        {
            _sqlCommand = new SqlCommand("select count(*) from Employees", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblEmployeeCount.Text = reader[0].ToString();
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void GetCompanyCount()
        {
            _sqlCommand = new SqlCommand("select count(*) from Companies", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblCompanyCount.Text = reader[0].ToString();
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void GetCustomerCount()
        {
            _sqlCommand = new SqlCommand("select count(*) from Customers", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblCustomerCount.Text = reader[0].ToString();
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void GetCustomerCityCount()
        {
            _sqlCommand = new SqlCommand("select count(distinct(City)) from Customers", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblCustomerCityCount.Text = reader[0].ToString();
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void GetCityCount()
        {
            _sqlCommand = new SqlCommand("select count(distinct(City)) from Companies", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblCityCount.Text = reader[0].ToString();
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void GetCompanyMovements()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("exec GetCompanyMovements", _connection.Connection());
            adapter.Fill(dataTable);
            dgvOutcomeCompanies.DataSource = dataTable;
        }

        void GetCustomerMovements()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("exec GetCustomerMovements",_connection.Connection());
            adapter.Fill(dataTable);
            dgvOutcomeCustomers.DataSource = dataTable;
        }

        void GetTotal()
        {
            _sqlCommand = new SqlCommand("select sum(TotalPrice) from InvoiceDetails", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblTotal.Text = reader[0].ToString() + " TL";
            }
            reader.Close();
            _connection.Connection().Close();
        }

        void GetPayment()
        {
            _sqlCommand = new SqlCommand("select (ElectricityBill + WaterBill + NaturalGasBill + InternetBill + Extra) from Expenses", _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                lblPayment.Text = reader[0].ToString() + " TL";
            }
            reader.Close();
            _connection.Connection().Close();
        }
    }
}
