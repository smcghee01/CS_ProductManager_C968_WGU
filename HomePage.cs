using System;
using InventoryManager;
using InhousePart;
using OutsourcedPart;
using ProductManager;
using PartForm;
using AddProduct;
using ModifyPart;
using ModifyProduct;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace HomePage
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            homePartDataGrid.DataSource = Inventory.AllParts;
            homeProdDataGrid.DataSource = Inventory.Products;

            homePartDataGrid.AutoGenerateColumns = false;
            homeProdDataGrid.AutoGenerateColumns = false;

            homePartDataGrid.Columns[0].Name = "Part ID";
            homePartDataGrid.Columns[0].ValueType = typeof(int);
            homePartDataGrid.Columns[1].Name = "Part Name";
            homePartDataGrid.Columns[1].ValueType = typeof(string);
            homePartDataGrid.Columns[2].Name = "Price";
            homePartDataGrid.Columns[2].ValueType = typeof(decimal);
            homePartDataGrid.Columns[3].Name = "Inventory";
            homePartDataGrid.Columns[3].ValueType = typeof(int);

            homeProdDataGrid.Columns[0].Name = "Part ID";
            homeProdDataGrid.Columns[0].ValueType = typeof(int);
            homeProdDataGrid.Columns[1].Name = "Part Name";
            homeProdDataGrid.Columns[1].ValueType = typeof(string);
            homeProdDataGrid.Columns[2].Name = "Price";
            homeProdDataGrid.Columns[2].ValueType = typeof(string);
            homeProdDataGrid.Columns[3].Name = "Inventory";
            homeProdDataGrid.Columns[3].ValueType = typeof(int);

        }

        private void homeProdAddButton_Click(object sender, EventArgs e) //event handler for Add button being clicked with one of the text fields containing text
        { 
                AddProductForm addProd = new AddProductForm(); //creating the new Add Product form
                addProd.ShowDialog(); //brings up the new Add Prod form
        }

        private void homePartAddButton_Click(object sender, EventArgs e)
        {
            AddPartForm addPart = new AddPartForm();
            addPart.ShowDialog();
        }

        private void homeProdModifyButton_Click(object sender, EventArgs e)
        {

            if (homeProdDataGrid.SelectedRows != null)
            {

                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    int productID = Int32.Parse(homeProdDataGrid.SelectedRows[0].Cells[0].Value.ToString());

                    if (Inventory.Products[i].ProductID == productID)
                    {
                        modifyProdForm modifyProd = new modifyProdForm(Inventory.Products[i]); //creating the new Modify Product form by passing the selected object to i         
                        modifyProd.ShowDialog(); //brings up the new Add Prod form
                        break;
                    }
                }

            }
            else //if no value is input in either text box, a message box will show requesting an input
            {
                MessageBox.Show("Please select a Product to modify in the Product List.");
            }
        }

        private void homePartModifyButton_Click(object sender, EventArgs e) //INCOMPLETE: Need to find out how to get Machine ID and Company Name from the Parts list
        {

            if (homePartDataGrid.SelectedRows != null) //passes Part ID of the part to be modified to the Modify Part form with the Part ID text box filled in
            {
                int partID = Int32.Parse(homePartDataGrid.SelectedRows[0].Cells[0].Value.ToString());

                homeProdDataGrid.Refresh();

                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID == partID)
                    {
                        modifyPartForm modifyPart = new modifyPartForm(Inventory.AllParts[i]); //creating the new Modify Product form by passing the selected object to it
                        modifyPart.ShowDialog(); //brings up the new Add Prod form
                        break;
                    }
                }
            }
            else //if no value is input in either text box, a message box will show requesting an input
            {
                MessageBox.Show("Please select a Part to modify in the Part List.");
            }
        }

        private void homeExitButton_Click(object sender, EventArgs e) //COMPLETE        
        {    
            Application.Exit(); //Exits the application
        }

        private void homeProdSearchButton_Click(object sender, EventArgs e) //COMPLETE: looks up the product number from the text box after refreshing the list box and selects the index
        {
            homeProdDataGrid.Refresh();

            if (homeProdTextBox.Text != "")
            {
                for (int i = 0; i < homeProdDataGrid.RowCount; i++)
                {
                    if (Int32.Parse(homeProdTextBox.Text.ToString()) == Int32.Parse(homeProdDataGrid.Rows[i].Cells[0].Value.ToString()))
                    {
                        homeProdDataGrid.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else if (homeProdTextBox == null || homeProdDataGrid.Text.Contains(homeProdTextBox.Text) == false)
            {
                MessageBox.Show("Please enter a valid Part ID");
            }
        }

        private void homePartSearchButton_Click(object sender, EventArgs e) //COMPLETE: looks up part given part number after refreshing the list box and selects it
        {
            homePartDataGrid.Refresh();

            if (homePartTextBox.Text != "")
            {
                for (int i = 0; i < homePartDataGrid.RowCount; i++)
                {
                    if (Int32.Parse(homePartTextBox.Text.ToString()) == Int32.Parse(homePartDataGrid.Rows[i].Cells[0].Value.ToString()))
                    {
                        homePartDataGrid.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            else if (homePartTextBox.Text == "" || homePartDataGrid.Text.Contains(homePartTextBox.Text) == false)
            {
                MessageBox.Show("Please enter a valid Part ID");
            }
        }  

        private void homePartDeleteButton_Click(object sender, EventArgs e) //event handler to delete product or part object from the list
        {
                    
            Inventory.AllParts.RemoveAt(Int32.Parse(homePartDataGrid.SelectedRows[0].Index.ToString()));
            MessageBox.Show("Part successfully deleted.");
            homePartDataGrid.Refresh();
        }

        private void homeProdDeleteButton_Click(object sender, EventArgs e) //event handler to delete product or part object from the list
        {

            if (Inventory.Products[Int32.Parse(homeProdDataGrid.SelectedRows[0].Index.ToString())].AssociatedParts.Count > 0)
            {
                MessageBox.Show("Unable to delete product, please remove associated parts from the product's list and try again.");
            }
            else
            {
                Inventory.removeProduct(Int32.Parse(homeProdDataGrid.SelectedRows[0].Index.ToString()));
                homeProdDataGrid.Refresh();
            }
            
        }
    }
}
