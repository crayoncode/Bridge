using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            HandSetBrand ab = new HandSetBrandN();

            ab.SetHandsetSoft(new HandSetGame());
            ab.Run();

            ab.SetHandsetSoft(new  HandSetAddressList());
            ab.Run();

            HandSetBrand ss = new HandSetBrandM();
            ss.SetHandsetSoft(new HandSetGame());
            ss.Run();

            Console.ReadKey();
        }
    }
}
