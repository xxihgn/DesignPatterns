public class IBM(double price) : Stock("IBM", price)
{
}
/// <summary>
/// The 'Observer' interface
/// </summary>
public interface IInvestor
{
    void Update(object sender, ChangeEventArgs e);
}