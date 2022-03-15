using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHashTable
{
    public class Frequency
    {
        public static void FindIndexes()
        {
            string searchableString = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string keyword = "paranoid";

            int index = searchableString.IndexOf(keyword);
            while (index >= 0)
            { 
            Console.WriteLine("Index " + index);
                index = searchableString.IndexOf(keyword, index+keyword.Length);
            }

        }
        

    }
}
