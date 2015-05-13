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
    public partial class OrderForm : Form
    {
        private MainForm frmMenu;
        private DataModule DM;

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;
        }

        private void getOrderList()
        {
            foreach (DataRow orderRow in dtOrder.Rows)
            {
                DataRow[] drOrders = orderRow.GetChildRows(dtOrder.ChildRelations["REL_OrderOLine"]);
                string order_number = "";
                Double totalAmount = 0;
                if (drOrders.Length > 0)
                {
                    order_number = drOrders["order_number"].ToString();

                    foreach (DataRow drOrderLine in drOrders)
                    {
                        totalAmount += Convert.ToDouble(drOrderLine["Price"].ToString());
                    }
                    lstOrder.Items.Add(order_number + ", " + totalAmount);// Add the order_number and total amount of each order to Listbox
                }
            }
        }

        private void displayCDList()
        {
            foreach (DataRow cdRow in dtCD.Rows)
            {
                DataRow[] drCDs = cdRow.GetChildRows(dtCD.ChildRelations["REL_CDTrack"]);
                string CD_number = "";
                Double totalPlayingLength  = 0;
                if (drCDs.Length > 0)
                {
                    CD_number = drCDs["CD_number"].ToString();

                    foreach (DataRow drCDTrack in drCDs)
                    {
                        totalPlayingLength += Convert.ToDouble(drCDTrack["PlayingLength"].ToString());
                    }
                    lstCD.Items.Add(CD_number + ", " + totalPlayingLength);// Add the order_number and total amount of each order to Listbox
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
