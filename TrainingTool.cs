using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
	class TrainingTool : Bookable
	{
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