using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatresA.CRockPaperScissorsLizardSpock.Services;
using Microsoft.AspNetCore.Mvc;

namespace BatresA.CRockPaperScissorsLizardSpock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPSLSController : ControllerBase
    {
        RPSLSServices _rPSLSServices;
        public RPSLSController(RPSLSServices rPSLSServices){
            _rPSLSServices = rPSLSServices;
        }

        [HttpGet]
        [Route("RPSLS")]

        public string RPSLS()
        {
            return _rPSLSServices.RPSLS();
        }
    }
}