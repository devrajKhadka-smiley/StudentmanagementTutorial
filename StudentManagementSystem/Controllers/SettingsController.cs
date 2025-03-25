using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        [HttpGet]
        public string? GetAIFromSetting()
        {
            //it gives the object of the iconfiguration by building as it should be empty in beginning
            //IConfiguration config = new ConfigurationBuilder().Build();
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string? aiChoosen = config["UsedAi"];
            return aiChoosen;
        }
    }
}
