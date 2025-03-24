namespace DesignPattern.Builder
{
    public interface IComputer
    {
        string Cpu { get; set; }
        string Mainboard { get; set; }
        string Ram { get; set; }
        string Storage { get; set; }
        string Gpu { get; set; }
        bool HasTouchScreen { get; set; }
    }
}
