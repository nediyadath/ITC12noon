using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.DAL
{
    public class CRUD
    {
       public void MyMethod(int x)
        {
            Console.WriteLine(x * x);
        }
        public void MyMethod(string x)
        {
            Console.WriteLine(x);
        }
        public void MyMethod(float x)
        {

        }
    }

    public class MyGenericClass
    {
        //state and behavior
        int x;
        string y;
        public int id { get; set; }
        public MyGenericClass(int x)
        {

        }
        public void MyMethod(int x)
        {

        }
    }
}
