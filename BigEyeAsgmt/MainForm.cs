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
    public partial class MainForm : Form
    {
        private DataModule DM;                   		// the reference to the form that holds the data components
        private ClientForm frmClient;            		// the reference to the client form
        private InvestigatorForm frmInvestigator;	 		// the reference to the investigator form
        private EquipmentForm frmEquipment;      		// the reference to the equipment form
        private CaseForm frmCase;         		// the reference to the case form
        private CaseAssignmentForm frmCaseAssignment;       		// the reference to the case assignment form

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (frmClient == null)
            {
                frmClient = new ClientForm(DM, this);
            }
            frmClient.ShowDialog();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvestigator_Click(object sender, EventArgs e)
        {
            if (frmInvestigator == null)
            {
                frmInvestigator = new InvestigatorForm(DM, this);
            }
            frmInvestigator.ShowDialog();
        }
    }
}
