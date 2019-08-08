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
    public partial class frmPackages : Form
    {
        List<Package> packageList;  // List of Packages
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {
            DisplayPackages();
        }

        private void DisplayPackages()
        {
            int rows;
            decimal basePrice, agencyCom;
            decimal subTotal = 0;
            try
            {
                packageList = PackageDB.GetPackages();
                packageDataGridView.DataSource = packageList;   // bind the grid view to the Package list
                rows = packageList.Count;
                for (int i = 0; i < rows; i++)
                {
                    basePrice = (decimal)packageDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn6"].Value;
                    agencyCom = (decimal)packageDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn7"].Value;
                    subTotal = basePrice + agencyCom;
                    packageDataGridView.Rows[i].Cells["PkgSubTotal"].Value = subTotal;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving packages: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                int row, packageID;
                row = packageDataGridView.CurrentRow.Index;
                packageID = (int)packageDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn1"].Value;

                frmViewSelPackage viewSelected = new frmViewSelPackage();   // set selected package on frmViewSelPackage
                viewSelected.selected = PackageDB.GetPackageById(packageID);
                DialogResult result = viewSelected.ShowDialog();

                DisplayPackages();
                //RefreshOrderDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving package with selected Id: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
    }
}
