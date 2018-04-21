using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CMyClass tmpMC1 = new CMyClass();
            Console.WriteLine(tmpMC1.GetName());

            Console.WriteLine(new CMyClass(1).GetName());
            Console.WriteLine(new CMyClass(3,"AAA").GetName());

            int a = 5;
            int b = 5;
            tmpMC1.Increase(a);
            tmpMC1.Increase(ref b); //ref 초기화 필수

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c;
            tmpMC1.MakeValue(out c); //out은 초기화 안해도 됨
            Console.WriteLine(c); //대신 함수에서 값을 넣는 것이 필수
        }
    }
}
