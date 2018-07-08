using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Using Class Library
using ClassLibrary.Classes;

namespace MagmaDemo
{
    public partial class Form1 : Form
    {
        public static User LoggedInUser;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(User U)
        {
            InitializeComponent();
            LoggedInUser = U;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magmaDataSet4.WrkOrds' table. You can move, or remove it, as needed.
            this.wrkOrdsTableAdapter.Fill(this.magmaDataSet4.WrkOrds);
            // TODO: This line of code loads data into the 'magmaDataSet3.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter1.Fill(this.magmaDataSet3.Item);
            // TODO: This line of code loads data into the 'magmaDataSet2.Machines' table. You can move, or remove it, as needed.
            this.machinesTableAdapter1.Fill(this.magmaDataSet2.Machines);
            // TODO: This line of code loads data into the 'magmaDataSet1.Machines' table. You can move, or remove it, as needed.
            this.machinesTableAdapter.Fill(this.magmaDataSet1.Machines);
            // TODO: This line of code loads data into the 'magmaDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.magmaDataSet.Item);

            ResetCB();
            FillItemsList();
            FillMachineList();
            FillOrdersList();
        }

        /// <summary>
        /// Fills the Items DataGridView
        /// </summary>
        public void FillItemsList()
        {
            Item I = new Item();
            DGV_Items.DataSource = "";
            DGV_Items.DataSource = I.GetData();
            DGV_Items.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        /// <summary>
        /// Fills the Machines DataGridView
        /// </summary>
        public void FillMachineList()
        {
            Machine M = new Machine();
            DGV_Machines.DataSource = "";
            DGV_Machines.DataSource = M.GetData();
            DGV_Machines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        /// <summary>
        /// Fills the WorkOrders DataGridView
        /// </summary>
        public void FillOrdersList()
        {
            WorkOrder W = new WorkOrder();
            DGV_WrkOrds.DataSource = "";
            DGV_WrkOrds.DataSource = W.GetData();
            DGV_WrkOrds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        public void ResetCB()
        {
            CB_CatNum.SelectedIndex = -1;
            CB_MachName.SelectedIndex = -1;
            Txt_Qty.Text = "";
        }

        private void Btn_AddItem_Click(object sender, EventArgs e)
        {
            var ignoreMe = 0;
            bool isInt = int.TryParse(Txt_ItemNum.Text, out ignoreMe); // Verify that the CatNum is a number

            if (isInt)
            {
                Item I = new Item(int.Parse(Txt_ItemNum.Text), Txt_ItemDesc.Text);

                if (I.AddNew(LoggedInUser))
                {
                    MessageBox.Show(string.Format("Item {0} was successfully added to the DB", Txt_ItemNum.Text));
                    FillItemsList();
                }
                else
                {
                    MessageBox.Show(string.Format("Item {0} Already exists. Please add a new Item.", Txt_ItemNum.Text));
                }
            }
        }

        private void Btn_AddMach_Click(object sender, EventArgs e)
        {
            Machine M = new Machine(Txt_Machine.Text);
           
            if (M.AddNew(LoggedInUser))
            {
                MessageBox.Show(string.Format("Machine {0} was successfully added to the DB", Txt_Machine.Text));
                FillMachineList();
            }
            else
            {
                MessageBox.Show(string.Format("Machine {0} Already exists. Please add a new Machiene", Txt_Machine.Text));
            }
        }

        private void BTN_AddWrkOrd_Click(object sender, EventArgs e)
        {
            WorkOrder W = new WorkOrder();
            W.Numarator = W.GetOrderNum();
            if (CB_MachName.SelectedValue != null && CB_CatNum.SelectedValue != null && !string.IsNullOrEmpty(Txt_Qty.Text))
            {
                W.Machine = new Machine(CB_MachName.SelectedValue.ToString());
                W.CatNum = new Item(int.Parse(CB_CatNum.SelectedValue.ToString()));
                W.Qty = int.Parse(Txt_Qty.Text);

                W.AddNew(LoggedInUser);
                MessageBox.Show(string.Format("Work Order {0} was successfully added to the DB", W.Numarator));
                FillOrdersList();
                ResetCB();
            }
        }

        // Allow only numbers in Quantity TextBox
        private void Txt_Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
