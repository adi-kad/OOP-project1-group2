using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    sealed class CommonRoom
    {
        /* 
        CommonRoom is the class that handles the "big room" of the facility. 
        Has a List that stores all created Training tools in that room
        Has methods to add, remove and modify the state of the training tool (broken or not)
        */
    
        private List<TrainingTool> _trainingTools; 

        public CommonRoom()
        {
            _trainingTools = new List<TrainingTool>();
        }

        public void addTrainingTool(int id, string type)
        {
            _trainingTools.Add(new TrainingTool(id, type));
        }

        public void removeTrainingTool(int toolId)
        {            
            for (int i = 0; i < _trainingTools.Count; i++)
            {   
                if (_trainingTools[i].getToolId() == toolId)
                {
                    _trainingTools.RemoveAt(i);
                }
            }           
        }
        
        public List<TrainingTool> getTrainingTools()
        {
            return _trainingTools;
        }

        public void setTrainingToolStatus(int toolId, bool isBroken)
        {
            for (int i = 0; i < _trainingTools.Count; i++)
            {   
              if (_trainingTools[i].getToolId() == toolId)
                {
                    _trainingTools[i].setTrainingToolStatus(isBroken);
                } 
            }           
        }

    }
}