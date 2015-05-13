using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BigEyeAsgmt
{
    public partial class CaseAssignmentForm : Form
    {
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private DataModule DM;
        private DataTable dtCaseAssignment;
        private DataTable dtCase;

        public CaseAssignmentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloading the constructor
        /// </summary>
        /// <param name="dm"> DataModule </param>
        /// <param name="menu"> MainForm </param>
        public CaseAssignmentForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls222();
        }

        /// <summary>
        /// Bind the values to elements of the Case Assignment Form
        /// </summary>
        private void bindControls()
        {
            dtCase = DM.dtCase; //get case datatable from DataModule
            if (!dtCase.Columns.Contains("ClientName"))
            {
                dtCase.Columns.Add("ClientName");//add a new column to the case datatable
            }
            if (!dtCase.Columns.Contains("InvestigatorNames"))
            {
                dtCase.Columns.Add("InvestigatorNames");
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

                DataRow[] assignmentRows = DM.dtAssignment.Select("CaseID = " + dtCase.Rows[i]["CaseID"].ToString());
                if (assignmentRows.Length > 0)
                {
                    string investigatorNames = "";
                    for (int j = 0; j < assignmentRows.Length; j++)
                    {
                        DataRow[] investigatorRows = DM.dtInvestigator.Select("InvestigatorID = " + assignmentRows[j]["InvestigatorID"].ToString());
                        if (investigatorRows.Length > 0)
                        {
                            if (!investigatorNames.Equals(""))
                            {
                                investigatorNames += ", ";
                            }
                            investigatorNames += investigatorRows[0]["LastName"].ToString() + " " + investigatorRows[0]["FirstName"].ToString();
                        }
                    }
                    dtCase.Rows[i]["InvestigatorNames"] = investigatorNames;
                }
            }

            lblCaseID.DataBindings.Add("Text", dtCase, "CaseID");
            txtDescription.DataBindings.Add("Text", dtCase, "Description");
            txtStatus.DataBindings.Add("Text", dtCase, "Status");
            txtCaseType.DataBindings.Add("Text", dtCase, "CaseType");
            txtDateOpened.DataBindings.Add("Text", dtCase, "DateOpened");
            txtClientName.DataBindings.Add("Text", dtCase, "ClientName");
            lblClientID.DataBindings.Add("Text", dtCase, "ClientID");
            lblInvestigatorNames.DataBindings.Add("Text", dtCase, "InvestigatorNames");
            

            txtDescription.Enabled = false;
            txtStatus.Enabled = false;
            txtCaseType.Enabled = false;
            txtDateOpened.Enabled = false;
            txtClientName.Enabled = false;

            lstCases.DataSource = dtCase;
            lstCases.ValueMember = "CaseID";
            lstCases.DisplayMember = "CaseID";

            currencyManager = (CurrencyManager)this.BindingContext[dtCase];
        }

        private void bindControls222()
        {
            dtCaseAssignment = DM.dtAssignment;
            addColumnsToDtCaseAsgmt();// add columns to dtCaseAssignment
            int rowsCount = DM.dtAssignment.Rows.Count;
            

            for (int i = 0; i < rowsCount; i++)
            {
                DataRow[] caseRows = DM.dtCase.Select("CaseID = " + dtCaseAssignment.Rows[i]["CaseID"].ToString());
                if (caseRows.Length > 0) 
                {
                    DataRow[] clientRows = DM.dtClient.Select("ClientID = " + caseRows[0]["ClientID"].ToString());
                    if (clientRows.Length > 0)
                    {
                        string fullName = clientRows[0]["LastName"].ToString() + " " + clientRows[0]["FirstName"].ToString();
                        dtCaseAssignment.Rows[i]["ClientName"] = fullName;
                    }
                    dtCaseAssignment.Rows[i]["ClientID"] = caseRows[0]["ClientID"].ToString();
                    dtCaseAssignment.Rows[i]["Description"] = caseRows[0]["Description"].ToString();
                    dtCaseAssignment.Rows[i]["Status"] = caseRows[0]["Status"].ToString();
                    dtCaseAssignment.Rows[i]["CaseType"] = caseRows[0]["CaseType"].ToString();
                    dtCaseAssignment.Rows[i]["DateOpened"] = caseRows[0]["DateOpened"].ToString();
                }
                dtCaseAssignment.Rows[i]["InvestigatorName"] = getInvestigatorNames(dtCaseAssignment.Rows[i]["CaseID"].ToString());
                //DataRow[] assignmentRows = DM.dtAssignment.Select("CaseID = " + dtCaseAssignment.Rows[i]["CaseID"].ToString());

                //string investigatorNames = "";
                //for (int j = 0; j < assignmentRows.Length; j++)
                //{
                //    DataRow[] investigatorRows = DM.dtInvestigator.Select("InvestigatorID = " + assignmentRows[j]["InvestigatorID"].ToString());
                //    if (investigatorRows.Length > 0)
                //    {
                //        if (!investigatorNames.Equals(""))
                //        {
                //            investigatorNames += ", ";
                //        }
                //        investigatorNames += investigatorRows[0]["LastName"].ToString() + " " + investigatorRows[0]["FirstName"].ToString();
                //    }
                //    dtCaseAssignment.Rows[i]["InvestigatorName"] = investigatorNames;
                //}
            }
            
            txtClientName.DataBindings.Add("Text", dtCaseAssignment, "ClientName");
            lblCaseID.DataBindings.Add("Text", dtCaseAssignment, "CaseID");
            lblClientID.DataBindings.Add("Text", dtCaseAssignment, "ClientID");
            txtCaseType.DataBindings.Add("Text", dtCaseAssignment, "CaseType");
            txtDateOpened.DataBindings.Add("Text", dtCaseAssignment, "DateOpened");
            txtDescription.DataBindings.Add("Text", dtCaseAssignment, "Description");
            txtStatus.DataBindings.Add("Text", dtCaseAssignment, "Status");
            lblInvestigatorNames.DataBindings.Add("Text", dtCaseAssignment, "InvestigatorName");

            txtClientName.Enabled = false;
            txtCaseType.Enabled = false;
            txtDateOpened.Enabled = false;
            txtDescription.Enabled = false;
            txtStatus.Enabled = false;

            lstCases.DataSource = dtCaseAssignment;
            lstCases.DisplayMember = "CaseID";
            lstCases.ValueMember = "CaseID";

            currencyManager = (CurrencyManager)this.BindingContext[dtCaseAssignment];
        }

        private string getInvestigatorNames(string caseID)
        {
            DataRow[] assignmentRows = DM.dtAssignment.Select("CaseID = " + caseID);

            string investigatorNames = "";
            for (int j = 0; j < assignmentRows.Length; j++)
            {
                DataRow[] investigatorRows = DM.dtInvestigator.Select("InvestigatorID = " + assignmentRows[j]["InvestigatorID"].ToString());
                if (investigatorRows.Length > 0)
                {
                    if (!investigatorNames.Equals(""))
                    {
                        investigatorNames += ", ";
                    }
                    investigatorNames += investigatorRows[0]["LastName"].ToString() + " " + investigatorRows[0]["FirstName"].ToString();
                }
            }
            return investigatorNames;
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
        /// Assign an Investigator to the selected case
        /// If the selected Case has a status of Closed then the error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssignInvestigator_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("Closed"))
            {
                MessageBox.Show("Cannot assign investigators to closed cases");
            }
            else
            {
                disableCaseAsgmtFormElements();
                lblPnlInvestigator.Visible = true;
                cmbPnlInvestigators.Visible = true;
                btnSaveAssignment.Text = "Save Assignment";

                cmbPnlInvestigators.DataSource = DM.BigEyeDS;
                cmbPnlInvestigators.DisplayMember = "T_Investigator.InvestigatorID";
                cmbPnlInvestigators.ValueMember = "T_Investigator.InvestigatorID";

                txtPnlHours.Text = "";

                pnlCaseAssignment.Show();
            }
        }

        /// <summary>
        /// Modify the selected Case
        /// If the status is Closed then the error message is displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyAssignment_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("Closed"))
            {
                MessageBox.Show("Cannot modify Investigators on a closed Case");
            }
            else
            {
                disableCaseAsgmtFormElements();

                lblPnlInvestigator.Visible = false;
                cmbPnlInvestigators.Visible = false;

                //DataRow dr = DM.dtAssignment.Rows.Find("CaseID = " + lblCaseID.Text);
                DataRow dr = DM.dtAssignment.Rows[currencyManager.Position];
                dtpAssignedDate.Text = dr["DateAssigned"].ToString();
                txtPnlHours.Text = dr["Hours"].ToString();
                lblPnlHiddenHours.Text = dr["Hours"].ToString();

                btnSaveAssignment.Text = "Update Investigator";
                pnlCaseAssignment.Show();
            }
        }

        /// <summary>
        /// Remove selected Investigator.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveInvestigator_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Equals("Closed"))
            {
                MessageBox.Show("You may only remove Investigators from open cases");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want delete this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DataRow dr = DM.dtAssignment.Rows[currencyManager.Position];

                    dr.Delete();
                    DM.updateAssignment();
                }
            }
        }

        /// <summary>
        /// Close the Case Assignment Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add columns to case assignment DataTable when initialize Case Assignment Form.
        /// </summary>
        private void addColumnsToDtCaseAsgmt()
        {
            if (!dtCaseAssignment.Columns.Contains("ClientName"))
            {
                dtCaseAssignment.Columns.Add("ClientName");
            }
            if (!dtCaseAssignment.Columns.Contains("InvestigatorName"))
            {
                dtCaseAssignment.Columns.Add("InvestigatorName");
            }
            if (!dtCaseAssignment.Columns.Contains("ClientID"))
            {
                dtCaseAssignment.Columns.Add("ClientID");
            }
            if (!dtCaseAssignment.Columns.Contains("Description"))
            {
                dtCaseAssignment.Columns.Add("Description");
            }
            if (!dtCaseAssignment.Columns.Contains("Status"))
            {
                dtCaseAssignment.Columns.Add("Status");
            }
            if (!dtCaseAssignment.Columns.Contains("CaseType"))
            {
                dtCaseAssignment.Columns.Add("CaseType");
            }
            if (!dtCaseAssignment.Columns.Contains("DateOpened"))
            {
                dtCaseAssignment.Columns.Add("DateOpened");
            }
        }

        /// <summary>
        /// Combine the last name and first name to Investigator Text which is in the Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPnlInvestigators_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow dr = ((DataRowView)e.ListItem).Row;

            string lastname = dr["LastName"].ToString();
            string firstname = dr["FirstName"].ToString();

            e.Value = lastname + " " + firstname;
        }

        /// <summary>
        /// Cancel Add/Modify Assignments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableCaseAsgmtFormElements();

            pnlCaseAssignment.Hide();
        }

        /// <summary>
        /// Disable the elements of Case Assignment Form when Click Assign/Modify Case Assignment.
        /// </summary>
        private void disableCaseAsgmtFormElements()
        {
            lstCases.Visible = false;
            lblInvestigatorNames.Visible = false;
            txtClientName.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAssignInvestigator.Enabled = false;
            btnModifyAssignment.Enabled = false;
            btnRemoveInvestigator.Enabled = false;
            btnReturn.Enabled = false;
        }

        /// <summary>
        /// Enable the elements of Case Assignment Form when Save/Update CaseAssignment.
        /// </summary>
        private void enableCaseAsgmtFormElements()
        {
            lstCases.Visible = true;
            lblInvestigatorNames.Visible = true;
            txtClientName.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAssignInvestigator.Enabled = true;
            btnModifyAssignment.Enabled = true;
            btnRemoveInvestigator.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// Save Assignment when Add/Modify assignments.
        /// If the Hours value is empty then show the error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAssignment_Click(object sender, EventArgs e)
        {
            if (txtPnlHours.Text == "")
            {
                MessageBox.Show("You must enter a value for Hours");
            }
            else if (!validateHours(txtPnlHours.Text))
            {
                MessageBox.Show("You must enter Hours with a number");
                txtPnlHours.Focus();
            }
            else
            {
                try
                {
                    if (cmbPnlInvestigators.Visible == true)
                    {
                        DataRow assignmentRow = DM.dtAssignment.NewRow();
                        assignmentRow["CaseID"] = lblCaseID.Text;
                        assignmentRow["InvestigatorID"] = cmbPnlInvestigators.SelectedValue;
                        assignmentRow["DateAssigned"] = dtpAssignedDate.Text;
                        assignmentRow["Hours"] = txtPnlHours.Text;

                        DM.dtAssignment.Rows.Add(assignmentRow);
                        DM.updateAssignment();

                        enableCaseAsgmtFormElements();
                        pnlCaseAssignment.Hide();

                        lblInvestigatorNames.Text = getInvestigatorNames(lblCaseID.Text.ToString());

                        MessageBox.Show("Case assigned successfully", "Success");
                    }
                    else
                    {
                        DataRow assignmentRow = DM.dtAssignment.Rows[currencyManager.Position];
                        assignmentRow["DateAssigned"] = dtpAssignedDate.Text;
                        assignmentRow["Hours"] = txtPnlHours.Text;
                        int hours;
                        if (txtPnlHours.Text == null || txtPnlHours.Text == "")
                        {
                            hours = 0;
                        }
                        else
                        {
                            hours = Convert.ToInt32(txtPnlHours.Text);

                            if (hours == 0 && Convert.ToInt32(lblPnlHiddenHours.Text) > 0)
                            {
                                MessageBox.Show("Cannot reset an assignment's hours to zero", "Error");
                                txtPnlHours.Focus();
                            }
                            else
                            {
                                currencyManager.EndCurrentEdit();
                                DM.updateAssignment();

                                enableCaseAsgmtFormElements();
                                pnlCaseAssignment.Hide();

                                MessageBox.Show("The Case Investigator updated successfully", "Success");
                            }
                        }

                    }
                }
                catch (ConstraintException exception)
                {
                    MessageBox.Show("This Investigator has already been assigned to this case");
                }
            }
        }

        /// <summary>
        /// Verify the input string is hours
        /// </summary>
        /// <param name="P_str_phone">input string</param>
        /// <returns>return a bool</returns>
        public bool validateHours(string P_str_hours)
        {
            return Regex.IsMatch(P_str_hours, "^[0-9]*$");
        }

    }
}
