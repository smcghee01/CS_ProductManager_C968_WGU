using OutsourcedPart;
using InhousePart;
using InventoryManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddProduct;

namespace PartForm
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            addPartInhouseRadio.Checked = true;
            partAddCompanyName.Enabled = false;


            if (Inventory.AllParts.Count == 0)
            {
                partAddPartID.Text = Inventory.AllParts.Count.ToString();
            }
            else
            {
                partAddPartID.Text = (Inventory.AllParts.Last().PartID + 1).ToString();
            }
        }

        public void PartAddSaveButton_Click(object sender, EventArgs e) //need to set all fields as required
        {

            partAddInventory.BackColor = Color.White;
            partAddPrice.BackColor = Color.White;
            partAddMin.BackColor = Color.White;
            partAddMax.BackColor = Color.White;
            partAddMachineID.BackColor = Color.White;
            partAddCompanyName.BackColor = Color.White;
            partAddPartName.BackColor = Color.White;

            bool testpartPrice = Decimal.TryParse(partAddPrice.Text, out decimal y);
            bool testpartInventory = Int32.TryParse(partAddInventory.Text, out int z);
            bool testpartMin = Int32.TryParse(partAddMin.Text, out int a);
            bool testpartMax = Int32.TryParse(partAddMax.Text, out int b);
            bool testpartMachineID = Int32.TryParse(partAddMachineID.Text, out int c);
            bool testpartCompanyName = (partAddCompanyName.Text != "");
            bool testpartName = (partAddPartName.Text != "");
            bool testResult;


            if (addPartInhouseRadio.Checked == true)
            {
                testResult = (testpartPrice && testpartInventory && testpartMin && testpartMax && testpartMachineID && testpartName);
            }
            else
            {
                testResult = (testpartPrice && testpartInventory && testpartMin && testpartMax && testpartCompanyName);
            }

            if (testResult)
            {

               
                int partID = Int32.Parse(partAddPartID.Text);
                string partName = partAddPartName.Text;
                decimal price = Decimal.Parse(partAddPrice.Text);
                int partStock = Int32.Parse(partAddInventory.Text);
                int partMin = Int32.Parse(partAddMin.Text);
                int partMax = Int32.Parse(partAddMax.Text);

                if (partStock > partMax)
                {
                    MessageBox.Show("Current inventory level should not be greater than the maximum, please enter a valid input for either Inventory Level or Maximum Inventory.");
                    partAddMax.BackColor = Color.Red;
                    partAddInventory.BackColor = Color.Red;
                }

                if (partStock < partMin)
                {
                    MessageBox.Show("Current inventory level should not be less than the minimum, please enter a valid input for either Inventory Level or Minimum Inventory.");
                    partAddMin.BackColor = Color.Red;
                    partAddInventory.BackColor = Color.Red;
                }


                if (addPartInhouseRadio.Checked == true && partAddMachineID.Text != "") //need to insert a try catch to handle blank required fields
                {
                    int machineID = Int32.Parse(partAddMachineID.Text);
                    Inhouse newPart = new Inhouse(partID, partName, price, partStock, partMin, partMax, machineID);
                    Inventory.addPart(newPart);
                    Close();

                }
                else if (addPartInhouseRadio.Checked == true && partAddMachineID.Text == "")
                {
                    MessageBox.Show("Please enter a valid input for Machine ID.");
                }
                else if (addPartOutsourcedRadio.Checked == true && partAddCompanyName.Text == "")
                {
                    MessageBox.Show("Please enter a valid input for Company Name.");
                }
                else
                {
                    string companyName = partAddCompanyName.Text;
                    Outsourced newPart = new Outsourced(partID, partName, price, partStock, partMin, partMax, companyName);
                    Inventory.addPart(newPart);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid entries detected, please correct the highlighted fields and resubmit.");
                
                if (!testpartInventory)
                {
                    partAddInventory.BackColor = Color.Red;
                }
                if (!testpartName)
                {
                    partAddPartName.BackColor = Color.Red;
                }
                if (!testpartMax)
                {
                    partAddMax.BackColor = Color.Red;
                }
                if (!testpartMin)
                {
                    partAddMin.BackColor = Color.Red;
                }
                if (!testpartCompanyName)
                {
                    partAddCompanyName.BackColor = Color.Red;
                }
                if(addPartInhouseRadio.Checked == true && !testpartMachineID)
                {
                    partAddMachineID.BackColor = Color.Red;
                }
                if(addPartOutsourcedRadio.Checked == true && !testpartCompanyName)
                {
                    partAddCompanyName.BackColor = Color.Red;
                }
            }
                
            
        }

        public void partAddOutsourcedRadioButton_Click(object sender, EventArgs e)
        {
            addPartOutsourcedRadio.Checked = true;
            partAddMachineID.Clear();
            partAddMachineID.Enabled = false;
            partAddMachineID.ReadOnly = true;
            partAddCompanyName.ReadOnly = false;
            partAddCompanyName.Enabled = true;
        }

        public void partAddInHouseRadioButtong_Click(object sender, EventArgs e)
        {
            addPartInhouseRadio.Checked = true;
            partAddCompanyName.Clear();
            partAddCompanyName.Enabled = false;
            partAddCompanyName.ReadOnly = true;
            partAddMachineID.ReadOnly = false;
            partAddMachineID.Enabled = true;

        }

        public void partAddCancelButton_Click(object sender, EventArgs e) //event handler for cancel button on AddPart form
        {
            Close(); //closes the currently active form
        }
    }
}
