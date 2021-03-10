using System;
using System.Collections.Generic;

namespace OOP_project1_group2
{
    sealed class CommonRoom
    {
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
             _trainingTools.Remove(tool => tool.id == toolId).FirstOrDefault();
        }

        public List<int> getTrainingTools()
        {
            return _trainingTools;
        }

        public void setTrainingToolStatus(int toolId, bool isBroken)
        {
           TrainingTool tool = _trainingTools.Where(tool => tool.id == toolId).FirstOrDefault();
           tool.status = isBroken;
        }

    }
}