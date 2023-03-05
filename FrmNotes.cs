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
    public partial class FrmNotes : Form
    {
        private SqlDatabaseConnection _connection;
        private SqlCommand _sqlCommand;
        public FrmNotes()
        {
            InitializeComponent();
            _connection = new SqlDatabaseConnection();
        }

        private void FrmNotes_Load(object sender, EventArgs e)
        {
            LoadNotes();
            LoadEmployees();
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

        private void LoadNotes()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter =
                new SqlDataAdapter(
                    "select n.NoteId, n.Date, n.Time, n.Header, n.Detail,n.Employee, e.FirstName + ' ' + e.LastName as EmployeeName from Notes as n inner join Employees as e on n.Employee=e.EmployeeId",
                    _connection.Connection());
            adapter.Fill(dataTable);
            dgvNotes.DataSource = dataTable;
        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotes.CurrentRow != null)
            {
                try
                {
                    txtId.Text = dgvNotes.CurrentRow.Cells[0].Value.ToString();
                    txtHeader.Text = dgvNotes.CurrentRow.Cells[3].Value.ToString();
                    rtxtContains.Text = dgvNotes.CurrentRow.Cells[4].Value.ToString();
                    cmbEmployees.SelectedValue = dgvNotes.CurrentRow.Cells[5].Value;
                    dtpDate.Value = Convert.ToDateTime(dgvNotes.CurrentRow.Cells[1].Value.ToString());
                    dtpHours.Value = Convert.ToDateTime(dgvNotes.CurrentRow.Cells[2].Value.ToString());
                }
                catch 
                {
                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("insert into Notes (Date, Time, Header, Detail, Employee) values (@Date, @Time, @Header, @Detail, @Employee)", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
            _sqlCommand.Parameters.AddWithValue("@Time", dtpHours.Value);
            _sqlCommand.Parameters.AddWithValue("@Header", txtHeader.Text);
            _sqlCommand.Parameters.AddWithValue("@Detail", rtxtContains.Text);
            _sqlCommand.Parameters.AddWithValue("@Employee", Convert.ToInt32(cmbEmployees.SelectedValue));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadEmployees();
            LoadNotes();
            FormControlsClear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("update Notes set Date=@Date, Time=@Time, Header=@Header, Detail=@Detail, Employee=@Employee where NoteId=@NoteId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@Date", dtpDate.Value);
            _sqlCommand.Parameters.AddWithValue("@Time", dtpHours.Value);
            _sqlCommand.Parameters.AddWithValue("@Header", txtHeader.Text);
            _sqlCommand.Parameters.AddWithValue("@Detail", rtxtContains.Text);
            _sqlCommand.Parameters.AddWithValue("@Employee", Convert.ToInt32(cmbEmployees.SelectedValue));
            _sqlCommand.Parameters.AddWithValue("@NoteId", Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadEmployees();
            LoadNotes();
            FormControlsClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _sqlCommand = new SqlCommand("delete from Notes where NoteId=@NoteId", _connection.Connection());
            _sqlCommand.Parameters.AddWithValue("@NoteId", Convert.ToInt32(txtId.Text));
            _sqlCommand.ExecuteNonQuery();
            _connection.Connection().Close();
            LoadEmployees();
            LoadNotes();
            FormControlsClear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FormControlsClear();
        }

        private void FormControlsClear()
        {
            txtId.Clear();
            txtHeader.Clear();
            dtpDate.Value = DateTime.Now;
            dtpHours.Value = DateTime.Now;
            rtxtContains.Clear();
            cmbEmployees.SelectedIndex = 0;
        }
    }
}
