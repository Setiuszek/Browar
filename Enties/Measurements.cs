namespace Browar.Enties
{
    public class Measurements
    {
        public DateTime Date { get; set; }
        public float Extract { get; set; }
        public float Temperature { get; set; }
        public float Pressure { get; set; }
        public String Comment { get; set; }

        public Measurements(float temperature)
        {
            Date = DateTime.Now;
            Temperature = temperature;

        }
    }
}
