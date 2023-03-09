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
    public partial class FrmStocks : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmStocks()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCompanies();
            ChartProductFill();
            ChartCompanyFill();
        }

        private void ChartCompanyFill()
        {
            _sqlCommand =
                new SqlCommand(
                    "Select c.CityName, Count(com.CompanyName) from Companies as com inner join Cities as c on com.City=c.CityId group by c.CityName",
                    _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(reader[0].ToString(), Convert.ToInt32(reader[1]));
            }
            reader.Close();
            _connection.Connection().Close();
        }

        private void LoadCompanies()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "Select c.CityName, Count(com.CompanyName) from Companies as com inner join Cities as c on com.City=c.CityId group by c.CityName",
                    _connection.Connection());
            adapter.Fill(dataTable);
            dgvCompanies.DataSource = dataTable;
        }

        private void LoadProducts()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select ProductName, Sum(Amount) as Miktar from Products group by ProductName",_connection.Connection());
            adapter.Fill(dataTable);
            dgvEntities.DataSource = dataTable;
        }

        private void ChartProductFill()
        {
            _sqlCommand = new SqlCommand("select ProductName, Sum(Amount) as Miktar from Products group by ProductName",
                _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(reader[0].ToString(), Convert.ToInt32(reader[1]));
            }
            reader.Close();
            _connection.Connection().Close();
        }
        
    }
}
