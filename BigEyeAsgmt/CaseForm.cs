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

        public CaseForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls();
        }

        private void bindControls()
        {
            dtCase = DM.dtCase; //get case datatable from DataModule
            dtCase.Columns.Add("ClientName");//add a new column to the case datatable
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

        private void btnAddCase_Click(object sender, EventArgs e)
        {
            disableCaseFormElements();
            resetCaseVal();

            lblPnlCaseID.Visible = false;
            lblPnlCaseNO.Visible = false;

            cmbPnlCaseType.DataSource = dtCaseType;
            cmbPnlCaseType.ValueMember = "caseType";
            cmbPnlCaseType.DisplayMember = "caseType";

            cmbPnlClient.DataSource = DM.BigEyeDS;
            cmbPnlClient.ValueMember = "T_Client.ClientID";
            cmbPnlClient.DisplayMember = "T_Client.LastName";

            pnlCase.Show();
        }

        private void btnDeleteCase_Click(object sender, EventArgs e)
        {
            if(txtStatus.Text.Equals("Open"))
            {
                MessageBox.Show("You may only delete closed Cases", "Error");
            }
            if (MessageBox.Show("Are you sure you want delete this record?", "Warning", 
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow deleteCase = DM.dtCase.Rows[currencyManager.Position];

                deleteCase.Delete();
                DM.updateCase();
            }
        }

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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveCase_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableCaseFormElements();
            pnlCase.Hide();
        }

        private void cmbPnlClient_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow dr = ((DataRowView)e.ListItem).Row;

            string lastname = dr["LastName"].ToString();
            string firstname = dr["FirstName"].ToString();

            e.Value = lastname + " " + firstname;
        }

        private void btnMarkClosed_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("Closed"))
            {
                MessageBox.Show("The Case is already closed", "Error");
            }
            else
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
        }

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
        }

        private void resetCaseVal()
        {
            lblPnlCaseID.Text = null;
            txtPnlDescription.Text = "";
        }
    }
}
