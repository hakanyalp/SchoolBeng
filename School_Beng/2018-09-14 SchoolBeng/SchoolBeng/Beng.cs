using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBeng
{
    class Beng
    {
        public int ID;
        public int path_number;
        public Time time = new Time();

        public Beng() { }

        public Beng(int ID, Time time, int path_number)
        {
            this.ID = ID;
            this.path_number = path_number;
            this.time = time;
        }

        
    }
}
