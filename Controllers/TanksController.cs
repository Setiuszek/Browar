using Browar.Enties;
using Browar.Services;
using Microsoft.AspNetCore.Mvc;

namespace Browar.Controllers
{
    [Route("api/[controller]")] // /tanks/
    [ApiController]
    public class TanksController : Controller
    {

        private TankSerivce _tankService;

        public TanksController(TankSerivce tankSerivce)
        {
            _tankService = tankSerivce;
        }
        

        [HttpGet("tank/{number}")] // weww.localhost:500/tank/blabla/11
        public ActionResult<Tank> GetTanksByNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                throw new Exception("Nie wprowadzono numeru");
            }

            var tank = _tankService.GetTank(number);

            if (tank == null)
            {
                return NotFound();
            }

            return tank;
        }

        [HttpPut]
        public ActionResult PutTank(Tank tank)
        {
            if(tank is null)
            {
                throw new Exception("Brak wartości");
            }

            _tankService.AddTank(tank);

            return Ok();
        }
    }
}
