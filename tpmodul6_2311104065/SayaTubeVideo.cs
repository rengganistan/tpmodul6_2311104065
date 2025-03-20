using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_2311104065
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {

            if (string.IsNullOrEmpty(title) || title.Length > 100)
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter.");

            // Generate ID random 5 digit
            Random rand = new Random();
            this.id = rand.Next(10000, 99999);

            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {

            if (count > 10000000)
                throw new ArgumentException("Maksimum penambahan play count adalah 10.000.000");

            checked
            {
                this.playCount += count;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("===== Video Details =====");
            Console.WriteLine($"ID        : {id}");
            Console.WriteLine($"Title     : {title}");
            Console.WriteLine($"Play Count: {playCount}");
            Console.WriteLine("=========================");
        }
    }
}
