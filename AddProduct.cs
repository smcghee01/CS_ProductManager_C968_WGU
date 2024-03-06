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
using PartForm;

namespace AddProduct
{
    public partial class AddProductForm : Form
    {

        public BindingList<Part> tempAssociatedParts = new BindingList<Part>(); //COMPLETE: setting up temporary binding list

        public DataGridViewRow addProdGrid;

        public Part tempPart;

        public AddProductForm()
        {
            InitializeComponent();

            prodAddAllPartsGrid.DataSource = Inventory.AllParts;
            partProdAssociationGrid.DataSource = tempAssociatedParts;

            prodAddAllPartsGrid.Columns[0].Name = "Part ID";
            prodAddAllPartsGrid.Columns[0].ValueType = typeof(int);
            prodAddAllPartsGrid.Columns[1].Name = "Part Name";
            prodAddAllPartsGrid.Columns[1].ValueType = typeof(string);
            prodAddAllPartsGrid.Columns[2].Name = "Price";
            prodAddAllPartsGrid.Columns[2].ValueType = typeof(decimal);
            prodAddAllPartsGrid.Columns[3].Name = "Inventory";
            prodAddAllPartsGrid.Columns[3].ValueType = typeof(int);

            partProdAssociationGrid.Columns[0].Name = "Part ID";
            partProdAssociationGrid.Columns[0].ValueType = typeof(int);
            partProdAssociationGrid.Columns[1].Name = "Part Name";
            partProdAssociationGrid.Columns[1].ValueType = typeof(string);
            partProdAssociationGrid.Columns[2].Name = "Price";
            partProdAssociationGrid.Columns[2].ValueType = typeof(string);
            partProdAssociationGrid.Columns[3].Name = "Inventory";
            partProdAssociationGrid.Columns[3].ValueType = typeof(int);



            
            if(Inventory.Products.Count == 0)
            {
                addProdID.Text = Inventory.Products.Count.ToString();
            }
            else
            {
                addProdID.Text = (Inventory.Products.Last().ProductID + 1).ToString();
            }

            

        }

