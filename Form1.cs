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
                frmProducts.Show();
            }
        }

        private SqlDatabaseConnection _connection = new SqlDatabaseConnection();
        private SqlCommand _sqlCommand;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            
            

        }

       
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.MdiParent = this;
            frmCustomers.Show();
        }

        private void btnEmployeesForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmEmployees frmEmployees = new FrmEmployees();
            frmEmployees.MdiParent = this;
            frmEmployees.Show();
        }

        private void btnCompaniesForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmCompanies frmCompanies = new FrmCompanies();
            frmCompanies.MdiParent = this;
            frmCompanies.Show();
        }
    }
}