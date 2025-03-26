namespace DesignPattern.Facade
{
    public class Exporter
    {
        public IExport Export { get; set; } = default!;
        public void PrepareCsv()
        {
            Export = new CsvExport();
        }
        public void PrepareJson()
        {
            Export = new JsonExport();
        }
    }
}
