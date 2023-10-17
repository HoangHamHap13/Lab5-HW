using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
    internal class Lab5_1
    {
        public void BookTest()
        {
            Book b1 = new Book(1, "Wuthering Heights", 98, "Usborne Publishing");
            Console.WriteLine(b1.ToString());
        }
    }
}
