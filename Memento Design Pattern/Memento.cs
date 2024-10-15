namespace Memento.NetOptimized;

using System.Text.Json;

/// <summary>
/// The 'Memento' class
/// </summary>
public class Memento
{
    private string store = null!;

    public Memento Serialize(object o)
    {
        store = JsonSerializer.Serialize(o);
        return this;
    }

    public object Deserialize()
    {
        return JsonSerializer.Deserialize<SalesProspect>(store)!;
    }
}

