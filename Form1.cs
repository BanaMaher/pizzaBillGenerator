using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var rcp = lstBill.Items;
            double sizePrice = 0,
                   peporoni = 0,
                   pineapple = 0,
                   margerita = 0,
                   seafood = 0,
                   mushroom = 0;

            double total;

            if(txtName.Text.Length == 0)
            {
                MessageBox.Show("Please write a name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                rcp.Clear();
                rcp.Add("Pizza hut");
                rcp.Add("Date: " + DateTime.Now.Date.ToString("dd MMM yyyy"));
                rcp.Add("Time: " + DateTime.Now.ToShortTimeString());
                rcp.Add("Name:\t" + txtName.Text); //String Cancatonation

                  if (radLarge.Checked == true)
                            {
                                sizePrice = 20;
                                rcp.Add("Pizza:\t\t" + sizePrice.ToString("C"));
                            }
                            else if (radRegular.Checked == true)
                            {
                                sizePrice = 5;
                                rcp.Add("Pizza:\t\t" + sizePrice.ToString("C"));
                            }

                            rcp.Add("Toppings:\t\t");

                            if (chkMashroom.Checked == true)
                            {
                                mushroom = 1;
                                rcp.Add("Mushroom:\t" + mushroom.ToString("C"));
                            }

                            if (chkPeporoni.Checked == true)
                            {
                                peporoni = 3;
                                rcp.Add("Peporoni:\t\t" + peporoni.ToString("C"));
                            }

                            if (chkSeafood.Checked == true)
                            {
                                seafood = 1;
                                rcp.Add("Seafood:\t\t" + seafood.ToString("C"));
                            }

                            if (chkPineapple.Checked == true)
                            {
                                pineapple = 3;
                                rcp.Add("Pineapple:\t" + pineapple.ToString("C"));
                            }

                            if (chkMargerita.Checked == true)
                            {
                                margerita = 2;
                                rcp.Add("Margerita:\t\t" + margerita.ToString("C"));
                            }
                            //var myList = new List<String> { "Peporoni", "Margerita", "pineapple" };
                            total = sizePrice + mushroom + margerita + seafood + pineapple + peporoni;

                            rcp.Add("\t\t-----------------");
                            rcp.Add("Total:\t\t" + total.ToString("C"));
            }

        }

        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            radLarge.Checked = false;
            radRegular.Checked = false;
            chkMargerita.Checked = false;
            chkMashroom.Checked = false;
            chkPeporoni.Checked = false;
            chkPineapple.Checked = false;
            chkSeafood.Checked = false;
            lstBill.Items.Clear();
            txtName.Focus();

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)) // e.keychar is the user's keypress on the keyboard
            {
                // Accept the Key
                e.Handled = false;//false for typing
            }
            else
            {
                //Deny the key
                e.Handled = true;//true for not typing
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radLarge.Checked = true;
        }
    }
}

