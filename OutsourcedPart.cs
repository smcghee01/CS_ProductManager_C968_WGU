using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsourcedPart //namespace for class Outsourced
{
    
	public class Outsourced : Part //declaring class Outsourced with the "is-a" relationship to Part
    {
        public string CompanyName { get; set; } //adding Company Name, does not replace anything as far as I can tell

        public Outsourced(int partID, string partName, decimal partPrice, int partInStock, int partMin, int partMax, string companyName) : base(partID, partName, partPrice, partInStock, partMin, partMax)
        {
            CompanyName = companyName; //assigning input parameter companyName as the value for variable CompanyName

        }

		
    }
	
}
