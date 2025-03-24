namespace DesignPattern.Builder
{
    /// <summary> A Computer builder </summary>
    public interface IComputerBuilder
    {
        /// <summary> Add CPU to the computer </summary>
        /// <param name="cpu"> CPU name </param>
        IComputerBuilder AddCpu(string cpu);
        /// <summary> Add Mainboard to the computer </summary>
        /// <param name="mainboard"> Mainboard name </param>
        IComputerBuilder AddMainboard(string mainboard);
        /// <summary> Add Ram to the computer </summary>
        /// <param name="memory"> Ram memory </param>
        IComputerBuilder AddRam(string memory);
        /// <summary> Add Storage to the computer </summary>
        /// <param name="storage"> Storage type </param>
        IComputerBuilder AddStorage(string storage);
        /// <summary> Add Graphic Card to the computer </summary>
        /// <param name="graphicCard"> Graphic Card name </param>
        IComputerBuilder AddGpu(string graphicCard);
        /// <summary> Add Touch Screen to the computer </summary>
        /// <param name="hasTouchScreen"> Whether the computer has a touch screen or not</param>
        IComputerBuilder AddTouchScreen(bool hasTouchScreen);
        /// <summary> Build the computer </summary>
        IComputer Build();
    }
}
