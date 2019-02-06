using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBeng
{
    class Music
    {
        public int ID;
        public string path;
        public string music_name;

        public Music() { }

        public Music(int ID, string path, string music_name)
        {
            this.ID = ID;
            this.path = path;
            this.music_name = music_name;
        }
    }
}
