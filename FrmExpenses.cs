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
using DevExpress.XtraSpreadsheet.Export;

namespace TicariOtomasyon
{
    public partial class FrmExpenses : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;

        public FrmExpenses()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            LoadExpenses();
        }

        private void LoadExpenses()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Expenses", _connection.Connection());
            adapter.Fill(dataTable);
            dgvExpenses.DataSource = dataTable;
        }

        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExpenses.CurrentRow != null)
            {
                try
                {
                    txtId.Text = dgvExpenses.CurrentRow.Cells[0].Value.ToString();
                    cmbMonth.Text = dgvExpenses.CurrentRow.Cells[1].Value.ToString();
                    cmbYear.Text = dgvExpenses.CurrentRow.Cells[2].Value.ToString();
                    txtElectric.Text = dgvExpenses.CurrentRow.Cells[3].Value.ToString();
                    txtWater.Text = dgvExpenses.CurrentRow.Cells[4].Value.ToString();
                    txtNaturalGas.Text = dgvExpenses.CurrentRow.Cells[5].Value.ToString();
                    txtInternet.Text = dgvExpenses.CurrentRow.Cells[6].Value.ToString();
                    txtSalaries.Text = dgvExpenses.CurrentRow.Cells[7].Value.ToString();
                    txtExtra.Text = dgvExpenses.CurrentRow.Cells[8].Value.ToString();
                    rtxtNotes.Text = dgvExpenses.CurrentRow.Cells[9].Value.ToString();
                }
                catch
                {
                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("insert into Expenses (Month, Year, ElectricityBill, WaterBill, NaturalGasBill, InternetBill, Salaries, Extra, Notes) values (@Month, @Year, @ElectricityBill, @WaterBill, @NaturalGasBill, @InternetBill, @Salaries, @Extra, @Notes)", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Month", cmbMonth.Text);
            _sqlCommand.Parameters.AddWithValue("@Year", cmbYear.Text);
            _sqlCommand.Parameters.AddWithValue("@ElectricityBill",Convert.ToDecimal(txtElectric.Text));
            _sqlCommand.Parameters.AddWithValue("@WaterBill", Convert.ToDecimal(txtWater.Text));
            _sqlCommand.Parameters.AddWithValue("@NaturalGasBill", Convert.ToDecimal(txtNaturalGas.Text));
            _sqlCommand.Parameters.AddWithValue("@InternetBill", Convert.ToDecimal(txtInternet.Text));
            _sqlCommand.Parameters.AddWithValue("@Salaries", Convert.ToDecimal(txtSalaries.Text));
            _sqlCommand.Parameters.AddWithValue("@Extra", Convert.ToDecimal(txtExtra.Text));
            _sqlCommand.Parameters.AddWithValue("@Notes",(rtxtNotes.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadExpenses();
            FormControlsClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("update Expenses set Month=@Month, Year=@Year, ElectricityBill=@ElectricityBill, WaterBill=@WaterBill, NaturalGasBill=@NaturalGasBill, InternetBill=@InternetBill, Salaries=@Salaries, Extra=@Extra, Notes=@Notes where ExpenseId=@ExpenseId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Month", cmbMonth.Text);
            _sqlCommand.Parameters.AddWithValue("@Year", cmbYear.Text);
            _sqlCommand.Parameters.AddWithValue("@ElectricityBill", Convert.ToDecimal(txtElectric.Text));
            _sqlCommand.Parameters.AddWithValue("@WaterBill", Convert.ToDecimal(txtWater.Text));
            _sqlCommand.Parameters.AddWithValue("@NaturalGasBill", Convert.ToDecimal(txtNaturalGas.Text));
            _sqlCommand.Parameters.AddWithValue("@InternetBill", Convert.ToDecimal(txtInternet.Text));
            _sqlCommand.Parameters.AddWithValue("@Salaries", Convert.ToDecimal(txtSalaries.Text));
            _sqlCommand.Parameters.AddWithValue("@Extra", Convert.ToDecimal(txtExtra.Text));
            _sqlCommand.Parameters.AddWithValue("@Notes", (rtxtNotes.Text));
            _sqlCommand.Parameters.AddWithValue("@ExpenseId", Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadExpenses();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }

        void FormControlsClear()
        {
            txtId.Clear();
            txtElectric.Clear();
            txtWater.Clear();
            txtNaturalGas.Clear();
            txtInternet.Clear();
            txtSalaries.Clear();
            txtExtra.Clear();
            rtxtNotes.Clear();
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }
    }
}
