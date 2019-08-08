using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;

namespace ProjectTeam3
{
    public partial class frmViewSelPackage : Form
    {
        List<Supplier> suppliers;
        public Package selected;    // selected Package set by frmPackages
        int pkgId;
        //pkgId = (int)selected.PackageId;


        public frmViewSelPackage()
        {
            InitializeComponent();
        }

        private void frmViewSelPackage_Load(object sender, EventArgs e)
        {
            int row, productID;
            DisplaySelectedPkg();

            pkgId = selected.PackageId;
            productDataGridView.DataSource = ProductDB.GetProductsbyPackageId(pkgId);            

            row = productDataGridView.CurrentRow.Index;
            productID = (int)productDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn1"].Value;
            supplierDataGridView.DataSource = SupplierDB.GetSupplierbyPkgProdId(pkgId, productID);

            btnSave.Visible = false;
            pkgNameTextBox.Enabled = false;
            pkgStartDateDateTimePicker.Enabled = false;
            pkgEndDateDateTimePicker.Enabled = false;
            pkgDescTextBox.Enabled = false;
            pkgBasePriceTextBox.Enabled = false;
            pkgAgencyCommissionTextBox.Enabled = false;
        }

        private void DisplaySelectedPkg()
        {
            packageIdTextBox.Text = selected.PackageId.ToString();
            pkgNameTextBox.Text = selected.PkgName;
            pkgDescTextBox.Text = selected.PkgDesc;
            pkgBasePriceTextBox.Text = selected.PkgBasePrice.ToString("c");

            if (selected.PkgStartDate == null)
            {
                pkgStartDateDateTimePicker.Text = "";
            }
            else
            {
                DateTime pkgSD = (DateTime)selected.PkgStartDate;
                pkgStartDateDateTimePicker.Text = pkgSD.Date.ToShortDateString();
            }

            if (selected.PkgEndDate == null)
            {
                pkgEndDateDateTimePicker.Text = "";
            }
            else
            {
                DateTime pkgED = (DateTime)selected.PkgEndDate;
                pkgEndDateDateTimePicker.Text = pkgED.Date.ToShortDateString();
            }

            if (selected.PkgAgencyCommission == null)
            {
                pkgAgencyCommissionTextBox.Text = "";
            }
            else
            {                
                pkgAgencyCommissionTextBox.Text = string.Format("{0:c2}", selected.PkgAgencyCommission);
            }
            pkgAgencyCommissionTextBox.Select(0, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(InputIsNotNull() && 
                CommissionIsValid() &&
               EndDateIsValid())
            {
                // build Package object with the new data
                Package updated = new Package();
                updated.PackageId = selected.PackageId;
                updated.PkgName = pkgNameTextBox.Text;
                updated.PkgStartDate = DateTime.Parse(pkgStartDateDateTimePicker.Text);
                updated.PkgEndDate = DateTime.Parse(pkgEndDateDateTimePicker.Text);
                updated.PkgDesc = pkgDescTextBox.Text;
                updated.PkgBasePrice = decimal.Parse(pkgBasePriceTextBox.Text, NumberStyles.Currency);
                updated.PkgAgencyCommission = decimal.Parse(pkgAgencyCommissionTextBox.Text, NumberStyles.Currency);

                try     // try to update
                {
                    if (!PackageDB.UpdatePackage(selected, updated))    // DB concurrency error
                    {
                        MessageBox.Show("Another user has updated or " +
                                "deleted current member", "Concurrency Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        selected = updated;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating: " + ex.Message, ex.GetType().ToString());
                }

            }

            
        }



        private bool EndDateIsValid()
        {
            bool valid = false;
            DateTime startDate = Convert.ToDateTime(pkgStartDateDateTimePicker.Text);
            DateTime endDate = Convert.ToDateTime(pkgEndDateDateTimePicker.Text);

            if (startDate > endDate)
            {
                MessageBox.Show("Package End Date must be later that Package Start Date.");
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        private bool CommissionIsValid()
        {
            bool valid = false;
            decimal commission = decimal.Parse(pkgAgencyCommissionTextBox.Text, NumberStyles.Currency);
            decimal basePrice = decimal.Parse(pkgBasePriceTextBox.Text, NumberStyles.Currency);

            if (commission > basePrice)
            {
                MessageBox.Show("Agency Commission cannot be greater than the Base Price.");
            }
            else
            {
                valid = true;
            }
            return valid;
        }

        private bool InputIsNotNull()
        {
            bool valid = false;

            if ( !( pkgNameTextBox.Text == "" || 
                    pkgDescTextBox.Text == "" ||
                    pkgBasePriceTextBox.Text == "" ||
                    pkgAgencyCommissionTextBox.Text == ""))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("All input fields cannot be null.");
            }          
            return valid;
        }

        private void chkEnableEdit_CheckedChanged(object sender, EventArgs e)
        {
            bool enablePackageEdit = chkEnableEdit.Checked;

            if (enablePackageEdit)
            {
                btnSave.Visible = true;
                pkgNameTextBox.Enabled = true;
                pkgStartDateDateTimePicker.Enabled = true;
                pkgEndDateDateTimePicker.Enabled = true;
                pkgDescTextBox.Enabled = true;
                pkgBasePriceTextBox.Enabled = true;
                pkgAgencyCommissionTextBox.Enabled = true;
            }
            else
            {
                DisplaySelectedPkg();
                btnSave.Visible = false;
                pkgNameTextBox.Enabled = false;
                pkgStartDateDateTimePicker.Enabled = false;
                pkgEndDateDateTimePicker.Enabled = false;
                pkgDescTextBox.Enabled = false;
                pkgBasePriceTextBox.Enabled = false;
                pkgAgencyCommissionTextBox.Enabled = false;
            }

        }

        private void productDataGridView_Click(object sender, EventArgs e)
        {
            int row, productID;
            pkgId = selected.PackageId;

            row = productDataGridView.CurrentRow.Index;
            productID = (int)productDataGridView.Rows[row].Cells["dataGridViewTextBoxColumn1"].Value;

            supplierDataGridView.DataSource = SupplierDB.GetSupplierbyPkgProdId(pkgId, productID);
        }

        private void btnAddRemoveProduct_Click(object sender, EventArgs e)
        {
            pkgId = selected.PackageId;
            frmAddProductToPackage viewProductsForPackage = new frmAddProductToPackage();
            viewProductsForPackage.selected = PackageDB.GetPackageById(pkgId);
            DialogResult result = viewProductsForPackage.ShowDialog();       
        }
    }
}
