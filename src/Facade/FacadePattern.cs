namespace DesignPattern.Facade
{
    public class FacadePattern : IPattern
    {
        public void Execute()
        {
            Exporter facade = new();
            facade.PrepareCsv();
            facade.Export.Export();
            facade.PrepareJson();
            facade.Export.Export();
        }
    }
}
