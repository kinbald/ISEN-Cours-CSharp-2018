using System;

namespace Isen.Cs.Library.Lessons
{
    public class D_MyCollection
    {
        public static void Run()
        {
            IMyCollection myCollection = new MyCollection();
            myCollection.Add("Bonjour");
            myCollection.Add("tout");
            myCollection.Add("le");
            myCollection.Add("monde");

            foreach (var item in myCollection.Values)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            
            IMyCollection mySecondCollection = new MyCollection();
            mySecondCollection.Add("10");
            mySecondCollection.Add("20");
            mySecondCollection.Add("30");
            mySecondCollection.Add("40");
            mySecondCollection.InsertAt(2, "25");
            mySecondCollection.InsertAt(0, "5");
            
            foreach (var item in mySecondCollection.Values)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
    }
}