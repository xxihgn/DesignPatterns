namespace Abstract_Factory
{
    internal class Lion : ICarnivore
    {
        // Eat Wildebeest
        public void Eat(IHerbivore h) =>
         Console.WriteLine($"{GetType().Name} eats {h.GetType().Name}"); 
    }
}
