namespace DesignPattern.Adapter
{
    public class MessurementAdapter(OldMessurement adaptee) : IDrawer
    {
        public double GetWidthInInches()
        {
            return adaptee.GetWidthInMeter() * 39.37;
        }
        public void Draw()
        {
            Console.WriteLine($"New Messurement have width {GetWidthInInches()} inches");
        }
    }
}
