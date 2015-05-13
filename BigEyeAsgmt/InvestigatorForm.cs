using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigEyeAsgmt
{
    public partial class InvestigatorForm : Form
    {
        private MainForm frmMenu;
        private DataModule DM;
        private CurrencyManager currencyManager;

        public InvestigatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloading the constructor
        /// </summary>
        /// <param name="dm"> DataModule </param>
        /// <param name="menu"> MainForm </param>
        public InvestigatorForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls();
        }

        /// <summary>
        /// Bind the values to elements of the Investigator Form
        /// </summary>
        private void bindControls()
        {
            lblInvestigatorID.DataBindings.Add("Text", DM.BigEyeDS, "T_Investigator.InvestigatorID");
            txtLastName.DataBindings.Add("Text", DM.BigEyeDS, "T_Investigator.LastName");
            txtFirstName.DataBindings.Add("Text", DM.BigEyeDS, "T_Investigator.FirstName");
            txtHourlyRate.DataBindings.Add("Text", DM.BigEyeDS, "T_Investigator.HourlyRate");
            txtCellPhone.DataBindings.Add("Text", DM.BigEyeDS, "T_Investigator.CellPhone");
            txtLicensed.DataBindings.Add("Text", DM.BigEyeDS, "T_Investigator.Licensed");

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtHourlyRate.Enabled = false;
            txtCellPhone.Enabled = false;
            txtLicensed.Enabled = false;

            lstInvestigators.DataSource = DM.BigEyeDS;
            lstInvestigators.DisplayMember = "T_Investigator.LastName";
            lstInvestigators.ValueMember = "T_Investigator.LastName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_Investigator"];
        }

        /// <summary>
        /// Close the Investigator Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Select the previous Investigator value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// Select the previous Investigator value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < (currencyManager.Count - 1))
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// Show the panel pnlInvestigator when click Add Investigator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddInvestigator_Click(object sender, EventArgs e)
        {
            disableInvestigatorFormElements();
            resetInvestigatorVal();
            lblPnlInvestigatorID.Visible = false;
            lblPnlInvestigatorNO.Visible = false;
            ckLicensedTrue.Visible = false;
            ckLicensedFalse.Visible = false;
            txtPnlLicensed.Visible = true;

            btnSaveInvestigator.Text = "Save Investigator";

            pnlInvestigator.Show();
        }

        /// <summary>
        /// Show the panel pnlInvestigator when click Modify Investigator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyInvestigator_Click(object sender, EventArgs e)
        {
            disableInvestigatorFormElements();
            resetInvestigatorVal();
            lblPnlInvestigatorID.Visible = true;
            lblPnlInvestigatorNO.Visible = true;
            txtPnlLicensed.Visible = false;
            ckLicensedFalse.Visible = true;
            ckLicensedTrue.Visible = true;
            btnSaveInvestigator.Text = "Update Investigator";

            DataRow modifyInvestigator = DM.dtInvestigator.Rows[currencyManager.Position];
            lblPnlInvestigatorID.Text = modifyInvestigator["InvestigatorID"].ToString();
            txtPnlLastName.Text = modifyInvestigator["LastName"].ToString();
            txtPnlFirstName.Text = modifyInvestigator["FirstName"].ToString();
            txtPnlHourlyRate.Text = modifyInvestigator["HourlyRate"].ToString();
            txtPnlCellPhone.Text = modifyInvestigator["CellPhone"].ToString();
            string licensed = modifyInvestigator["Licensed"].ToString();
            if (licensed.Equals("True"))
            {
                ckLicensedTrue.Checked = true;
            }
            else
            {
                ckLicensedFalse.Checked = true;
            }

            pnlInvestigator.Show();
        }

        /// <summary>
        /// Save Investigator data when Add/Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveInvestigator_Click(object sender, EventArgs e)
        {
            if (txtPnlLastName.Text == "" || txtPnlFirstName.Text == "" || txtPnlHourlyRate.Text == ""
                || txtPnlCellPhone.Text == "")
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else if (txtPnlLicensed.Text == "" || (txtPnlLicensed.Text.ToLower().Equals("true") || txtPnlLicensed.Text.ToLower().Equals("false")))
            {
                MessageBox.Show("Please enter a valid licensed status", "Error");
                txtPnlLicensed.Focus();
            }
            else
            {
                DataRow investigatorRow;
                if (lblPnlInvestigatorID.Text == null || lblPnlInvestigatorID.Text.Equals(""))
                {
                    investigatorRow = DM.dtInvestigator.NewRow();
                    investigatorRow["LastName"] = txtPnlLastName.Text;
                    investigatorRow["FirstName"] = txtPnlFirstName.Text;
                    investigatorRow["HourlyRate"] = txtPnlHourlyRate.Text;
                    investigatorRow["CellPhone"] = txtPnlCellPhone.Text;
                    investigatorRow["Licensed"] = txtPnlLicensed.Text == "" ? "False" : "True";

                    DM.dtInvestigator.Rows.Add(investigatorRow);
                    DM.updateInvestigator();

                    enableInvestigatorFormElements();
                    pnlInvestigator.Hide();

                    MessageBox.Show("Investigator added successfully", "Success");
                }
                else
                {
                    investigatorRow = DM.dtInvestigator.Rows[currencyManager.Position];
                    investigatorRow["LastName"] = txtPnlLastName.Text;
                    investigatorRow["FirstName"] = txtPnlFirstName.Text;
                    investigatorRow["HourlyRate"] = txtPnlHourlyRate.Text;
                    investigatorRow["CellPhone"] = txtPnlCellPhone.Text;
                    string licensed = ckLicensedTrue.Checked ? "True" : "False";
                    investigatorRow["Licensed"] = licensed;

                    currencyManager.EndCurrentEdit();
                    DM.updateInvestigator();

                    enableInvestigatorFormElements();
                    pnlInvestigator.Hide();

                    MessageBox.Show("Investigator updated successfully", "Success");
                }
            }
        }

        /// <summary>
        /// Remove selected Investigator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteInvestigator_Click(object sender, EventArgs e)
        {
            DataRow deleteInvestigatorRow = DM.dtInvestigator.Rows[currencyManager.Position];
            DataRow[] asgmtRow = DM.dtAssignment.Select("InvestigatorID = " + lblInvestigatorID.Text);
            DataRow[] equipmentRow = DM.dtEquipment.Select("InvestigatorID = " + lblInvestigatorID.Text);
            if (asgmtRow.Length != 0)
            {
                MessageBox.Show("You may only delete Investigators who are not assigned to assignments", "Error");
            }
            else if (equipmentRow.Length != 0)
            {
                MessageBox.Show("You may only delete Investigators who are not allocated equipment", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this records?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteInvestigatorRow.Delete();
                    DM.updateInvestigator();
                }

            }
        }

        /// <summary>
        /// Cancel Add a new investigator or cancel Modify selected investigator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableInvestigatorFormElements();

            pnlInvestigator.Hide();
        }

        /// <summary>
        /// Enable all of disabled elements in Investigator Form. 
        /// </summary>
        private void enableInvestigatorFormElements()
        {
            lstInvestigators.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddInvestigator.Enabled = true;
            btnModifyInvestigator.Enabled = true;
            btnDeleteInvestigator.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// Disable part of elements of Investigator Form.
        /// </summary>
        private void disableInvestigatorFormElements()
        {
            lstInvestigators.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddInvestigator.Enabled = false;
            btnModifyInvestigator.Enabled = false;
            btnDeleteInvestigator.Enabled = false;
            btnReturn.Enabled = false;
        }

        /// <summary>
        /// Reset Investigator value when Add/Modify.
        /// </summary>
        private void resetInvestigatorVal()
        {
            lblPnlInvestigatorID.Text = null;
            txtPnlLastName.Text = "";
            txtPnlFirstName.Text = "";
            txtPnlHourlyRate.Text = "";
            txtPnlCellPhone.Text = "";
            txtPnlLicensed.Text = "";
        }

        private void ckLicensedTrue_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckLicensedTrue.Checked)
            {
                ckLicensedFalse.Checked = false;
            }
        }

        private void ckLicensedFalse_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckLicensedFalse.Checked)
            {
                ckLicensedTrue.Checked = false;
            }
        }
    }
}
