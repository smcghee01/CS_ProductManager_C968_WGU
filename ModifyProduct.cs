using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager;
using InventoryManager;
using InhousePart;
using OutsourcedPart;
using HomePage;
using AddProduct;

namespace ModifyProduct
{
    
    public partial class modifyProdForm : Form
    {
        public BindingList<Part> tempAssociatedParts = new BindingList<Part>(); //setting up temporary binding list 

        Product modProd; //temporary product to store info to use as input for UpdateProduct method.
        public modifyProdForm(Product prod)
        {
            InitializeComponent();
            // modProdID.prod.ProductID; //need to figure out how to pull information from the previously selected part on the Home page

            modProdID.Text = prod.ProductID.ToString();
            modProdName.Text = prod.Name;
            modProdInvLvl.Text = prod.InStock.ToString();
            modProdMax.Text = prod.Max.ToString();
            modProdMin.Text = prod.Min.ToString();
            modProdPrice.Text = prod.Price.ToString();

            modProd = prod;

            prodModAllPartsGrid.DataSource = Inventory.AllParts;
            modProdAssociatedPartsGrid.DataSource = tempAssociatedParts;

            foreach( Part part in prod.AssociatedParts)
            {
                tempAssociatedParts.Add(part);
            }


            modProdAssociatedPartsGrid.Refresh();
            modProdID.ReadOnly = true;
            
            
        }

        private void ModProdCancelButton_Click(object sender, EventArgs e) //COMPLETE
        {
            tempAssociatedParts.Clear(); //clears all items from the temporary parts list
            modifyProdForm.ActiveForm.Close(); //closes the modify product form

        }

        private void ModProdSearchButton_Click(object sender, EventArgs e) //COMPLETE: appears to be complete, searches for the corresponding part in the all parts grid and selects it
        {
            prodModAllPartsGrid.Refresh();

            if (prodModAssociatedPartSearch.Text != "")
            {
                for (int i = 0; i < prodModAllPartsGrid.RowCount; i++)
                {
                    if (Int32.Parse(prodModAssociatedPartSearch.Text.ToString()) == Int32.Parse(prodModAllPartsGrid.Rows[i].Cells[0].Value.ToString()))
                    {
                        prodModAllPartsGrid.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Part ID");
            }
        }

        private void ModProdSaveButton_Click(object sender, EventArgs e) //need to make a loop or list of if statements to go through and highlight the text boxes 
        {

            modProdPrice.BackColor = Color.White;
            modProdInvLvl.BackColor = Color.White;
            modProdMin.BackColor = Color.White;
            modProdMax.BackColor = Color.White;
            modProdName.BackColor = Color.White;

            bool testprodPrice = Decimal.TryParse(modProdPrice.Text, out decimal y);
            bool testprodInventory = Int32.TryParse(modProdInvLvl.Text, out int z);
            bool testprodMin = Int32.TryParse(modProdMin.Text, out int a);
            bool testprodMax = Int32.TryParse(modProdMax.Text, out int b);
            bool testprodName = (modProdName.Text != "");

            bool testResult = (testprodPrice && testprodInventory && testprodMin && testprodMax);

            if(testResult)
            {
                int prodID = Int32.Parse(modProdID.Text);
                string prodName = modProdName.Text;
                int prodInventory = Int32.Parse(modProdInvLvl.Text);
                int prodMax = Int32.Parse(modProdMax.Text);
                int prodMin = Int32.Parse(modProdMin.Text);
                decimal prodPrice = Decimal.Parse(modProdPrice.Text);

                if (prodInventory > prodMax)
                {
                    MessageBox.Show("Current inventory level should not be greater than the maximum, please enter a valid input for either Inventory Level or Maximum Inventory.");
                    modProdMax.BackColor = Color.Red;
                    modProdInvLvl.BackColor = Color.Red;
                }
                if (prodInventory < prodMin)
                {
                    MessageBox.Show("Current inventory level should not be less than the minimum, please enter a valid input for either Inventory Level or Minimum Inventory");
                    modProdMin.BackColor = Color.Red;
                    modProdInvLvl.BackColor = Color.Red;
                }

                Product tempProd = new Product(prodID, prodName, prodPrice, prodInventory, prodMin, prodMax);

                modProd.AssociatedParts.Clear(); //clearing associated parts on current product

                foreach (Part part in tempAssociatedParts) //adding all values set in the temporary Associated Parts List to the parts list on the product
                {
                    modProd.AssociatedParts.Add(part);
                }

                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (prodID == Inventory.Products[i].ProductID)
                    {
                        Inventory.updateProduct(prodID, tempProd);
                        break;
                    }
                }

                Close();
            }
            else
            {
                MessageBox.Show("Invalid entries detected, please correct the highlighted fields and resubmit.");
                if (!testprodPrice)
                {
                    modProdPrice.BackColor = Color.Red;
                }
                if (!testprodInventory)
                {
                    modProdInvLvl.BackColor = Color.Red;
                }
                if (!testprodMin)
                {
                    modProdMin.BackColor = Color.Red;
                }
                if (!testprodMax)
                {
                    modProdMax.BackColor = Color.Red;
                }
                if (!testprodName)
                {
                    modProdName.BackColor = Color.Red;
                }
            }

        }

        private void ModProdAddPartButton_Click(object sender, EventArgs e)//COMPLETE: need to add rows from AllPartsGrid to the temporary parts list
        {
            if (prodModAllPartsGrid.SelectedRows != null)
            {

                //modProdAssociatedPartsGrid.Rows.Add(prodModAllPartsGrid.SelectedRows); //need to pull out the part number
                
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID == Int32.Parse(prodModAllPartsGrid.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        tempAssociatedParts.Add(Inventory.AllParts[i]); //Select says it has more than 1 argument?
                        modProdAssociatedPartsGrid.Refresh(); //refreshes grid view
                    }
                }
            }
            else if (prodModAssociatedPartSearch == null)
            {
                MessageBox.Show("Please enter a valid Part ID");
            }
        }

        private void ModProdDeletePartButton_Click(object sender, EventArgs e) //COMPLETE
        {
            if (modProdAssociatedPartsGrid.SelectedRows != null)
            {
                for (int i = 0; i < tempAssociatedParts.Count; i++)
                {
                    if (Int32.Parse(modProdAssociatedPartsGrid.SelectedRows[0].Cells[0].Value.ToString()) == tempAssociatedParts[i].PartID)
                    {
                        tempAssociatedParts.RemoveAt(i);
                        MessageBox.Show("Associated part successfully removed.");
                        modProdAssociatedPartsGrid.Refresh();
                    }
                }

            }
            else if (modProdAssociatedPartsGrid.SelectedRows == null)
            {
                MessageBox.Show("Please select a product from the Associated Parts Grid to remove.");
            }
        }
    }
}
