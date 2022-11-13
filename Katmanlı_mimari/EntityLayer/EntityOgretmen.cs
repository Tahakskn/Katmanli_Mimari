using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private int ogrtkont;
        private int ogrtbrans;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public int Ogrtkont { get => ogrtkont; set => ogrtkont = value; }
        public int Ogrtbrans { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
