namespace DesignPattern.Builder
{
    public class Computer() : IComputer
    {
        public string Cpu { get; set; } = default!;
        public string Mainboard { get; set; } = default!;
        public string Ram { get; set; } = default!;
        public string Storage { get; set; } = default!;
        public string Gpu { get; set; } = default!;
        public bool HasTouchScreen { get; set; } = default!;
    }
}
