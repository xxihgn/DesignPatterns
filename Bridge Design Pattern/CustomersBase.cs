using Bridge.NetOptimized;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Design_Pattern
{
    public class CustomersBase(IDataObject<string> dataObject)
    {
        public virtual void Next() => dataObject.NextRecord();
        public virtual void Prior() => dataObject.PriorRecord();
        public virtual void Add(string name) => dataObject.AddRecord(name);
        public virtual void Delete(string name) => dataObject.DeleteRecord(name);
        public virtual void Show() => dataObject.ShowRecord();
        public virtual void ShowAll() => dataObject.ShowAllRecords();
    }

}
