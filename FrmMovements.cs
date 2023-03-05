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
    public partial class FrmMovements : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmMovements()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmMovements_Load(object sender, EventArgs e)
        {
            LoadCompanyMovements();
            LoadCustomerMovements();
        }

        private void LoadCustomerMovements()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("exec GetCustomerMovements", _connection.Connection());
            adapter.Fill(dataTable);
            dgvCustomers.DataSource = dataTable;
        }

        void LoadCompanyMovements()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("exec GetCompanyMovements", _connection.Connection());
            adapter.Fill(dataTable);
            dgvCompanies.DataSource = dataTable;
        }
    }
}
