namespace DesignPattern.Builder
{
    /// <summary> Example of Builder Pattern, to create a computer </summary>
    public class ComputerBuilder : IComputerBuilder
    {
        private readonly Computer Computer = new();
        public IComputerBuilder AddCpu(string cpu)
        {
            Computer.Cpu = cpu;
            return this;
        }

        public IComputerBuilder AddGpu(string graphicCard)
        {
            Computer.Gpu = graphicCard;
            return this;
        }

        public IComputerBuilder AddMainboard(string mainboard)
        {
            Computer.Mainboard = mainboard;
            return this;
        }

        public IComputerBuilder AddRam(string memory)
        {
            Computer.Ram = memory;
            return this;
        }

        public IComputerBuilder AddStorage(string storage)
        {
            Computer.Storage = storage;
            return this;
        }

        public IComputerBuilder AddTouchScreen(bool hasTouchScreen)
        {
            Computer.HasTouchScreen = hasTouchScreen;
            return this;
        }

        public IComputer Build()
        {
            return Computer;
        }
    }
}
