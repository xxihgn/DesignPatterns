public class MathProxy : IMath
{
    private readonly Math math = new();
    public double Add(double x, double y)
    {
        Thread.Sleep(800);
        return math.Add(x, y);
    }
    public double Sub(double x, double y)
    {
        Thread.Sleep(800);
        return math.Sub(x, y);
    }
    public double Mul(double x, double y)
    {
        Thread.Sleep(800);
        return math.Mul(x, y);
    }
    public double Div(double x, double y)
    {
        Thread.Sleep(800);
        return math.Div(x, y);
    }
}