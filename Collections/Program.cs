using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList objectList = new ArrayList() { 0, 42, "hello", 's', true, 2.0f };
            object obj = 68.2;

            objectList.Add(obj);
            objectList.Add("bye");
            ListPrint(objectList);

            objectList.RemoveAt(0);
            objectList.RemoveAt(0);
            ListPrint(objectList);

            Console.ReadKey();
        }

        static void ListPrint(ArrayList list)
        {
            foreach(object o in list){
                Console.Write(o);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
