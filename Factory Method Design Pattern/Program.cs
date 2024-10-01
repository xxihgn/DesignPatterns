using Factory_Method_Design_Pattern;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Document = Factory_Method_Design_Pattern.Document;

namespace DoFactory.GangOfFour.Factory.RealWorld
{
    class MainApp
    {
        static void Main()
        {
            // Note: constructors call Factory Method

            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (System.Reflection.Metadata.Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
