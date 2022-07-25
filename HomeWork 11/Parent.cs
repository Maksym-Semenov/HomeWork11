using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    internal class Parent
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        public Parent()
        {
            this.Name = name;
        }
        public void MarkMySun(int m)
        {
            Console.WriteLine($"Your sun has new mark {m}");
        }
    }
}
