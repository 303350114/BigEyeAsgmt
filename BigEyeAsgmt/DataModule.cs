using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BigEyeAsgmt
{
    public partial class DataModule : Form
    {
        public DataTable dtClient;
        public DataTable dtAssignment;
        public DataTable dtCase;
        public DataTable dtEquipment;
        public DataTable dtInvestigator;
        public DataView clientView;
        public DataView assignmentView;
        public DataView caseView;
        public DataView equipmentView;
        public DataView investigatorView;

        public DataModule()
        {
            InitializeComponent();
            BigEyeDS.EnforceConstraints = false;
            daCase.Fill(BigEyeDS);
            daClient.Fill(BigEyeDS);
            daAssignment.Fill(BigEyeDS);
            daEquipment.Fill(BigEyeDS);
            daInvestigator.Fill(BigEyeDS);

            dtAssignment = BigEyeDS.Tables["T_Assignment"];
            dtCase = BigEyeDS.Tables["T_Case"];
            dtClient = BigEyeDS.Tables["T_Client"];
            dtEquipment = BigEyeDS.Tables["T_Equipment"];
            dtInvestigator = BigEyeDS.Tables["T_Investigator"];

            caseView = new DataView(dtCase);
            caseView.Sort = "CaseID";
            clientView = new DataView(dtClient);
            clientView.Sort = "ClientID";
            equipmentView = new DataView(dtEquipment);
            equipmentView.Sort = "EquipmentID";
            investigatorView = new DataView(dtInvestigator);
            investigatorView.Sort = "InvestigatorID";

            BigEyeDS.EnforceConstraints = true;
        }

        public void updateAssignment()
        {
            daAssignment.Update(dtAssignment);
        }

        public void updateCase()
        {
            daCase.Update(dtCase);
        }

        public void updateClient()
        {
            daClient.Update(dtClient);
        }

        public void updateEquipment()
        {
            daEquipment.Update(dtEquipment);
        }

        public void updateInvestigator()
        {
            daInvestigator.Update(dtInvestigator);
        }

        private void daCase_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnBigEye);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the CaseID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["CaseID"] = newID;
            }
        }

        private void daClient_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnBigEye);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the ClientID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ClientID"] = newID;
            }
        }

        private void daEquipment_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnBigEye);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the EquipmentID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EquipmentID"] = newID;
            }
        }

        private void daInvestigator_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve 
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", CtnBigEye);

            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the InvestigatorID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["InvestigatorID"] = newID;
            }
        }
    }
}
