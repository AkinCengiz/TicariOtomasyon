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
    public partial class FrmProducts : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmProducts()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }


        
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Products", _connection.Connection());
            adapter.Fill(dataTable);
            dgvProducts.DataSource = dataTable;
            _connection.Connection().Close();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dgvProducts.CurrentRow;
            txtId.Text = dataRow.Cells[0].Value.ToString();
            txtProductName.Text = dataRow.Cells[1].Value.ToString();
            txtBrand.Text = dataRow.Cells[2].Value.ToString();
            txtModel.Text = dataRow.Cells[3].Value.ToString();
            mtxtYear.Text = dataRow.Cells[4].Value.ToString();
            nudAmount.Text = dataRow.Cells[5].Value.ToString();
            txtPurchasePrice.Text = dataRow.Cells[6].Value.ToString();
            txtSalePrice.Text = dataRow.Cells[7].Value.ToString();
            rtxtExplanation.Text = dataRow.Cells[8].Value.ToString();
        }

        void FormControlsClear()
        {
            txtId.Clear();
            txtProductName.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            mtxtYear.Clear();
            nudAmount.Value = 0;
            txtPurchasePrice.Clear();
            txtSalePrice.Clear();
            rtxtExplanation.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "insert into Products (ProductName,Brand,Model,Year,Amount,PurchasePrice,SalePrice,Explanation) values (@ProductName,@Brand,@Model,@Year,@Amount,@PurchasePrice,@SalePrice,@Explanation)",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            _sqlCommand.Parameters.AddWithValue("@Brand", txtBrand.Text);
            _sqlCommand.Parameters.AddWithValue("@Model", txtModel.Text);
            _sqlCommand.Parameters.AddWithValue("@Year",mtxtYear.Text);
            _sqlCommand.Parameters.AddWithValue("@Amount", Convert.ToInt16(nudAmount.Value));
            _sqlCommand.Parameters.AddWithValue("@PurchasePrice", Convert.ToDecimal(txtPurchasePrice.Text));
            _sqlCommand.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(txtSalePrice.Text));
            _sqlCommand.Parameters.AddWithValue("@Explanation", rtxtExplanation.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadProducts();
            FormControlsClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand(
                "update Products set ProductName=@ProductName, Brand=@Brand, Model=@Model, Year=@Year, Amount=@Amount, PurchasePrice=@PurchasePrice, SalePrice=@SalePrice, Explanation=@Explanation where ProductId=@ProductId",
                _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            _sqlCommand.Parameters.AddWithValue("@Brand", txtBrand.Text);
            _sqlCommand.Parameters.AddWithValue("@Model", txtModel.Text);
            _sqlCommand.Parameters.AddWithValue("@Year", mtxtYear.Text);
            _sqlCommand.Parameters.AddWithValue("@Amount", Convert.ToInt16(nudAmount.Value));
            _sqlCommand.Parameters.AddWithValue("@PurchasePrice", Convert.ToDecimal(txtPurchasePrice.Text));
            _sqlCommand.Parameters.AddWithValue("@SalePrice", Convert.ToDecimal(txtSalePrice.Text));
            _sqlCommand.Parameters.AddWithValue("@Explanation", rtxtExplanation.Text);
            _sqlCommand.Parameters.AddWithValue("@ProductId", txtId.Text);
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadProducts();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("delete from Products where ProductId = @ProductID", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@ProductId",Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadProducts();
            FormControlsClear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }
    }
}
