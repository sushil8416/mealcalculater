using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        const double TAX_RATE = 0.076;
        const double EXTRA_DISCOUNT = 0.1;
        

        private void tipitemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalculateTotal.Enabled = true;

        }

        private void chkMilitary_CheckedChanged(object sender, EventArgs e)
        {
            chkSeniorCitizen.Checked = false;
            chkStudent.Checked = false;
        }


        private void chkSeniorCitizen_CheckedChanged(object sender, EventArgs e)
        {
            chkMilitary.Checked = false;
            chkStudent.Checked = false;
        }

        private void chkStudent_CheckedChanged(object sender, EventArgs e)
        {
            chkSeniorCitizen.Checked = false;
            chkMilitary.Checked = false;
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            try {
                double mealCost = Convert.ToDouble(txtMealCost.Text);
                double AdditionalDiscount = 0;
                double tax, tip, totalCost;
                string text = (tipitemsListBox.GetItemText(tipitemsListBox.SelectedItem)).Split('%')[0];
                if (chkMilitary.Checked || chkSeniorCitizen.Checked || chkStudent.Checked)
                {
                    AdditionalDiscount = (EXTRA_DISCOUNT * Convert.ToDouble(mealCost));
                    mealCost = Convert.ToDouble(mealCost) - Convert.ToDouble(AdditionalDiscount);
                }
                tax = mealCost * TAX_RATE;
                int tipRate = Convert.ToInt32(text);
                switch (tipRate)
                {
                    case 10:
                        tip = mealCost * 0.1;
                        break;
                    case 15:
                        tip = mealCost * 0.15;
                        break;
                    case 20:
                        tip = mealCost * 0.2;
                        break;
                    case 25:
                        tip = mealCost * 0.25;
                        break;
                    case 30:
                        tip = mealCost * 0.3;
                        break;
                    case 35:
                        tip = mealCost * 0.35;
                        break;
                    default:
                        tip = mealCost * 0;
                        break;
                }
                totalCost = mealCost + tax + tip;
                MessageBox.Show("Your total meal cost is $" + totalCost.ToString("F2"));
            }
            catch (Exception ex) {
                MessageBox.Show("Please Enter the valid Meal Cost.");
            }
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void rdkLessThan_CheckedChanged(object sender, EventArgs e)
        {
            tipitemsListBox.Items.Clear();
            tipitemsListBox.Items.Add("None");
            for(int i = 10; i <= 35; i = i + 5)
            {
                tipitemsListBox.Items.Add(i+"%");
            }
        }
        private void rdkGrtThan_CheckedChanged(object sender, EventArgs e)
        {
            tipitemsListBox.Items.Clear();
            for (int i = 15; i <= 35; i = i + 5)
            {
                tipitemsListBox.Items.Add(i + "%");
            }
        }
    }
}
