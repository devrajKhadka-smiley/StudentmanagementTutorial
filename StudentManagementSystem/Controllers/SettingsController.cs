using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using StudentManagementSystem.Settings;

namespace StudentManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        IConfiguration config;
        //making instances
        AI choosenAi;

        public SettingsController(IConfiguration config, IOptionsMonitor<AI> options)
        {
            this.config = config;
            //this.choosenAi = options.Value;
            this.choosenAi = options.CurrentValue;
        }

        [HttpGet]
        public IActionResult GetAIFromSetting()
        {
            //it gives the object of the iconfiguration by building as it should be empty in beginning
            //IConfiguration config = new ConfigurationBuilder().Build();
            //IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //string? aiChoosen = config["UsedAi"];
            //return aiChoosen;\

            //passing individual data
            //string? aiChoosen = config["UsedAi:Name"];
            //string? aiVersion = config["UsedAi:Version"];
            //string? aiApikey = config["UsedAi:APIKEY"];
            ////return aiChoosen;
            //return Ok(new {AIChoosen = aiChoosen, AIVersion = aiVersion, AIApikey = aiApikey });

            //passing the whole object from settings class
            //string? aiChoosen = config["UsedAi:Name"];
            //string? aiVersion = config["UsedAi:Version"];
            //string? aiApikey = config["UsedAi:APIKEY"];

            //AI choosenAi = new AI()
            //{
            //    Name = aiChoosen,
            //    Version = aiVersion,
            //    APIKEY = aiApikey
            //};

            //return Ok(choosenAi);



            return Ok(choosenAi);
        }
    }
}
