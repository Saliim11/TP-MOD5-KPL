using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vid1 = new SayaTubeVideo("Tutorial Design " +
                "By Contract - Muhammad Qalbun Saliim Bakhri");
            vid1.IncreasePlayCount(4);
            vid1.PrintVideoDetails();
            vid1.IncreasePlayCount(6);
            vid1.PrintVideoDetails();
        }
    }
}
