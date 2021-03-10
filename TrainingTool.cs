using System;

namespace OOP_project1_group2
{
	class TrainingTool : Bookable
	{
		private bool broken;
		
		public TrainingTool(int id, string type) : base(id, type)
		{
			this.broken = false;
		}
	}
}