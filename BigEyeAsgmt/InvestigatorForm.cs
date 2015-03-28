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

        public InvestigatorForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls();
        }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < (currencyManager.Count - 1))
            {
                ++currencyManager.Position;
            }
        }

        private void btnAddInvestigator_Click(object sender, EventArgs e)
        {
            disableInvestigatorFormElements();
            resetInvestigatorVal();
            lblPnlInvestigatorID.Visible = false;
            lblPnlInvestigatorNO.Visible = false;
            ckLicensedTrue.Visible = false;
            ckLicensedFalse.Visible = false;

            btnSaveInvestigator.Text = "Save Investigator";

            pnlInvestigator.Show();
        }

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

        private void btnSaveInvestigator_Click(object sender, EventArgs e)
        {
            if (txtPnlLastName.Text == "" || txtPnlFirstName.Text == "" || txtPnlHourlyRate.Text == ""
                || txtPnlCellPhone.Text == "")
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
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
                    investigatorRow["Licensed"] = txtPnlLicensed.Text == ""?"False":"True";

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

        private void btnDeleteInvestigator_Click(object sender, EventArgs e)
        {
            DataRow deleteInvestigatorRow = DM.dtInvestigator.Rows[currencyManager.Position];
            DataRow[] asgmtRow = DM.dtAssignment.Select("InvestigatorID = " + lblInvestigatorID.Text);
            DataRow[] equipmentRow = DM.dtEquipment.Select("InvestigatorID = " + lblInvestigatorID.Text);
            if (asgmtRow.Length != 0)
            {
                MessageBox.Show("You may only delete Investigators who are not assigned to cases", "Error");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableInvestigatorFormElements();

            pnlInvestigator.Hide();
        }

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
