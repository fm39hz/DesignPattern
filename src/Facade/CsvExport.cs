namespace DesignPattern.Facade
{
    public class CsvExport : IExport
    {
        public void Export()
        {
            Console.WriteLine("Exporting to CSV...");
        }
    }
}
