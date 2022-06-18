using DubberwangInterfaces.Core;
using Microsoft.AspNetCore.Mvc;

namespace DubberwangWeb.Controllers
{
    /// <summary>
    /// Controller that handles all Lottery based endpoints.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LotteryController : ControllerBase
    {

        private readonly ILotteryGenerator _generator;
                
        /// <summary>
        /// Constructor method, DI supplied generator implementation.
        /// </summary>
        /// <param name="generator"></param>
        public LotteryController(ILotteryGenerator generator)
        {
            _generator = generator;
        }
        
        /// <summary>
        /// Api method that returns a new list of <see cref="ILotteryBall"/>
        /// </summary>
        /// <returns>An IEnumerable of <see cref="ILotteryBall"/></returns>
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
