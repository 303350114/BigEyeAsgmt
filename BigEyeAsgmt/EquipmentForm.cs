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
    public partial class EquipmentForm : Form
    {
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private DataModule DM;

        public EquipmentForm()
        {
            InitializeComponent();
        }

        public EquipmentForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            bindControls();
        }

        private void bindControls()
        {
            lblEquipmentID.DataBindings.Add("Text", DM.BigEyeDS, "T_Equipment.EquipmentID");
            txtDescription.DataBindings.Add("Text", DM.BigEyeDS, "T_Equipment.Description");
            txtInvestigatorID.DataBindings.Add("Text", DM.BigEyeDS, "T_Equipment.InvestigatorID");

            txtDescription.Enabled = false;
            txtInvestigatorID.Enabled = false;

            lstEquipments.DataSource = DM.BigEyeDS;
            lstEquipments.DisplayMember = "T_Equipment.Description";
            lstEquipments.ValueMember = "T_Equipment.Description";

            currencyManager = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_Equipment"];
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

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            disableEquipmentFormElements();
            resetEquipmentVal();

            lblPnlEquipmentID.Visible = false;
            lblPnlEquipmentNO.Visible = false;
            lblPnlInvestigatorID.Visible = false;
            cmbInvestigatorID.Visible = false;

            pnlEquipment.Show();
        }

        private void btnModifyEquipment_Click(object sender, EventArgs e)
        {
            disableEquipmentFormElements();
            resetEquipmentVal();

            lblPnlEquipmentID.Visible = true;
            lblPnlEquipmentNO.Visible = true;
            lblPnlInvestigatorID.Visible = true;
            cmbInvestigatorID.Visible = true;

            btnSaveEquipment.Text = "Update Equipment";

            DataRow modifyEquipment = DM.dtEquipment.Rows[currencyManager.Position];
            lblPnlEquipmentID.Text = modifyEquipment["EquipmentID"].ToString();
            txtPnlDescription.Text = modifyEquipment["Description"].ToString();

            cmbInvestigatorID.DataSource = DM.BigEyeDS;
            cmbInvestigatorID.ValueMember = "T_Investigator.InvestigatorID";
            cmbInvestigatorID.DisplayMember = "T_Investigator.LastName";
            if (modifyEquipment["InvestigatorID"]!= DBNull.Value)
            {
                cmbInvestigatorID.SelectedValue = modifyEquipment["InvestigatorID"].ToString();
            }
            pnlEquipment.Show();
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            DataRow deleteEquipmentRow = DM.dtEquipment.Rows[currencyManager.Position];

            if (txtInvestigatorID.Text.Equals(""))
            {
                if (MessageBox.Show("Are you sure you want to delete this records?", "Warning",
                         MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEquipmentRow.Delete();
                    DM.updateEquipment();
                }
            }
            else
            {
                MessageBox.Show("You may only delete Equipment that is not assigned to an investigator!", "Error");
            }
        }

        private void btnSaveEquipment_Click(object sender, EventArgs e)
        {
            if (txtPnlDescription.Text == "")
            {
                txtPnlDescription.Focus();
                MessageBox.Show("You must enter a value for the description field", "Error");
            }
            else
            {
                DataRow equipmentRow;
                if (lblPnlEquipmentID.Text == null || lblPnlEquipmentID.Text.Equals(""))
                {
                    equipmentRow = DM.dtEquipment.NewRow();
                    equipmentRow["Description"] = txtPnlDescription.Text;

                    DM.dtEquipment.Rows.Add(equipmentRow);
                    DM.updateEquipment();

                    enableEquipmentFormElements();
                    pnlEquipment.Hide();

                    MessageBox.Show("Equipment added successfully", "Success");
                }
                else
                {
                    equipmentRow = DM.dtEquipment.Rows[currencyManager.Position];
                    equipmentRow["Description"] = txtPnlDescription.Text;
                    equipmentRow["InvestigatorID"] = cmbInvestigatorID.SelectedValue;

                    currencyManager.EndCurrentEdit();
                    DM.updateEquipment();

                    enableEquipmentFormElements();
                    pnlEquipment.Hide();

                    MessageBox.Show("Equipment updated successfully", "Success");
                }
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetEquipmentVal()
        {
            lblPnlEquipmentID.Text = null;
            txtPnlDescription.Text = "";
        }

        private void enableEquipmentFormElements() 
        {
            lstEquipments.Visible = true;
            txtDescription.Visible = true;
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnAddEquipment.Enabled = true;
            btnModifyEquipment.Enabled = true;
            btnDeleteEquipment.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void disableEquipmentFormElements()
        {
            lstEquipments.Visible = false;
            txtDescription.Visible = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnAddEquipment.Enabled = false;
            btnModifyEquipment.Enabled = false;
            btnDeleteEquipment.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enableEquipmentFormElements();

            pnlEquipment.Hide();
        }
    }
}
