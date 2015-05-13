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
    public partial class CaseForm : Form
    {
        private MainForm frmMenu;
        private DataModule DM;
        private CurrencyManager currencyManager;
        private DataTable dtCaseType;
        private DataTable dtCase;

        public CaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloading the constructor
        /// </summary>
        /// <param name="dm"> DataModule </param>
        /// <param name="menu"> MainForm </param>
        public CaseForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls();
        }

        /// <summary>
        /// Bind the values to elements of the Case Form
        /// </summary>
        private void bindControls()
        {
            dtCase = DM.dtCase; //get case datatable from DataModule
            if (!dtCase.Columns.Contains("ClientName"))
            {
                dtCase.Columns.Add("ClientName");//add a new column to the case datatable
            }
            int RowsCount = dtCase.Rows.Count;
            for (int i = 0; i < RowsCount; i++)//add values for the new added column of Client Name
            {
                DataRow[] clientRow = DM.dtClient.Select("ClientID = " + dtCase.Rows[i]["ClientID"].ToString());
                if (clientRow.Length > 0)
                {
                    string fullName = clientRow[0]["LastName"].ToString() + " " + clientRow[0]["FirstName"].ToString();
                    dtCase.Rows[i]["ClientName"] = fullName;
                }
            }

            lblCaseID.DataBindings.Add("Text", dtCase, "CaseID");
            txtDescription.DataBindings.Add("Text", dtCase, "Description");
            txtStatus.DataBindings.Add("Text", dtCase, "Status");
            txtCaseType.DataBindings.Add("Text", dtCase, "CaseType");
            txtDateOpened.DataBindings.Add("Text", dtCase, "DateOpened");
            txtClient.DataBindings.Add("Text", dtCase, "ClientName");
            lblClientID.DataBindings.Add("Text", dtCase, "ClientID");

            txtDescription.Enabled = false;
            txtStatus.Enabled = false;
            txtCaseType.Enabled = false;
            txtDateOpened.Enabled = false;
            txtClient.Enabled = false;

            lstCases.DataSource = dtCase;
            lstCases.ValueMember = "CaseID";
            lstCases.DisplayMember = "CaseID";

            currencyManager = (CurrencyManager)this.BindingContext[dtCase];

            dtCaseType = new DataTable();//initialize the case type datatable
            dtCaseType.Columns.Add("caseType");
            dtCaseType.Rows.Add("Surveillance");
            dtCaseType.Rows.Add("Insurance Check");
            dtCaseType.Rows.Add("Credit Check");
        }

        /// <summary>
        /// Select the previous Case value.
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
        /// Select the Next Case value.
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
        /// Show the panel pnlCase when click Add case
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCase_Click(object sender, EventArgs e)
        {
            disableCaseFormElements();
            resetCaseVal();

            lblPnlCaseID.Visible = false;
            lblPnlCaseNO.Visible = false;
            btnSaveCase.Text = "Add Case";
            cmbPnlCaseType.DataSource = dtCaseType;
            cmbPnlCaseType.ValueMember = "caseType";
            cmbPnlCaseType.DisplayMember = "caseType";

            cmbPnlClient.DataSource = DM.BigEyeDS;
            cmbPnlClient.ValueMember = "T_Client.ClientID";
            cmbPnlClient.DisplayMember = "T_Client.LastName";

            pnlCase.Show();
        }

        /// <summary>
        /// Remove selected case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCase_Click(object sender, EventArgs e)
        {
            if(txtStatus.Text.Equals("Open"))
            {
                MessageBox.Show("You may only delete closed Cases", "Error");
            }
            else if (MessageBox.Show("Are you sure you want delete this record?", "Warning", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow deleteCase = DM.dtCase.Rows[currencyManager.Position];

                deleteCase.Delete();
                DM.updateCase();
            }
        }

        /// <summary>
        /// Show the panel pnlCase when click Modify with selected case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyCase_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("Closed"))
            {
                MessageBox.Show("Cannot update a closed case", "Warning");

                return;
            }

            disableCaseFormElements();
            resetCaseVal();

            lblPnlCaseID.Visible = true;
            lblPnlCaseNO.Visible = true;

            DataRow caseRow = DM.dtCase.Rows[currencyManager.Position];
            lblPnlCaseID.Text = caseRow["CaseID"].ToString();
            txtPnlDescription.Text = caseRow["Description"].ToString();
            dtpDateOpened.Text = caseRow["DateOpened"].ToString();
            btnSaveCase.Text = "Update Case";

            cmbPnlCaseType.DataSource = dtCaseType;
            cmbPnlCaseType.ValueMember = "caseType";
            cmbPnlCaseType.DisplayMember = "caseType";
            if (caseRow["CaseType"] != DBNull.Value)
            {
                cmbPnlCaseType.SelectedValue = caseRow["CaseType"].ToString();
            }

            cmbPnlClient.DataSource = DM.BigEyeDS;
            cmbPnlClient.ValueMember = "T_Client.ClientID";
            cmbPnlClient.DisplayMember = "T_Client.LastName T_Client.FirstName";
            if (caseRow["ClientID"] != DBNull.Value)
            {
                cmbPnlClient.SelectedValue = caseRow["ClientID"].ToString();
            }
            pnlCase.Show();
        }

        /// <summary>
        /// Close the Case Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Save cases data when click Add/Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveCase_Click(object sender, EventArgs e)
        {
            if (txtPnlDescription.Text == "")
            {
                MessageBox.Show("You must enter a value for each of the fields", "Error");
            }
            else
            {
                DataRow caseRow;
                if (lblPnlCaseID.Text == null || lblPnlCaseID.Text.Equals(""))
                {
                    caseRow = dtCase.NewRow();
                    caseRow["Description"] = txtPnlDescription.Text;
                    caseRow["DateOpened"] = dtpDateOpened.Text;
                    caseRow["CaseType"] = cmbPnlCaseType.SelectedValue.ToString();
                    caseRow["ClientID"] = Convert.ToInt64(cmbPnlClient.SelectedValue.ToString());
                    caseRow["ClientName"] = cmbPnlClient.Text;
                    caseRow["Status"] = "Open";

                    DM.dtCase.Rows.Add(caseRow);
                    DM.updateCase();

                    enableCaseFormElements();
                    pnlCase.Hide();

                    MessageBox.Show("Case added successfully", "Success");
                }
                else
                {
                    caseRow = dtCase.Rows[currencyManager.Position];
                    caseRow["Description"] = txtPnlDescription.Text;
                    caseRow["DateOpened"] = dtpDateOpened.Text;
                    caseRow["CaseType"] = cmbPnlCaseType.SelectedValue.ToString();
                    caseRow["ClientID"] = Convert.ToInt64(cmbPnlClient.SelectedValue.ToString());
                    caseRow["ClientName"] = cmbPnlClient.Text;

                    DM.dtCase = dtCase;// Edit the database record
                    currencyManager.EndCurrentEdit();
                    DM.updateCase();

                    enableCaseFormElements();
                    pnlCase.Hide();

                    MessageBox.Show("Case updated successfully", "Success");
                }
            }
        }

        /// <summary>
        /// Cancel Add a new case or cancel Modify selected case.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableCaseFormElements();
            pnlCase.Hide();
        }

        /// <summary>
        /// Combine last name and first name to Client which is in Panel pnlCase.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPnlClient_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow dr = ((DataRowView)e.ListItem).Row;

            string lastname = dr["LastName"].ToString();
            string firstname = dr["FirstName"].ToString();

            e.Value = lastname + " " + firstname;
        }

        /// <summary>
        /// Mark selected cases' Open status to Closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarkClosed_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("Closed"))
            {
                MessageBox.Show("The Case is already closed", "Error");
            }
            else if(MessageBox.Show("Are you sure you want Close this Case?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow caseRow = dtCase.Rows[currencyManager.Position];

                caseRow["Status"] = "Closed";

                DM.dtCase = dtCase;
                currencyManager.EndCurrentEdit();
                DM.updateCase();

                DataRow[] asgmts = DM.dtAssignment.Select("CaseID = " + Convert.ToInt32(caseRow["CaseID"]));
                foreach(DataRow deleteAsgmt in asgmts)
                {
                    deleteAsgmt.Delete();
                    DM.updateAssignment();
                }

                MessageBox.Show("The Case marked successfully", "Success");
            }
        }

        /// <summary>
        /// Enable all of the disabled elements in Case Form
        /// </summary>
        private void enableCaseFormElements()
        {
            lstCases.Visible = true;
            txtDescription.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddCase.Enabled = true;
            btnModifyCase.Enabled = true;
            btnDeleteCase.Enabled = true;
            btnReturn.Enabled = true;
            btnMarkClosed.Enabled = true;
        }

        /// <summary>
        /// Disable part of elements of Case Form.
        /// </summary>
        private void disableCaseFormElements()
        {
            lstCases.Visible = false;
            txtDescription.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddCase.Enabled = false;
            btnModifyCase.Enabled = false;
            btnDeleteCase.Enabled = false;
            btnReturn.Enabled = false;
            btnMarkClosed.Enabled = false;
        }

        /// <summary>
        /// Reset part of Case value in panel pnlCase.
        /// </summary>
        private void resetCaseVal()
        {
            lblPnlCaseID.Text = null;
            txtPnlDescription.Text = "";
        }
    }
}
