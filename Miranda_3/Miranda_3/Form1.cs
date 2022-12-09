// Programmer: Bryan Miranda
//Project: Assignment 3
//Date: 03/29/2021
//Description: Bonnies Ballons Order-Taking system
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Miranda_3
{
    public partial class Form1 : Form
    {
        //Declaring class-level constants / decimals for delivery option fee etc
        private const decimal SALES_TAX = 0.07m;
        private const decimal SINGLE_ORDER = 9.95m;
        private const decimal HALF_DOZEN_ORDER = 34.95m;
        private const decimal DOZEN_ORDER = 65.95m;
        private const decimal EXTRAS = 9.50m;
        private const decimal MESSAGE = 2.50m;

        private const decimal homeDeliver = 7.50m;
        private const decimal salesTax = 0m;
        private const decimal subtotal = 0m;
        // Declaring Int variables for future use in the coding
        private int extras;
        private decimal ExtraTotal;
        private int orderSelected;
        public Form1()
        {
            InitializeComponent();
        }
        //Execute following codes upon booting up the program        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //First one is to display the current date instead of having to type it in manually          

            dateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            try //Try catch statement created for the special occasions birthday, congratulations etc. catch for closing the selection
            {
                StreamReader inputFile; // Delcaring streamwrite object for use in the file
                inputFile = File.OpenText("Occasions.txt"); //Specifying folder
                while (!inputFile.EndOfStream)
                {
                    occassionsComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();

            }
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Extras.txt");
                while (!inputFile.EndOfStream)
                {
                    extrasListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }

        }
        //I tried to do all the Update total adjustsments but I just didnt know what I was doing wrong
        // I ended up seperating all the codes and then found myself half trouble making a variiable to combine all the options

        private void homedeliveryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            decimal orderTotal;
            if (homedeliveryRadioButton.Checked)
            {
                orderTotal = homeDeliver * SALES_TAX;   
            }
            //Calculating total  amount after selections   
            orderTotal = homeDeliver * SALES_TAX;
            //Creating strings to labels to show totals
        }
            private void singleballoonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            decimal orderTotal;                     
           
            if (singleballoonRadioButton.Checked)// Single balloon radio button code if checked amount adjusted
            {
                orderTotal = SINGLE_ORDER + ExtraTotal * SALES_TAX;
                singleLabel.Enabled = true;// When checked label displays the price of balloon
                singleLabel.Text = SINGLE_ORDER.ToString("c");
            }
            else
            {
                singleLabel.Enabled = false;
                singleLabel.Text = "";
            }           
            //Calculating total  amount after selections          
            orderTotal = SINGLE_ORDER + ExtraTotal * SALES_TAX;
            //Creating strings to labels so it shows in the application
            subLabel.Text = SINGLE_ORDER.ToString("c");
            saletaxLabel.Text = (SINGLE_ORDER * SALES_TAX).ToString("c");
            totalsLabel.Text = (SINGLE_ORDER + (SINGLE_ORDER * SALES_TAX)).ToString("c");

        }
        private void halfdozenRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            decimal orderTotal;
            // When checked label displays the price of balloon

            if (halfdozenRadioButton.Checked)// half dozen balloon radio button code if checked amount adjusted
            {
                orderTotal = (HALF_DOZEN_ORDER + ExtraTotal) * SALES_TAX;
                halfdozenLabel.Enabled = true;// When checked label displays the price of balloon
                halfdozenLabel.Text = HALF_DOZEN_ORDER.ToString("c");
            }
            else
            {
                halfdozenLabel.Enabled = false;
                halfdozenLabel.Text = "";
            }


            //Calculating total  amount after selections          
            orderTotal = HALF_DOZEN_ORDER + ExtraTotal * SALES_TAX;
            //Creating strings to labels so it shows in the application
            subLabel.Text = HALF_DOZEN_ORDER.ToString("c");
            saletaxLabel.Text = (HALF_DOZEN_ORDER* SALES_TAX).ToString("c");
            totalsLabel.Text = (HALF_DOZEN_ORDER + (HALF_DOZEN_ORDER * SALES_TAX)).ToString("c");

        }

        private void dozenballoonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            decimal orderTotal;
            // when checked label displays the price of balloon
            if (dozenballoonRadioButton.Checked)
            {
                orderTotal = (DOZEN_ORDER + ExtraTotal) * SALES_TAX;
                dozenLabel.Enabled = true;// When checked label displays the price of balloon
                dozenLabel.Text = DOZEN_ORDER.ToString("c");
                if (personalizedmessageCheckBox.Checked)
                {

                    orderTotal = MESSAGE * SALES_TAX;
                    personalizedmessageTextBox.Enabled = true;

                }

            }           
            else
            {
                dozenLabel.Enabled = false;
                dozenLabel.Text = "";
                personalizedmessageTextBox.Enabled = false;
            }
            
            //Calculating total  amount after selections          
            orderTotal = DOZEN_ORDER + ExtraTotal * SALES_TAX;
            //Creating strings to labels so it shows in the application
            subLabel.Text = (DOZEN_ORDER + MESSAGE).ToString("c");
            saletaxLabel.Text = (DOZEN_ORDER * SALES_TAX).ToString("c");
            totalsLabel.Text = (DOZEN_ORDER + (DOZEN_ORDER * SALES_TAX)).ToString("c");
        }       

        //if / else statement created if the personalized check box is selected . if not then it is not enabled
        private void personalizedmessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decimal orderTotal;

            if (personalizedmessageCheckBox.Checked)
            {
                orderTotal= MESSAGE * SALES_TAX;
                personalizedmessageTextBox.Enabled = true;

            }
            else
            {
                personalizedmessageTextBox.Enabled = false;
            }
            //Calculating total  amount after selections          
            orderTotal = MESSAGE* SALES_TAX;
            //Creating strings to labels so it shows in the application
            subLabel.Text = MESSAGE.ToString("c");
            saletaxLabel.Text = (MESSAGE * SALES_TAX).ToString("c");
            totalsLabel.Text = (MESSAGE + (MESSAGE * SALES_TAX)).ToString("c");
        }
    
        //Clear form action for resetting the client removing all information in fields
        private void clearformButton_Click(object sender, EventArgs e)
        {
            storepickupRadioButton.Checked = true;
            singleballoonRadioButton.Checked = true;
            occassionsComboBox.SelectedIndex = -1;
            extrasListBox.SelectedIndex = -1;
            firstnameTextBox.Text = "";
            lastnameTextBox.Text = "";
            streetTextBox.Text = "";
            cityTextBox.Text = "";
            zipcodeMaskedTextBox.Text = "";
            stateMaskedTextBox.Text = "";
            phonenumberMaskedTextBox.Text = "";
            personalizedmessageCheckBox.Checked = false;
        }

        private void occassionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //Try catch statement created for the special occasions birthday, congratulations etc. catch for closing the selection
            {
                StreamReader inputFile; // Delcaring streamwrite object for use in the file
                inputFile = File.OpenText("Occasions.txt"); //Specifying folder
                while (!inputFile.EndOfStream)
                {
                    occassionsComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();

            }
        }
        //Created a private void for the extras list boxs and a if/if code for selection
        private void extrasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberSelected = 0;

            if (extrasListBox.SelectedItems.Count == 1)// Coffee mug selection
            {
                numberSelected += 1;
            }
            if (extrasListBox.SelectedItems.Count == 2)// Flower Selected
            {
                numberSelected += 1;
            }
            if (extrasListBox.SelectedItems.Count == 3)//Potted Plant Selection
            {
                numberSelected += 1;
            }
            if (extrasListBox.SelectedItems.Count == 4)// Box of chocolates selection
            {
                numberSelected += 1;
            }
            if (extrasListBox.SelectedItems.Count == 5)// Jar of jelly beans selection
            {
                numberSelected += 1;
            }
            ExtraTotal = numberSelected * EXTRAS;
            extrapriceLabel.Text = ExtraTotal.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Dialog result Message box created for confirmation when exiting out of program
            DialogResult result = MessageBox.Show("Do you really want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }
    }
}
  