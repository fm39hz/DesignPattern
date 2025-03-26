namespace DesignPattern.Adapter
{
    public class OldMessurement(double width) : IDrawer
    {
        public double GetWidthInMeter()
        {
            return width;
        }
        public void Draw()
        {
            Console.WriteLine($"Old Messurement have width {GetWidthInMeter()} m");
        }
    }
}
