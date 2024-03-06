using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

//namespace for class Inhouse which has an "is-a" relationship with class Part

namespace InhousePart
{


	public class Inhouse : Part //declaring public class Inhouse and the inheritance from class Part
	{
		public int MachineID { get; set; } //auto - implemented MachineID property 


		public Inhouse(int partID, string partName, decimal partPrice, int partInStock, int partMin, int partMax, int machineID) : base(partID, partName, partPrice, partInStock, partMin, partMax) //constructor with paramters to instantiate Inhouse along with declaring the relationship to Part
        {
			MachineID = machineID; //setting variable MachineID equal to the input parameter machineID
        }
		
		
		
	}

	
	
}