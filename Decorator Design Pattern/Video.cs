using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class Video : LibraryItem<Video>
    {
        private readonly string director;
        private readonly string title;
        private readonly int playTime;
        // Constructor
        public Video(string director, string title,
            int numCopies, int playTime)
        {
            this.director = director;
            this.title = title;
            NumCopies = numCopies;
            this.playTime = playTime;
        }
        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine($" Director: {director}");
            Console.WriteLine($" Title: {title}");
            Console.WriteLine($" # Copies: {NumCopies}");
            Console.WriteLine($" Playtime: {playTime}\n");
        }
    }
}
