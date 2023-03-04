using System.Data.SqlClient;
using DevExpress.DataAccess.Native.Data;

namespace TicariOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FrmProducts frmProducts;

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmProducts == null)
            {
                frmProducts = new FrmProducts();
                frmProducts.MdiParent = this;
            }
            frmProducts.Show();
        }

        private SqlDatabaseConnection _connection = new SqlDatabaseConnection();
        private SqlCommand _sqlCommand;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private FrmCustomers frmCustomers;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCustomers == null)
            {
                frmCustomers = new FrmCustomers();
                frmCustomers.MdiParent = this;
            }
            frmCustomers.Show();
        }

        private FrmEmployees frmEmployees;
        private void btnEmployeesForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmEmployees == null)
            {
                frmEmployees = new FrmEmployees();
                frmEmployees.MdiParent = this;
            }
            frmEmployees.Show();
        }

        private FrmCompanies frmCompanies;
        private void btnCompaniesForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmCompanies == null)
            {
                frmCompanies = new FrmCompanies();
                frmCompanies.MdiParent = this;
            }
            frmCompanies.Show();
        }

        private FrmContact frmContact;
        private void btnContact_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmContact == null)
            {
                frmContact = new FrmContact();
                frmContact.MdiParent = this;
            }
            frmContact.Show();
        }

        private FrmExpenses frmExpenses;
        private void btnExpensesForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmExpenses == null)
            {
                frmExpenses = new FrmExpenses();
                frmExpenses.MdiParent = this;
            }
            frmExpenses.Show();
        }

        private FrmBanks frmBanks;
        private void btnBanks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmBanks == null)
            {
                frmBanks = new FrmBanks();
                frmBanks.MdiParent = this;
            }
            frmBanks.Show();
        }

        private FrmInvoice frmInvoice;
        private void btnInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmInvoice == null)
            {
                frmInvoice = new FrmInvoice();
                frmInvoice.MdiParent = this;
            }

            frmInvoice.Show();
        }
    }
}