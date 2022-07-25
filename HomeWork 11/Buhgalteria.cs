using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    internal class Buhgalteria
    {
        List<int> marks = new List<int>();
        public void MarkStudent(int m)
        {
            marks.Add(m);
            if (marks.Sum() >= 71)
            {
                Console.WriteLine("Ти отримаєш стипендію");
            }
            else
            {
                Console.WriteLine("Для стипендії замало");
            }
        }
    }
}