        private void ProdAddSearchButton_Click(object sender, EventArgs e) //COMPLETE: searches for the part number in the search box after refreshing the all parts grid and selects it
        {
            prodAddAllPartsGrid.Refresh();
            
            if (partAddSearch.Text != "")
            {
                for (int i = 0; i < prodAddAllPartsGrid.RowCount; i++)
                {
                    if (Int32.Parse(partAddSearch.Text.ToString()) == Int32.Parse(prodAddAllPartsGrid.Rows[i].Cells[0].Value.ToString()))
                    {
                        prodAddAllPartsGrid.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Part ID");
            }
        }

        private void ProdAddSaveButton_Click(object sender, EventArgs e) //COMPELTE: assigns the inputted values to variables, loops through the temporary list to add to the product's associated list, then adds the product to the product list
        {
            /*for(int i = 0; i < partProdAssociationGrid.RowCount; i++)
            {
                for(int p = 0; p < Inventory.AllParts.Count; p++)
                {

                    if (Int32.Parse(partProdAssociationGrid.Rows[i].Cells[0].Value.ToString()) == Inventory.AllParts[p].PartID)
                    { 
                        tempPart = Inventory.AllParts[p];
                        break;
                    }
                }
                tempAssociatedParts.Add(tempPart);
            }*/

            addProdPrice.BackColor = Color.White;
            addProdInventory.BackColor = Color.White;
            addProdMin.BackColor = Color.White;
            addProdMax.BackColor = Color.White;
            addProdName.BackColor = Color.White;
                
            bool testprodPrice = Decimal.TryParse(addProdPrice.Text, out decimal y);
            bool testprodInventory = Int32.TryParse(addProdInventory.Text, out int z);
            bool testprodMin = Int32.TryParse(addProdMin.Text, out int a);
            bool testprodMax = Int32.TryParse(addProdMax.Text, out int b);
            bool testprodName = (addProdName.Text != "");

            bool testResult = (testprodPrice && testprodInventory && testprodMin && testprodMax);
                
            if (testResult)
            {

                int prodID = Int32.Parse(addProdID.Text);
                string prodName = addProdName.Text;
                decimal prodPrice = Decimal.Parse(addProdPrice.Text);
                int prodInventory = Int32.Parse(addProdInventory.Text);
                int prodMin = Int32.Parse(addProdMin.Text);
                int prodMax = Int32.Parse(addProdMax.Text);

                if(prodInventory > prodMax)
                {
                    MessageBox.Show("Current inventory level should not be greater than the maximum, please enter a valid input for either Inventory Level or Maximum Inventory.");
                    addProdMax.BackColor = Color.Red;
                    addProdInventory.BackColor = Color.Red;
                }
                if(prodInventory < prodMin)
                {
                    MessageBox.Show("Current inventory level should not be less than the minimum, please enter a valid input for either Inventory Level or Minimum Inventory");
                    addProdMin.BackColor = Color.Red;
                    addProdInventory.BackColor = Color.Red;
                }

                Product newProd = new Product(prodID, prodName, prodPrice, prodInventory, prodMin, prodMax);

                foreach (Part part in tempAssociatedParts)
                {
                    newProd.AssociatedParts.Add(part);
                }

                Inventory.addProduct(newProd);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid entries detected, please correct the highlighted fields and resubmit.");
                if (!testprodPrice)
                {
                    addProdPrice.BackColor = Color.Red;
                }
                if (!testprodInventory)
                {
                    addProdInventory.BackColor = Color.Red;
                }
                if (!testprodMin)
                {
                    addProdMin.BackColor = Color.Red;
                }
                if (!testprodMax)
                {
                    addProdMax.BackColor = Color.Red;
                }
                if (!testprodName)
                {
                    addProdName.BackColor = Color.Red;
                }
            }           
        }
            
        private void ProdAddPartButton_Click(object sender, EventArgs e) //COMPLETE: adds selected products to the associated part grid after checking the selection is not null, then adds that part from the all parts list to the temp associated parts list
        {

            if (prodAddAllPartsGrid.SelectedRows != null) //makes sure the user has selected a row
            {

                //partProdAssociationGrid.Rows.Add(prodAddAllPartsGrid.SelectedRows); //adds the selected row to the Associated Parts Grid

                for (int p = 0; p < Inventory.AllParts.Count; p++) //loops the grid part ID through Inventory All Parts to find the specific part and adds that part to the temporary list
                {

                    if (Int32.Parse(prodAddAllPartsGrid.SelectedRows[0].Cells[0].Value.ToString()) == Inventory.AllParts[p].PartID)
                    {
                        tempPart = Inventory.AllParts[p];
                        tempAssociatedParts.Add(tempPart);
                        break;
                    }

                }

            }  else if (prodAddAllPartsGrid.SelectedRows == null) //outputs a message box if the user has not selected anything
            {
                MessageBox.Show("Please select a part to add.");
            }  
            

            partProdAssociationGrid.Refresh(); //refreshes the associated part grid view after adding the new row.

        }

        private void ProdDeletePartButton_Click(object sender, EventArgs e) //COMPLETE: removes the selected row from the Associated Parts grid
        {
            if(partProdAssociationGrid.SelectedRows != null)
            {
                for(int i = 0; i < tempAssociatedParts.Count; i++)
                {
                    if (Int32.Parse(partProdAssociationGrid.SelectedRows[0].Cells[0].Value.ToString()) == tempAssociatedParts[i].PartID)
                    {
                        tempAssociatedParts.RemoveAt(i);
                        MessageBox.Show("Associated part successfully removed.");
                        partProdAssociationGrid.Refresh();
                    }
                }               
                
            }
            else if (partProdAssociationGrid.SelectedRows == null)
            {
                MessageBox.Show("Please select a product from the Associated Parts Grid to remove.");
            }
        }

        private void ProdAddCancelButton_Click(object sender, EventArgs e) //COMPLETE: clears the temporary list and closes the form
        {
            tempAssociatedParts.Clear(); //clears all items from the temporary parts list
            Close(); //closes the currently active form (Product Add)
        }


    }
}
