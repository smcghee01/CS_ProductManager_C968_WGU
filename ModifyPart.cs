using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManager;
using InhousePart;
using OutsourcedPart;
using ModifyProduct;
using System.Diagnostics.Eventing.Reader;

namespace ModifyPart
{
    public partial class modifyPartForm : Form
    {
        public modifyPartForm(Part part) //need to input all of the Part fields/properties into the text boxes of the Mod Part form
        {
            InitializeComponent();
            modPartID.Text = part.PartID.ToString();
            modPartName.Text = part.Name;
            modPartInventory.Text = part.InStock.ToString();
            modPartMax.Text = part.Max.ToString();
            modPartMin.Text = part.Min.ToString();
            modPartPrice.Text = part.Price.ToString();

            modPartID.ReadOnly = true;
            modPartID.Enabled = false;

            if(part is Inhouse) //need to test whether this Part is an Inhouse or Outsourced Part
            {
                modPartMachineID.Text = ((Inhouse)part).MachineID.ToString(); //if true, cast the part as Inhouse to be able to access Machine ID
                modPartInhouse.Checked = true;
                modPartCompanyName.Enabled = false;
                modPartOutsourced.Enabled = false;
            }
            else
            {
                modPartCompanyName.Text = ((Outsourced)part).CompanyName; //if false, acst the part as Outsourced and fill in the associated fields
                modPartOutsourced.Checked = true;
                modPartMachineID.Enabled = false;
                modPartInhouse.Enabled = false;
            }                                  

        }



        private void modPartSaveButton_Click(object sender, EventArgs e) //save button event
        {

            modPartName.BackColor = Color.White;
            modPartInventory.BackColor = Color.White;
            modPartPrice.BackColor = Color.White;
            modPartMin.BackColor = Color.White;
            modPartMax.BackColor = Color.White;
            modPartMachineID.BackColor = Color.White;
            modPartCompanyName.BackColor = Color.White;

            bool testpartPrice = Decimal.TryParse(modPartPrice.Text, out decimal y);
            bool testpartInventory = Int32.TryParse(modPartInventory.Text, out int z);
            bool testpartMin = Int32.TryParse(modPartMin.Text, out int a);
            bool testpartMax = Int32.TryParse(modPartMax.Text, out int b);
            bool testpartMachineID = Int32.TryParse(modPartMachineID.Text, out int c);
            bool testpartName = (modPartName.Text != "");
            bool testCompanyName = (modPartCompanyName.Text != "");

            bool testResult;

            if (modPartInhouse.Checked == true)
            {
                testResult = (testpartPrice && testpartInventory && testpartMin && testpartMax && testpartName && testpartMachineID);
            }
            else
            {
                testResult = (testpartPrice && testpartInventory && testpartMin && testpartMax && testpartName && testCompanyName);
            }

            if(testResult)
            {
                int tempPartID = Int32.Parse(modPartID.Text); //creates temporary variables to store the form information
                string tempPartName = modPartName.Text;
                int tempPartInventory = Int32.Parse(modPartInventory.Text);
                int tempPartMax = Int32.Parse(modPartMax.Text);
                int tempPartMin = Int32.Parse(modPartMin.Text);
                decimal tempPartPrice = Decimal.Parse(modPartPrice.Text);
                int tempPartMachineID = Int32.Parse(modPartMachineID.Text);
                string tempPartCompanyName = modPartCompanyName.Text;

                if(tempPartInventory > tempPartMax)
                {
                    MessageBox.Show("Current inventory level should not be greater than the maximum, please enter a valid input for either Inventory Level or Maximum Inventory.");
                    modPartMax.BackColor = Color.Red;
                    modPartInventory.BackColor = Color.Red;
                }

                if(tempPartInventory < tempPartMin)
                {
                    MessageBox.Show("Current inventory level should not be less than the minimum, please enter a valid input for either Inventory Level or Minimum Inventory.");
                    modPartMin.BackColor = Color.Red;
                    modPartInventory.BackColor = Color.Red;
                }


                for (int i = 0; i < Inventory.AllParts.Count; i++) //checks and removes the matching item from the AllParts list
                {
                    if (tempPartID == Inventory.AllParts[i].PartID)
                    {
                        Inventory.AllParts.RemoveAt(i);
                        break;
                    }
                }

                if (modPartInhouse != null) //checks whether the part is Inhouse or Outsourced and creates the corresponding Part derived class object
                {
                    Inhouse tempPart = new Inhouse(tempPartID, tempPartName, tempPartPrice, tempPartInventory, tempPartMin, tempPartMax, tempPartMachineID);
                    Inventory.addPart(tempPart);
                }
                else if (modPartOutsourced.Text != "")
                {
                    Outsourced tempPart = new Outsourced(tempPartID, tempPartName, tempPartPrice, tempPartInventory, tempPartMin, tempPartMax, tempPartCompanyName);
                    Inventory.addPart(tempPart);

                }

                Close();
            }
            else 
            {
                MessageBox.Show("Invalid entries detected, please correct the highlighted fields and resubmit.");

                if (!testpartInventory)
                {
                    modPartInventory.BackColor = Color.Red;
                }
                if (!testpartName)
                {
                    modPartName.BackColor = Color.Red;
                }
                if (!testpartMax)
                {
                    modPartMax.BackColor = Color.Red;
                }
                if (!testpartMin)
                {
                    modPartMin.BackColor = Color.Red;
                }
                if (!testCompanyName)
                {
                    modPartCompanyName.BackColor = Color.Red;
                }
                if (modPartInhouse.Checked == true && !testpartMachineID)
                {
                    modPartMachineID.BackColor = Color.Red;
                }
                if (modPartOutsourced.Checked == true && !testCompanyName)
                {
                    modPartCompanyName.BackColor = Color.Red;
                }
            }
        }


        private void modPartCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
