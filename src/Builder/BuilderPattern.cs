namespace DesignPattern.Builder
{
    /// <summary> Example of Builder Pattern, to create a computer </summary>
    public class BuilderPattern : IPattern
    {
        public void Execute()
        {
            IComputer computer = new ComputerBuilder()
                .AddCpu("Ryzen 9 7900X3D")
                .AddGpu("Nvidia RTX 5090")
                .AddMainboard("Asus ROG Strix X750")
                .AddRam("Corsair Vengeance 32GB DDR5 x2")
                .AddStorage("Samsung 980 EVO Plus 1TB")
                .AddTouchScreen(false)
                .Build();
            Console.WriteLine("Computer:");
            Console.WriteLine($"- CPU: {computer.Cpu}");
            Console.WriteLine($"- Mainboard: {computer.Mainboard}");
            Console.WriteLine($"- Ram: {computer.Ram}");
            Console.WriteLine($"- Storage: {computer.Storage}");
            Console.WriteLine($"- Gpu: {computer.Gpu}");
            Console.WriteLine($"- Touch Screen: {(computer.HasTouchScreen ? "Yes" : "No")}");
        }
    }
}
