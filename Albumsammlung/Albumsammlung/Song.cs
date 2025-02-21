using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albumsammlung
{

    internal class Song : Media_Object
    {
        
        public Song(List<string> i) {
            Infos = i;
        }

    }
}
