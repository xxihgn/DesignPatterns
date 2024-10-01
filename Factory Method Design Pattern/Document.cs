using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Pattern
{
    public abstract class Document
    {
        public List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method

        public abstract void CreatePages();
    }
}
