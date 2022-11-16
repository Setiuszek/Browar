using Browar.Enties;

namespace Browar.Services
{
    public class TankSerivce
    {
        List<Tank> Tanks;

        public TankSerivce()
        {
            Tanks = new List<Tank>();
        }

        public void AddTank(Tank tank)
        {
            Tanks.Add(tank);
        }

        public Tank GetTank( string number)
          => Tanks.FirstOrDefault(t => t.Number == number);

        //public Tank GetTank(string number)
        //{
        //    return Tanks.FirstOrDefault(t => t.Number == number);
        //}
          

    }
}
