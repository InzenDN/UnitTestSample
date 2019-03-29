using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483_playground.Scenarios
{
    class Song
    {
        private string name;
        public Song NextSong { get; set; }
        private static Song First { get; set; }

        public Song(string name)
        {
            this.name = name;
            First = this;
        }

        public bool IsRepeatingPlaylist()
        {
            if(NextSong == null)
                return false;
            else if(First == this)
                return true;
            else
                return NextSong.IsRepeatingPlaylist();
        }

        public static void Main(string[] args)
        {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
            Song third = new Song("Bacon of the Dream");

            first.NextSong = second;
            second.NextSong = third;
            third.NextSong = first;

            Console.WriteLine(first.IsRepeatingPlaylist());
            Console.ReadKey();
        }
    }
}
