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
    public partial class FrmContact : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        private FrmMail frmMail;
        public FrmContact()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmContact_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "select CompanyName, OfficialName, OfficialSurname, Telephone, Telephone2, Telephone3, Fax, Mail from Companies",
                    _connection.Connection());
            adapter.Fill(dataTable);
            dgvCompanies.DataSource = dataTable;
        }

        private void LoadCustomers()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "select c.FirstName, c.LastName, c.Telephone, c.Telephone2, c.Mail, c.Address,t.TownName, ct.CityName from Customers as c inner join Towns as t on c.Town=t.TownId inner join Cities as ct on c.City=ct.CityId",
                _connection.Connection());
            adapter.Fill(dataTable);
            dgvCustomers.DataSource = dataTable;
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMail = new FrmMail();
            if (dgvCustomers.CurrentRow != null)
            {
                frmMail.Mail = dgvCustomers.CurrentRow.Cells["Mail"].Value.ToString();
            }
            frmMail.Show();
            
        }

        private void dgvCompanies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMail = new FrmMail();
            if (dgvCompanies.CurrentRow != null)
            {
                frmMail.Mail = dgvCompanies.CurrentRow.Cells["Mail"].Value.ToString();
            }
            frmMail.Show();
        }
    }
}
