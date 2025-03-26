namespace DesignPattern.Facade
{
    public class JsonExport : IExport
    {
        public void Export()
        {
            Console.WriteLine("Exporting to JSON...");
        }
    }
}
