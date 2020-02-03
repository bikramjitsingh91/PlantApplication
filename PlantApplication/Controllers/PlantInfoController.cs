using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlantApplication.Model;
using PlantApplication.Services;

namespace PlantApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantInfoController : ControllerBase
    {

        private readonly ILogger<PlantInfoController> _logger;
        private readonly IPantInfoService _service;

        public PlantInfoController(ILogger<PlantInfoController> logger, IPantInfoService service)
        {
            _logger = logger;
            _service = service;
        }


        [EnableCors("CorsPolicy")]
        [HttpGet]
        public List<PlantStatusModel> Get()
        {
            var plantInfo = _service.GetPlantInfo();
            if (plantInfo == null)
                return null;
            return plantInfo.ToList();
        }
    }
}
