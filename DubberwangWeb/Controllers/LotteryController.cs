using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DubberwangInterfaces.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DubberwangWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {

        private readonly ILotteryGenerator _generator;
        
        public LotteryController(ILotteryGenerator generator)
        {
            _generator = generator;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ILotteryBall>>> GetLotteryResult()
        {
            // This would typically go in appsettings.json
            int count = 6;
            int bonus = 1;
            List<ILotteryBall> lotteryBalls = _generator.GetNewLotteryBalls(count, bonus);
            return new OkObjectResult(lotteryBalls);
        }
    }
    
}
