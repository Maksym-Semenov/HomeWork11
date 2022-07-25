using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    delegate void Mark(int m);
    internal class Student : Parent
    {
        public string Name { get { return "Max"; } }
        public Student()
        {
           
        }
        public event Mark NewMark;
        public void AddMark(int m)
        {
            if (NewMark != null)
            {
                NewMark.Invoke(m);
            }
        }
    }
}
