using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlantApplication.Model;

namespace PlantApplication.Services
{
    public class PlantInfoServices : IPantInfoService
    {
        private readonly List<PlantStatusModel> plantsInfo;

        public PlantInfoServices()
        {
            plantsInfo = new List<PlantStatusModel>
            {
                new PlantStatusModel
                {
                    PlantName = "Plant A",
                    PlantWateringStatus = "Not Watering"
                },
                new PlantStatusModel
                {
                    PlantName = "Plant B",
                    PlantWateringStatus = "Not Watering"
                },
                new PlantStatusModel
                {
                    PlantName = "Plant C",
                    PlantWateringStatus = "Not Watering"
                },
                new PlantStatusModel
                {
                    PlantName = "Plant D",
                    PlantWateringStatus = "Not Watering"
                },
                new PlantStatusModel
                {
                    PlantName = "Plant E",
                    PlantWateringStatus = "Not Watering"
                }
            };
        }

        public List<PlantStatusModel> AddNewPlant(PlantStatusModel plantStatusModel)
        {
            plantsInfo.Add(plantStatusModel);
            return plantsInfo;
        }

        public List<PlantStatusModel> GetPlantInfo()
        {
            return plantsInfo;
        }

        public List<PlantStatusModel> UpdatePlantWateringStatus(PlantStatusModel plant)
        {
            plantsInfo.Where(p => p.PlantName == plant.PlantName).ToList().ForEach(c => c.PlantWateringStatus = plant.PlantWateringStatus);
            return plantsInfo;
        }
    }
}
