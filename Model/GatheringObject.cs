namespace MercatorisAdiutor.Model
{
    public interface GatheringObject
    {
        public string Name { get; }

        public int Labor { get; }

        public int Cost { get; }

        public int TotalExperience { get; }

        public int TotalTime { get; }

        public Production[] TotalProduction { get; }
    }
}
