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

        }
    }
}
