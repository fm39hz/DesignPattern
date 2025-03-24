using DesignPattern.Builder;

namespace DesignPattern
{
    public static class Program
    {
        internal static Dictionary<string, IPattern> Patterns = new()
        {
            { "Builder Pattern", new BuilderPattern() }
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
