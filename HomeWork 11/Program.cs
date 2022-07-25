using System;

namespace HomeWork_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Student student = new Student();
            Buhgalteria buhgalteria = new Buhgalteria();

            Mark par = parent.MarkMySun;
            Mark buh = buhgalteria.MarkStudent;

            student.NewMark += par;
            student.NewMark += buh;

            student.AddMark(5);
            student.AddMark(45);
            student.AddMark(15);
            student.AddMark(25);
            student.AddMark(35);
        }
    }
}
