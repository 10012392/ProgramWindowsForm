//Lara Corkery 10012392
//Program Using windows forms to keep customer details
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentApplication
{

    public partial class Form1 : Form
    {
        //This is a list that adds the customer's inputted information to the list.
        List<Customer> CustomerDB = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        //Clear Button Fuction
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        //Search Button Function
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                //Search Error Message
                //If there is no input
                string message = "Please Enter Customer's Name";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                txtSearch.Focus();

            }
            else
            {
                for (int i = 0; i < CustomerDB.Count; i++)
                {
                    //Search fucntion to complete search process 
                    //Finding the data based off the search
                    if (txtSearch.Text.ToLower().Trim() == CustomerDB[i].FName.ToLower().Trim() || txtSearch.Text.ToLower().Trim() == CustomerDB[i].LName.ToLower().Trim() || txtSearch.Text.ToLower().Trim() == CustomerDB[i].Phone.ToLower().Trim())
                    {
                        ClearDisplay();
                        listBox1.Items.Add(CustomerDB[i].GetCustomer());
                        i = CustomerDB.Count + 9;
                        txtSearch.Clear();
                        txtSearch.Focus();
                    }
                    else if (i + 1 == CustomerDB.Count)
                    {
                        //Error message if the details are not found
                        string message = "Customer Details Not Found";
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons);
                        txtSearch.Focus();

                    }

                }
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        //This is the add button 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validation for the add button 
            if (txtFName.Text.Length > 1 && txtLName.Text.Length > 1 && txtPhone.Text.Length > 1)
            {
                listBox1.Items.Clear();
                CustomerDB.Add(new Customer(txtFName.Text, txtLName.Text, txtPhone.Text));
                foreach (Customer x in CustomerDB)
                {
                    listBox1.Items.Add(x.GetCustomer());
                }

                //Clears the boxes
                ClearBoxes();

            }
            else
            {
                //Error Message
                //If all of the fields are not completed
                string message = "Please Fill In All Fields";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }

        }

        //Clear List Button Fucntion 
        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //Clear Display Method 
        public void ClearDisplay()
        {
            listBox1.Items.Clear();
        }

        //Method For Previous Customer Details 
        public void LoadDB()
        {
            CustomerDB.Add(new Customer("Jim", "Smith", "345-2514"));
            CustomerDB.Add(new Customer("Jo", "Baker", "346-1263"));
            CustomerDB.Add(new Customer("Aimee", "Ellery", "346-3658"));
            CustomerDB.Add(new Customer("Sam", "Herewini", "346-9898"));
        }

        //Selecting In List Box Fucntion
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //List Customers Button Function
        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            LoadDB();
            ClearDisplay();
            DisplayCustomer();
           
        }

        //Display Customer Method 
        public void DisplayCustomer()
        {
            foreach(Customer x in CustomerDB)
            {
                listBox1.Items.Add(x.GetCustomer());
            }
        }

        //Clear Boxes Method 
        public void ClearBoxes()
        {
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
        }

        private void SearchCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
