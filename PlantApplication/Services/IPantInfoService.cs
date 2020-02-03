using PlantApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantApplication.Services
{
    public interface IPantInfoService
    {
        List<PlantStatusModel> GetPlantInfo();
        List<PlantStatusModel> AddNewPlant(PlantStatusModel plantStatusModel);
        List<PlantStatusModel> UpdatePlantWateringStatus(PlantStatusModel plant);

    }
}
