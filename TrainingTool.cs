using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
	class TrainingTool : Bookable
	{
		/* 
        Inherits from the Bookable class
		The class that represent every training tool object the administrator adds to the facility
		Every object will contain id, type and a broken state (bool)
		If a TrainingTool is set to true on broken, the object will be non bookable.
        */

		private bool broken;
		
		public TrainingTool(int id, string type) : base(id, type)
		{
			this.broken = false;
			this.maxCapacity = 1;
		}

		public int getToolId()
		{
			return this.id;
		}

		public bool getToolStatus()
		{
			return this.broken;
		}		

		public void setTrainingToolStatus(bool isBroken)
		{
			this.broken = isBroken;
		}
		
	}
}