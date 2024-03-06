using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using InhousePart;
using ProductManager;
using OutsourcedPart;
using System.Windows.Forms;

namespace InventoryManager
{
    public class Inventory
    {

        
        public static BindingList<Product> Products = new BindingList<Product>(); //create a binding list for all products

        

        public static BindingList<Part> AllParts = new BindingList<Part>(); //create a binding list for all parts


        public static void InstantiateProducts()
        {
           
            Products.AllowEdit = true; //allow items in the list Products to be edited
            Products.AllowNew = true; //allow new items to be added to the list
            Products.AllowRemove = true; //allow items to be removed from the list
        }

        public static BindingList<Product> getProductList() //get method for Products list
        {
            return Products;
        }

        public static BindingList<Part> getAllPartsList() //get method for AllParts bound list
        {
            return AllParts;

        }
        public static void instantiateAllParts()
        {

            AllParts.AllowEdit = true; //allow items in the list AllParts to be edited
            AllParts.AllowNew = true; //allow items to be added to the list AllParts
            AllParts.AllowRemove = true; //allow items to be removed from the list AllParts
        }
        public static void addProduct(Product addProd) //adding product object to BindingList<Product>
        {
            Products.Add(addProd);
        }

        public static bool removeProduct(int prodID) //removing a product given the ProductID
        {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ProductID == prodID)
                    {
                        Products.Remove(Products[i]);
                        MessageBox.Show("Product sucessfully removed.");
                        return true; //returns true to indicate the product's deletion from the list
                        
                    }
                 }
            MessageBox.Show("Product not sucessfully removed.");
            return false; //returns false if the removal process was unsuccessful

        }
        public static bool removePart(int partID) //removing a part given the ProductID
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partID)
                {
                    AllParts.Remove(AllParts[i]);
                    return true; //returns true to indicate the part's deletion from the list
                }
            }
            return false; //returns false if the removal process was unsuccessful
        }

        public static Product lookupProduct(int lookupID) //looking up a product given a ProductID
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == lookupID)
                    return Products[i];
            }

            return null; //returning the looked-up product

        }

        public static Part lookupPart(int lookupID) //looking up a product given a ProductID
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == lookupID)
                    return AllParts[i];
            }

            return null; //returning the looked-up product

        }

        public static void updateProduct(int prodNum, Product prodObject) //objective - replace product object at index with prodObject input
        { 
            for(int i = 0; i < Products.Count; i++) //for loop to find the index of the input ProductID
            {
                if (Products[i].ProductID == prodNum) //validating the ProductID at the current index equals the input paramater
                {
                    Products[i] = prodObject; //replaces current object with the newly modified product info
                }

            }
                                       
        }                              


        public static void addPart(Part addNum) //adding a Part object to BindingList<Part>
        {

            AllParts.Add(addNum); //add parts to the AllParts binding list
        }

    }
}

