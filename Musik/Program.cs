
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Musik
{
    class Program
    {
        public static Note[] SovietAnthem = new Note[]
        {
            new Note(5,2),
            new Note(-7,0.5f),
            new Note(2, 0.5f),
            new Note(5, 1),
            new Note(2, 0.5f),
            new Note(3, 0.5f),
            new Note(4, 1),
            new Note(0, 0.5f),
            new Note(0, 0.5f),
            new Note(3, 1),
            new Note(2, 0.5f),
            new Note(1, 0.5f),
            new Note(2, 1),
            new Note(-2,0.5f),
            new Note(-2, 0.5f),
            new Note(-1, 1),
            new Note(-1, 0.5f),
            new Note(0, 0.5f),
            new Note(1, 1),
            new Note(1, 0.5f),
            new Note(2, 0.5f),
            new Note(3,1),
            new Note(3, 0.5f),
            new Note(4, 0.5f),
            new Note(5, 0.5f),
            new Note(-7, 0.5f),
            new Note(2, 0.5f),
            new Note(7, 1),
            new Note(6, 0.5f),
            new Note(5, 0.5f),
            new Note(6,1),
            new Note(4, 0.5f),
            new Note(2, 0.5f),
            new Note(5, 1),
            new Note(4, 0.5f),
            new Note(3, 0.5f),
            new Note(4, 1),
            new Note(0, 0.5f),
            new Note(0, 0.5f),
            new Note(3, 1),
            new Note(2, 0.5f),
            new Note(1, 0.5f),
            new Note(2, 1),
            new Note(-2, 0.5f),
            new Note(-2, 0.5f),
            new Note(5, 1),
            new Note(4, 0.5f),
            new Note(3, 0.5f),
            new Note(2, 1),
            new Note(-7, 1),
            new Note(7, 2),
            new Note(6, 0.5f),
            new Note(5, 0.5f),
            new Note(4, 0.5f),
            new Note(5, 0.5f),
            new Note(6, 1),
            new Note(2, 0.5f),
            new Note(2, 1),
            new Note(-7, 0.5f),
            new Note(5, 2),
            new Note(4, 0.5f),
            new Note(3, 0.5f),
            new Note(2, 0.5f),
            new Note(3, 0.5f),
            new Note(4, 1),
            new Note(0, 0.5f),
            new Note(0, 1),
            new Note(-7, 0.5f),
            new Note(5, 1),
            new Note(4, 0.5f),
            new Note(3, 0.5f),
            new Note(2, 1),
            new Note(-2, 0.5f),
            new Note(-2, 0.5f),
            new Note(5, 1),
            new Note(4, 0.5f),
            new Note(3, 0.5f),
            new Note(2, 1),
            new Note(-7, 0.5f),
            new Note(2, 0.5f)
        };
        static void Main(string[] args)
        {
            Console.ReadKey();

            foreach(Note n in SovietAnthem)
            {
                Console.Beep(int.Parse((750 + (n.Hz * 100)).ToString()), int.Parse((n.Length * 1000).ToString()));
                //Thread.Sleep(100);
            }
        }

    }
    class Note
    {
        public Note(float hz, float length)
        {
            this.Hz = hz;
            this.Length = length;
        }

        public float Hz { get; set; }
        public float Length { get; set; }
    }
}
