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
            SqlDataAdapter adapter =
                new SqlDataAdapter("select CustomerId, FirstName + ' ' + LastName as Customer from Customers",
                    _connection.Connection());
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
            LoadProducts();
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
            SqlDataAdapter adapter =
                new SqlDataAdapter("select EmployeeId, FirstName + ' ' + LastName as Employee from Employees",
                    _connection.Connection());
            adapter.Fill(dataTable);
            cmbEmployees.DataSource = dataTable;
            cmbEmployees.DisplayMember = "Employee";
            cmbEmployees.ValueMember = "EmployeeId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand =
                new SqlCommand(
                    "insert into Invoices (Serial, Number, Date, Time, Customer, Employee, IsIndividual) values (@Serial, @Number, @Date, @Time, @Customer, @Employee, @IsIndividual)",
                    _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Serial", _invoiceNumber / 1000000 < 1 ? "A" : "B");
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
            dtpDate.Value = DateTime.Now;
            dtpHours.Value = DateTime.Now;
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
            LoadInvoiceDetails(Convert.ToInt32(txtInvoice.Text));

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
            //LoadInvoiceDetails();
        }

        private void LoadInvoiceDetails(int invoiceNo)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "select dt.InvoiceDetailId, p.ProductName, p.Brand, p.Model, dt.Amount, dt.UnitPrice, dt.TotalPrice, dt.Invoices from InvoiceDetails as dt inner join Products as p on dt.Product=p.ProductId where dt.Invoices="+invoiceNo,
                _connection.Connection());
            adapter.Fill(dataTable);
            dgvProducts.DataSource = dataTable;
        }

        private void LoadProducts()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select ProductId, ProductName + ' ' + Brand + ' ' + Model as Product from Products", _connection.Connection());
            adapter.Fill(dataTable);
            cmbProducts.DataSource = dataTable;
            cmbProducts.DisplayMember = "Product";
            cmbProducts.ValueMember = "ProductId";
        }

        private decimal _price, _amount = 0;

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = cmbProducts.SelectedIndex + 1;
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products where ProductId=" + id,
                _connection.Connection());
            adapter.Fill(dataTable);
            txtUnitPrice.Text = dataTable.Rows[0][7].ToString();
            _price = Convert.ToDecimal(txtUnitPrice.Text);
            if (txtAmount.Text != "")
            {
                _amount = Convert.ToDecimal(txtAmount.Text);
            }

            txtTotalPrice.Text = CalculateTotal(_amount, _price).ToString();


        }

        void GetProduct(int id)
        {
            _sqlCommand = new SqlCommand("select * from Products where ProductId=" + id,
                _connection.Connection());
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader["SalePrice"].ToString());
                txtUnitPrice.Text = reader["SalePrice"].ToString();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            _amount = Convert.ToDecimal(txtAmount.Text);
            txtTotalPrice.Text = CalculateTotal(_price, _amount).ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _sqlCommand =
                new SqlCommand(
                    "insert into InvoiceDetails (Product, Amount, UnitPrice, TotalPrice, Invoices) values (@Product, @Amount, @UnitPrice, @TotalPrice, @Invoices)",
                    _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Product", Convert.ToInt32(cmbProducts.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text));
            _sqlCommand.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtUnitPrice.Text));
            _sqlCommand.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(txtTotalPrice.Text));
            _sqlCommand.Parameters.AddWithValue("@Invoices", Convert.ToInt32(txtInvoice.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadInvoiceDetails(Convert.ToInt32(txtInvoice.Text));
            DetailsClear();
            
        }

        decimal CalculateTotal(decimal a, decimal b)
        {
            return a * b;
        }

        private void btnDetailClear_Click(object sender, EventArgs e)
        {
            DetailsClear();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter =
                    new SqlDataAdapter(
                        "select Product from InvoiceDetails where InvoiceDetailId=" +
                        dgvProducts.CurrentRow.Cells[0].Value.ToString(), _connection.Connection());
                adapter.Fill(dataTable);
                try
                {
                    txtInvoiceDetailId.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                    cmbProducts.SelectedValue = dataTable.Rows[0][0].ToString();
                    txtAmount.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                    txtInvoice.Text = dgvProducts.CurrentRow.Cells[7].Value.ToString();
                }
                catch 
                {
                    
                }
            }
        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelInvoice.SelectedTabPageIndex = 1;
            xtraTabControl1.SelectedTabPage = xTabInvoiceDetail;
            txtInvoice.Text = txtId.Text;
            LoadInvoiceDetails(Convert.ToInt32(txtInvoice.Text));
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            _sqlCommand =
                new SqlCommand(
                    "update InvoiceDetails set Product=@Product, Amount=@Amount, UnitPrice=@UnitPrice, TotalPrice=@TotalPrice, Invoices=@Invoices where InvoiceDetailId=@InvoiceDetailId",
                    _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Product", Convert.ToInt32(cmbProducts.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Amount", Convert.ToInt16(txtAmount.Text));
            _sqlCommand.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(txtUnitPrice.Text));
            _sqlCommand.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(txtTotalPrice.Text));
            _sqlCommand.Parameters.AddWithValue("@Invoices", Convert.ToInt32(txtInvoice.Text));
            _sqlCommand.Parameters.AddWithValue("@InvoiceDetailId", Convert.ToInt32(txtInvoiceDetailId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadInvoiceDetails(Convert.ToInt32(txtInvoice.Text));
            DetailsClear();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            UpdateInvoice(Convert.ToInt32(txtInvoice.Text));
            
            LoadInvoiceDetails(Convert.ToInt32(txtInvoice.Text));
            DetailsClear();
        }

        void DetailsClear()
        {
            cmbProducts.SelectedIndex = 0;
            txtAmount.Text = "0.00";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateInvoice(int id)
        {
            decimal generalTotal = GetGeneralTotal();
            _sqlCommand =
                new SqlCommand(
                    "update Invoices set Serial=@Serial, Number=@Number, Date=@Date, Time=@Time, Customer=@Customer, Employee=@Employee, IsIndividual=@IsIndividual, GeneralTotalPrice=@GeneralTotalPrice where InvoiceId=@InvoiceId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Serial", txtSerial.Text);
            _sqlCommand.Parameters.AddWithValue("@Number", txtInvoiceNumber.Text);
            _sqlCommand.Parameters.AddWithValue("@Date", dtpDate.Value.ToString());
            _sqlCommand.Parameters.AddWithValue("@Time", dtpHours.Value.ToString());
            _sqlCommand.Parameters.AddWithValue("@Customer", Convert.ToInt32(cmbCustomers.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@Employee", Convert.ToInt32(cmbEmployees.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@IsIndividual", rdbIndividual.Checked ? 1 : 0);
            _sqlCommand.Parameters.AddWithValue("@GeneralTotalPrice", generalTotal);
            _sqlCommand.Parameters.AddWithValue("InvoiceId", id);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadInvoices();
            FormControlsClear();
        }

        decimal GetGeneralTotal()
        {
            decimal generalTotal = 0;
            _sqlCommand = new SqlCommand("select TotalPrice from InvoiceDetails where Invoices=@Invoices",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Invoices", Convert.ToInt32(txtInvoice.Text));
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                generalTotal += Convert.ToDecimal(reader["TotalPrice"].ToString());
            }
            reader.Close();
            _connection.Connection().Close();
            return generalTotal;
        }

    }
}
