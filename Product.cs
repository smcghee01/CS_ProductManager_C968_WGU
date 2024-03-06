using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using InhousePart;


/// <summary>
/// Summary description for Class1
/// </summary>

namespace ProductManager
{
	public class Product
	{
		public int ProductID { get; set; } //auto-implemented ProductID property
		public string Name { get; set; } //auto-implemented Name property
		public decimal Price { get; set; } //auto-implemented Price property
		public int InStock { get; set; } //auto-implemented InStock property
		public int Min { get; set; } //auto-implemented Min property
		public int Max { get; set; } //auto-implemented Max property

		public Product (int prodID, string prodName, decimal prodPrice, int prodInventory, int prodMin, int prodMax) //Product constructor
		{
			ProductID = prodID;
			Name = prodName;
			Price = prodPrice;
			InStock = prodInventory;
			Min = prodMin;
			Max = prodMax;

		}

		public BindingList<Part> AssociatedParts = new BindingList<Part>();//create a binding list of parts associated to the product


		public void InstantiateAssociatedParts()
		{


			AssociatedParts.AllowEdit = true; //allows the list AssociatedParts to be edited
			AssociatedParts.AllowNew = true; //allows items to be added to list AssociatedParts
			AssociatedParts.AllowRemove = true;  //allows items to be removed from list AssociatedParts

		}

		public void AddAssociatedPart(Part addpartname)
		{
			AssociatedParts.Add(addpartname);
		}

		public bool RemoveAssociatedPart(Part removepartname)
		{
				
			AssociatedParts.Remove(removepartname); //remove part number from list				

            if (AssociatedParts.Contains(removepartname) == false)
            {
                return true; //returns true if the value does not exist - removal failed
            }

            return false; // returns false if the value does exist - removal failed
			
		}

		public Part LookupAssocaiatedPart(int partnumber) //pass an int PartID to return an object
		{
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartID == partnumber)
                    return AssociatedParts[i];
            }

            return null; //returning the looked-up product
        }

	}
}
