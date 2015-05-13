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
    public partial class ClientForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public ClientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloading the constructor
        /// </summary>
        /// <param name="dm"> DataModule </param>
        /// <param name="menu"> MainForm </param>
        public ClientForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls();
        }

        /// <summary>
        /// Bind the values to elements of the Client Form
        /// </summary>
        private void bindControls()
        {
            lblClientID.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.ClientID");
            txtLastName.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.LastName");
            txtFirstName.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.Suburb");
            txtCity.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.City");
            txtPhoneNumber.DataBindings.Add("Text", DM.BigEyeDS, "T_Client.PhoneNumber");

            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtCity.Enabled = false;
            txtPhoneNumber.Enabled = false;

            lstClients.DataSource = DM.BigEyeDS;
            lstClients.DisplayMember = "T_Client.LastName";
            lstClients.ValueMember = "T_Client.LastName";

            currencyManager = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_CLIENT"];
        }

        /// <summary>
        /// Select the previous Client value.
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
        /// Select the Next Client value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// Close Client Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Show the panel pnlClient when click Add Client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            disableClientFormElements();
            resetClientVal();

            lblPnlClientNO.Visible = false;
            lblPnlClientID.Visible = false;

            btnSaveClient.Text = "Save Client";

            pnlClient.Show();
        }
        
        /// <summary>
        /// Cancel Add a new Client or Modify selected Client values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableClientFormElements();
            pnlClient.Hide();
        }

        /// <summary>
        /// Show the panel pnlClient when click Modify Client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifyClient_Click(object sender, EventArgs e)
        {
            disableClientFormElements();
            resetClientVal();
            lblPnlClientID.Visible = true;
            lblPnlClientNO.Visible = true;

            btnSaveClient.Text = "Update Client";
            DataRow updateClient = DM.dtClient.Rows[currencyManager.Position];
            lblPnlClientID.Text = updateClient["ClientID"].ToString();
            txtPnlLastName.Text = updateClient["LastName"].ToString();
            txtPnlFirstName.Text = updateClient["FirstName"].ToString();
            txtPnlStreetAddress.Text = updateClient["StreetAddress"].ToString();
            txtPnlSuburb.Text = updateClient["Suburb"].ToString();
            txtPnlCity.Text = updateClient["City"].ToString();
            txtPnlPhoneNumber.Text = updateClient["PhoneNumber"].ToString();

            pnlClient.Show();
        }

        /// <summary>
        /// Remove selected Client.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            DataRow deleteClientRow = DM.dtClient.Rows[currencyManager.Position];
            DataRow[] CaseRow = DM.dtCase.Select("ClientID = " + lblClientID.Text);
            if (CaseRow.Length != 0)
            {
                MessageBox.Show("You may only delete Clients who have no cases", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteClientRow.Delete();
                    DM.updateClient();
                    MessageBox.Show("Client deleted successfully", "Success");
                }
            }
        }
        
        /// <summary>
        /// Save Add/Update Client data. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            //Create a new row that the variables will be added into
            DataRow clientRow;
            if (txtPnlLastName.Text == "" || txtPnlFirstName.Text == "" || txtPnlStreetAddress.Text == ""
                || txtPnlSuburb.Text == "" || txtPnlCity.Text == "" || txtPnlPhoneNumber.Text == "")
            {
                MessageBox.Show("You must enter a value for each of the text fields", "Error");
            }
            else if (!validatePhone(txtPnlPhoneNumber.Text))
            {
                txtPnlPhoneNumber.Focus();
                MessageBox.Show("You entered a wrong Phone Number, Please re-enter it", "Error");
            }
            else
            {
                if (lblPnlClientID.Text == null || lblPnlClientID.Text.Equals(""))
                {
                    clientRow = DM.dtClient.NewRow();
                    clientRow["LastName"] = txtPnlLastName.Text;
                    clientRow["FirstName"] = txtPnlFirstName.Text;
                    clientRow["StreetAddress"] = txtPnlStreetAddress.Text;
                    clientRow["Suburb"] = txtPnlSuburb.Text;
                    clientRow["City"] = txtPnlCity.Text;
                    clientRow["PhoneNumber"] = txtPnlPhoneNumber.Text;
                    
                    DM.dtClient.Rows.Add(clientRow);
                    DM.updateClient();

                    enableClientFormElements();
                    pnlClient.Hide();

                    //Give the user a success message
                    MessageBox.Show("Client added successfully", "Success");
                }
                else
                {
                    clientRow = DM.dtClient.Rows[currencyManager.Position];
                    clientRow["LastName"] = txtPnlLastName.Text;
                    clientRow["FirstName"] = txtPnlFirstName.Text;
                    clientRow["StreetAddress"] = txtPnlStreetAddress.Text;
                    clientRow["Suburb"] = txtPnlSuburb.Text;
                    clientRow["City"] = txtPnlCity.Text;
                    clientRow["PhoneNumber"] = txtPnlPhoneNumber.Text;

                    currencyManager.EndCurrentEdit();
                    DM.updateClient();

                    enableClientFormElements();
                    pnlClient.Hide();

                    //Give the user a success message
                    MessageBox.Show("Client updated successfully", "Success");
                }
            }
        }

        /// <summary>
        /// Enable all of disabled elements in Client Form.
        /// </summary>
        private void enableClientFormElements()
        {
            lstClients.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddClient.Enabled = true;
            btnModifyClient.Enabled = true;
            btnDeleteClient.Enabled = true;
            btnReturn.Enabled = true;
        }

        /// <summary>
        /// Disable part of Client Form elements.
        /// </summary>
        private void disableClientFormElements()
        {
            lstClients.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddClient.Enabled = false;
            btnModifyClient.Enabled = false;
            btnDeleteClient.Enabled = false;
            btnReturn.Enabled = false;
        }

        /// <summary>
        /// Reset Client Value when Add or Modify.
        /// </summary>
        private void resetClientVal()
        {
            lblPnlClientID.Text = null;
            txtPnlLastName.Text = "";
            txtPnlFirstName.Text = "";
            txtPnlStreetAddress.Text = "";
            txtPnlSuburb.Text = "";
            txtPnlCity.Text = "";
            txtPnlPhoneNumber.Text = "";
        }

        /// <summary>
        /// Verify the input string is telphone number
        /// </summary>
        /// <param name="P_str_phone">input string</param>
        /// <returns>return a bool</returns>
        public bool validatePhone(string P_str_phone)
        {
            return Regex.IsMatch(P_str_phone, "^[0-9]*$");
        }
    }
}
