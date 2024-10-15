public class President : Approver
{
    public override void PurchaseHandler(object sender, PurchaseEventArgs e)
    {
        if (e.Purchase.Amount < 100000.0)
        {
            Console.WriteLine("{0} approved request# {1}",
                sender.GetType().Name, e.Purchase.Number);
        }
        else if (Successor != null)
        {
            Successor.PurchaseHandler(this, e);
        }
        else
        {
            Console.WriteLine(
                "Request# {0} requires an executive meeting!",
                e.Purchase.Number);
        }
    }
}
