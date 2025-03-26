namespace DesignPattern.Adapter
{
    public class AdapterPattern : IPattern
    {
        public void Execute()
        {
            OldMessurement adaptee = new(10);
            MessurementAdapter adapter = new(adaptee);
            Console.WriteLine($"Old Messurement have width {adaptee.GetWidthInMeter()} m");
            adapter.Draw();
        }
    }
}
