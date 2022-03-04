

using DotNetTrainingBatch3.DAL;
using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CRUD obj = new CRUD();
            obj.MyMethod(y:"Hello",x:10);
        }
        ~Program()
        {

        }
    }
}
