using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            al.Add(14);
            al.Add("SEIP");
            al.Add(16.8);

            al.Reverse();
            //al.Sort(); declare same dataType to sort ArrayList

            foreach (var a in al)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
