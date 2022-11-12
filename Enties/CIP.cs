namespace Browar.Enties
{
    public class CIP
    {
        public DateTime whenCIPped { get; set; }
        public String whichChemistry;
        
        public CIP(DateTime dateTime, String Chemistry)
        {
            whenCIPped = dateTime;
            whichChemistry = Chemistry;
        }
    }
}
