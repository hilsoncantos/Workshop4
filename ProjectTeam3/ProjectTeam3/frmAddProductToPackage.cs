using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace ProjectTeam3
{
    public partial class frmAddProductToPackage : Form
    {
        public Package selected;    // selected Package set by frmViewSelPackage
        int pkgId;

        public frmAddProductToPackage()
        {
            InitializeComponent();
        }

        private void frmAddProductToPackage_Load(object sender, EventArgs e)
        {
            packageIdTextBox.Text = selected.PackageId.ToString();
            pkgNameTextBox.Text = selected.PkgName.ToString();

            pkgId = selected.PackageId;
            gvCurrentProducts.DataSource = ProductDB.GetProductsbyPackageId(pkgId);
            gvAvailableProducts.DataSource = ProductDB.GetProductsNotInPackageId(pkgId);
        }
    }
}
