using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albumsammlung
{
    internal class Controller
    {

        public Database database;
        String Searched_Item = "";
        List<Media_Object> Search_Found = new List<Media_Object>();
        bool database_Created = false;
        bool Search = false;
        public int indexSelectedSong = 0;

        public void btn_Load_Click()
        {
            database = new Database();
            database_Created = true;
        }
        public ListBox lb_Song_SelectedIndexChanged(ListBox lD, ListBox lS)
        {
            ListBox lb_details = lD;
            ListBox lb_Song = lS;


            lb_details.Items.Clear();
            indexSelectedSong = lb_Song.SelectedIndex;
            int i = 0;
            if (indexSelectedSong != -1)
            {
                if (!Search)
                {
                    foreach (string I in database.Album[indexSelectedSong].Infos)
                    {
                        lb_details.Items.Add(database.Tags[i] + ": " + I);
                        i++;
                    }
                }
                else
                {
                    foreach (string I in Search_Found[indexSelectedSong].Infos)
                    {
                        lb_details.Items.Add(database.Tags[i] + ": " + I);
                        i++;
                    }
                }
            }
            return lb_details;
        }

        public void btn_Search_Click()
        {
            if (Searched_Item != "")
            {
                Search = true;

                Search_Found.Clear();
                int z = 0;
                bool Found = false;
                if (database_Created)
                {
                    foreach (Song x in database.Album)
                    {
                        Found = false;
                        foreach (String y in x.Infos)
                        {

                            if (y.Contains(Searched_Item))
                            {
                                Found = true;

                            }
                        }
                        if (Found)
                        {
                            Search_Found.Add(database.Album[z]);
                        }
                        z++;
                    }
                }
            }
            else
            {
                Search = false;
            }
        }
        public ListBox Reload(ListBox lS)
        {
            ListBox lb_Song = lS;
            lb_Song.Items.Clear();
            if (!Search)
            {
                foreach (Song s in database.Album)
                {
                    lb_Song.Items.Add(s.Infos[7]);
                }
            }
            else
            {
                foreach (Song s in Search_Found)
                {
                    lb_Song.Items.Add(s.Infos[7]);
                }
            }
            return lb_Song;

        }

        public ToolStripTextBox tb_Search_Input_TextChanged(ToolStripTextBox tSI)
        {
            ToolStripTextBox tb_Search_Input = tSI;
            Searched_Item = tb_Search_Input.Text;
            return tb_Search_Input;
        }
        
        public void btn_Save_Click()
        {
            database.Export();
        }
    }
}
