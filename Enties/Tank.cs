namespace Browar.Enties
{
    public class Tank
    {
        public string Number { get; set; }

        List<Batch> Batches { get; set; }
        List<CIP>   CIPs { get; set; }
        public int MaxVolume { get; set; }
    }
}
