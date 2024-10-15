namespace Template.NetOptimized;

/// <summary>
/// The 'AbstractClass' abstract class
/// </summary>
public abstract class DataAccessor<T> where T : class, new()
{
    protected List<T> Items { get; set; } = [];

    public virtual void Connect()
    {
        Items.Clear();
    }
    public abstract void Select();
    public abstract void Process(int top);
    public virtual void Disconnect()
    {
        Items.Clear();
    }

    // The 'Template Method' 
    public void Run(int top)
    {
        Connect();
        Select();
        Process(top);
        Disconnect();
    }
}
