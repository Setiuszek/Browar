namespace Browar.Enties
{
    public class MashingTime
    {
        public int HowLong { get; set; }
        public int Temperature { get; set; }

        public MashingTime(int howLong, int temperature)
        {
            HowLong = howLong;
            Temperature = temperature;
        }
    }
}
