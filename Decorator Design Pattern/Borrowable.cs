﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Design_Pattern
{
    public class Borrowable<T> : Decorator<T>
    {
        private readonly List<string> borrowers = [];
        // Constructor
        public Borrowable(LibraryItem<T> libraryItem)
            : base(libraryItem)
        {
        }
        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            NumCopies--;
        }
        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            NumCopies++;
        }
        public override void Display()
        {
            base.Display();
            borrowers.ForEach(b => Console.WriteLine(" borrower: " + b));
        }
    }

}
