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
    public partial class AssignmentForm : Form
    {
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private DataModule DM;
        private DataTable dtCaseAssignment;
        private DataTable dtCase;

        public AssignmentForm()
        {
            InitializeComponent();
        }


    }
}
