using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Part //declaring class Part which is the base class for classes Outsourced and Inhouse
{
	public int PartID { get; set; } //auto-implemented PartID property
	public string Name { get; set; } //auto-implemented Name property
	public decimal Price { get; set; } //auto-implemented Price property
	public int InStock { get; set; } //auto-implemented InStock property
	public int Min { get; set; } //auto-implemented Min property
	public int Max { get; set; } //auto-implemented Max property

	public Part(int partID, string partName, decimal partPrice, int partInStock, int partMin, int partMax) //not sure that I need this, part classes should be either Outsourced or Inhouse which means a cosntructor here may not be necessary
    {
		PartID = partID; //assigning each of the input parameters to the corresponding declared variables
		Name = partName;
		Price = partPrice;
		InStock = partInStock;
		Min = partMin;
		Max = partMax;
    }
}
