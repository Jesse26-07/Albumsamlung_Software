using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Albumsammlung
{
    internal class Database
    {
        public List<string> Tags = new List<string>();
        public List<Media_Object> Album = new List<Media_Object>();
        Import_Export im = new Import_Export();
        public Database()
        {

            

            Album.AddRange(im.DataImport());
            if (im.filenameImport != "") { 
            Tags.AddRange(im.TagsImport(im.filenameImport));
            }

             
        }

        public void Export()
        {
            im.Export(Album);
        }
    }
}
