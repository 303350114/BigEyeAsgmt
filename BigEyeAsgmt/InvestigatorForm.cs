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


    }
}
