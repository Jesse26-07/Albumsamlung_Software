using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albumsammlung
{
    internal class Import_Export
    {
        
        public string filenameImport = "";
        public string filenameExport = "";
        public List<Media_Object> DataImport()
        {
            List<Media_Object> Data = new List<Media_Object>();

            var dlg = new OpenFileDialog()                                  //Explorer wird geöfnet
            {
                RestoreDirectory = true
            };

            if (dlg.ShowDialog() != DialogResult.OK)
                filenameImport = "";

            filenameImport = dlg.FileName;




            if (filenameImport != "")
            {
                using (StreamReader sr = new StreamReader(filenameImport))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        List<string> ZwischenspeicherList = new List<string>();

                        ZwischenspeicherList.Clear();



                        ZwischenspeicherList.AddRange(line.Split(','));                             //line wird nach ',' gesplittet



                        for (int i = 0; i != ZwischenspeicherList.Count(); i++)
                        {
                            if (((ZwischenspeicherList[i].Split('"').Count()) % 2) == 0)                                //Hier wird geguckt ob nur ein Anfürungszeichen geöffnet wird
                            {

                                ZwischenspeicherList[i] = ZwischenspeicherList[i] + "," + ZwischenspeicherList[i + 1];
                                if (((ZwischenspeicherList[i + 1].Split('"').Count()) % 2) == 0)
                                {                      //wenn hier ein Anfürungszeichen gefunden wird dann weiß das Programm dass das Anführungszeichen wieder geschlossen wurde
                                    ZwischenspeicherList.RemoveAt(i + 1);
                                }
                                else
                                {
                                    ZwischenspeicherList.RemoveAt(i + 1);
                                    i--;
                                }
                            }
                        }
                        Song n = new Song(ZwischenspeicherList);


                        Data.Add(n);

                    }
                }


            }
            return Data;

        }



        public List<string> TagsImport(string FileNAME)
        {
            List<string> Tags = new List<string>();
            string line;


            using (StreamReader sr = new StreamReader(filenameImport))
            {
                line = sr.ReadLine();

            }
            Tags.AddRange(line.Split(','));
            return Tags;
        }

        public void Export(List<Media_Object> Data)
        {
            var dlg = new SaveFileDialog()                                  //Explorer wird geöfnet
            {
                RestoreDirectory = true
                
            };
            dlg.Filter = "csv|*.txt|Bitmap Image|*.bmp|Gif Image|*.gif";
            dlg.Title = "Save an Text File";

            if (dlg.ShowDialog() == DialogResult.OK) { 
                filenameExport = "";

            filenameExport = dlg.FileName;
            }
            if (filenameExport != "") {

                using (StreamWriter sw = new StreamWriter(filenameExport))
                {
                    foreach (Song y in Data)
                    {
                        foreach (String x in y.Infos)
                        {
                            if (x != y.Infos[y.Infos.Count - 1]) {
                                sw.Write(x + ","); }
                            else { sw.Write(x); }
                        }
                        sw.WriteLine();
                    }
                }
            }
                
        }
    }
}

