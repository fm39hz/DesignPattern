using DesignPattern.Adapter;
using DesignPattern.Builder;
using DesignPattern.Facade;

namespace DesignPattern
{
    public static class Program
    {
        internal static Dictionary<string, IPattern> Patterns = new()
        {
            { "Builder Pattern", new BuilderPattern() },
            { "Adapter Pattern", new AdapterPattern() },
            { "Facade Pattern", new FacadePattern() }
        };
        public static void Main()
        {
            foreach (KeyValuePair<string, IPattern> pattern in Patterns)
            {
                Console.WriteLine($"Executing {pattern.Key}...");
                pattern.Value.Execute();
                Console.WriteLine();
            }
        }
    }
}
