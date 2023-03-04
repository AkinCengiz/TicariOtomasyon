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
    public partial class FrmInvoice : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        private static int _invoiceNumber;
        public FrmInvoice()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Companies", _connection.Connection());
            adapter.Fill(dataTable);
            cmbCustomers.DataSource = dataTable;
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "CompanyId";
        }

        private void rdbIndividual_CheckedChanged(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select CustomerId, FirstName + ' ' + LastName as Customer from Customers", _connection.Connection());
            adapter.Fill(dataTable);
            cmbCustomers.DataSource = dataTable;
            cmbCustomers.DisplayMember = "Customer";
            cmbCustomers.ValueMember = "CustomerId";
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            rdbIndividual.Checked = true;
            LoadInvoices();
            LoadEmployees();
            _invoiceNumber = dgvInvoice.RowCount;
        }

        private void LoadInvoices()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Invoices", _connection.Connection());
            adapter.Fill(dataTable);
            dgvInvoice.DataSource = dataTable;
        }

        private void LoadEmployees()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select EmployeeId, FirstName + ' ' + LastName as Employee from Employees", _connection.Connection());
            adapter.Fill(dataTable);
            cmbEmployees.DataSource = dataTable;
            cmbEmployees.DisplayMember = "Employee";
            cmbEmployees.ValueMember = "EmployeeId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("insert into Invoices (Serial, Number, Date, Time, Customer, Employee, IsIndividual) values (@Serial, @Number, @Date, @Time, @Customer, @Employee, @IsIndividual)", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Serial", _invoiceNumber /1000000 < 1 ? "A" : "B");
            _sqlCommand.Parameters.AddWithValue("@Number", (_invoiceNumber).ToString());
            _sqlCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
            _sqlCommand.Parameters.AddWithValue("@Time", dtpHours.Value);
            _sqlCommand.Parameters.AddWithValue("@Customer", cmbCustomers.SelectedValue);
            _sqlCommand.Parameters.AddWithValue("@Employee", cmbEmployees.SelectedValue);
            _sqlCommand.Parameters.AddWithValue("@IsIndividual", rdbIndividual.Checked ? 1 : 0);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadInvoices();
            FormControlsClear();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvInvoice.CurrentRow != null)
            {
                try
                {
                    txtId.Text = dgvInvoice.CurrentRow.Cells[0].Value.ToString();
                    txtSerial.Text = dgvInvoice.CurrentRow.Cells[1].Value.ToString();
                    txtInvoiceNumber.Text = dgvInvoice.CurrentRow.Cells[2].Value.ToString();
                    cmbCustomers.SelectedValue = Convert.ToInt32(dgvInvoice.CurrentRow.Cells[5].Value);
                    cmbEmployees.SelectedValue = Convert.ToInt32(dgvInvoice.CurrentRow.Cells[6].Value);
                    chkCancel.Checked = Convert.ToInt32(dgvInvoice.CurrentRow.Cells[7].Value) == 1 ? true : false;
                    dtpDate.Value = Convert.ToDateTime(dgvInvoice.CurrentRow.Cells[3].Value.ToString());
                    dtpHours.Value = Convert.ToDateTime(dgvInvoice.CurrentRow.Cells[4].Value.ToString());
                    if (Convert.ToInt32(dgvInvoice.CurrentRow.Cells[8].Value) == 1)
                    {
                        rdbIndividual.Checked = true;
                    }
                    else
                    {
                        rdbCorporate.Checked = true;
                    }
                }
                catch 
                {
                    
                }
            }
        }

        void FormControlsClear()
        {
            txtId.Clear();
            txtSerial.Clear();
            txtInvoiceNumber.Clear();
            rdbIndividual.Checked = true;
            cmbCustomers.SelectedIndex = 0;
            cmbEmployees.SelectedIndex = 0;
            chkCancel.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            panelInvoice.SelectedTabPageIndex = 1;
            xtraTabControl1.SelectedTabPage = xTabInvoiceDetail;
            txtInvoice.Text = txtId.Text;

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails()
        {
            
        }
    }
}
