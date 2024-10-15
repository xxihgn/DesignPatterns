public class User
{
    private readonly Calculator calculator = new();
    private readonly List<ICommand> commands = [];
    private int current = 0;
    // Redo original commands
    public void Redo(int levels)
    {
        Console.WriteLine($"\n---- Redo {levels} levels ");
        // Perform redo operations
        for (int i = 0; i < levels; i++)
        {
            if (current < commands.Count - 1)
            {
                commands[current++].Execute();
            }
        }
    }
    // Undo prior commands
    public void Undo(int levels)
    {
        Console.WriteLine($"\n---- Undo {levels} levels ");
        // Perform undo operations
        for (int i = 0; i < levels; i++)
        {
            if (current > 0)
            {
                commands[--current].UnExecute();
            }
        }
    }
    // Compute new value given operator and operand
    public void Compute(char @operator, int operand)
    {
        // Create command operation and execute it
        var command = new CalculatorCommand(calculator, @operator, operand);
        command.Execute();
        // Add command to undo list
        commands.Add(command);
        current++;
    }
}