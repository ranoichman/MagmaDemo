using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary.Classes;

namespace MagmaDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            DbService dbs = new DbService();
            DataTable DT = new DataTable();
            if (!string.IsNullOrEmpty(Txt_User.Text) && !string.IsNullOrEmpty(Txt_Pass.Text) && CB_Lang.SelectedIndex != -1)
            {
                Lang L = new Lang(int.Parse(CB_Lang.SelectedValue.ToString()));
                User U = new User(int.Parse(Txt_User.Text), L);
                U.GetUserDetails();
                if (!string.IsNullOrEmpty(U.Pass) && U.Pass == Txt_Pass.Text)
                {
                    this.Hide();
                    Form1 F = new Form1(U);
                    this.Closed += (s, args) => this.Close();
                    F.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User name or pass are not correct. Please try again.");
                    Txt_Pass.Text = "";
                    Txt_User.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter your credentials!");
            }
        }

        private void Txt_User_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magmaDataSet5.Languages' table. You can move, or remove it, as needed.
            this.languagesTableAdapter.Fill(this.magmaDataSet5.Languages);
            CB_Lang.SelectedIndex = -1;

        }
    }
}
