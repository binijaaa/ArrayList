using System.Collections;

namespace DataStructuresHomework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //string[] stringArray = { "Computer", "Plate", "Chair", "Girl", "Boy", "Cat", "Dog", "Shirt", "Determination"};
            
            ArrayList stringArray = new ArrayList();
            stringArray.Add("Computer");
            stringArray.Add("Plate");
            stringArray.Add("Chair");
            stringArray.Add("Girl");
            stringArray.Add("Boy");
            stringArray.Add("Cat");
            stringArray.Add("Dog");
            stringArray.Add("Shirt");
            stringArray.Add("Determination");

    
            int countStartingC = 0;
            int countEndingE = 0;
            int countLength5 = 0;
            int countWithCharE = 0;
            bool found = false;

            //var result = Array.Find(stringArray, element => element.StartsWith("C"));
            //Console.WriteLine(result); --will print only the first one, not the right way

            foreach (string name in stringArray)
            {
                if (name.StartsWith("C"))
                {
                    //Console.WriteLine("Values that start with letter C are: " + name);
                    //countStartingC++; -- best way but might be confusing so we can use:
                    countStartingC = countStartingC + 1;
                }

                if (name.EndsWith("e"))
                {
                    countEndingE = countEndingE + 1;
                }

                if (name.Length == 5)
                {
                    countLength5 = countLength5 + 1;
                }

                if (name.Contains("e"))
                {
                    countWithCharE = countWithCharE + 1;
                }

                if (name.Contains("te"))
                {
                    found = true;
                    break;
                }

            }
            Console.WriteLine("Values that start with letter C: " + countStartingC);
            Console.WriteLine("Values that end with letter e: " + countEndingE);
            Console.WriteLine("Values that have the length 5: " + countLength5);
            Console.WriteLine("Values that consist of character e: " + countWithCharE);

            if (found)
            {
                Console.WriteLine("There is at least one element that consists of the substring 'te'.");
            }
            else
            {
                Console.WriteLine("There are no elements that consist of the substring 'te'.");
            }



            







        }
    }
}