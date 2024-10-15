public class Character
{
    protected char symbol;
    protected int width;
    protected int height;
    protected int ascent;
    protected int descent;
    public void Display(int pointSize) =>
       Console.WriteLine($"{symbol} (pointsize {pointSize})");
}
