namespace Browar.Enties
{
    public class Batch
    {

        public String TankNumber { get; set; }

        public DateTime Date;
        public Recipe Recipe { get; set; }
        public List<Measurements> Measurements { get; set; }

        public Batch(Recipe recipe, int efficency, List<Measurements> measurements)
        {
            Date = DateTime.Now;
            Recipe = recipe;
        }
    }
}
