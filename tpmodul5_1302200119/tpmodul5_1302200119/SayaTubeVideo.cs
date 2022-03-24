using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200119
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        private static Random random = new Random();

        public SayaTubeVideo(string title)
        {
            this.title = title;

            const string chars = "0123456789";
            this.id = int.Parse( new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray()) );

            this.playCount = 0;
        }

        public void IncreasePlayCount(int x)
        {
            this.playCount += x;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID\t: " + this.id + "\nJudul\t: " + this.title
                + "\nJumlah diputar: " + this.playCount);
        }

    }
}
