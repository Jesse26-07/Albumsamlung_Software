using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Albumsammlung
{
    public partial class FormChange : Form
    {


        List<string> Info;
        List<string> Tags;
        int index;
        int index_lb_data = 0;
        Form1 f;
        public FormChange(Form1 newf)
        {
            InitializeComponent();
            f = newf;
        }

        private void lb_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            index_lb_data = lb_data.SelectedIndex;
            if (index_lb_data != -1) {
                tb_change_data.Text = Info[index_lb_data];
                    }
        }
        public void GetInformation(List<string> newInfo, List<string> newTags, int newIndex)
        {
            Info = newInfo;
            Tags = newTags;
            index = newIndex;
            update();
        }

        public void update()
        {
            lb_data.Items.Clear();
            int X = 0;
            foreach (string x in Tags)
            {

                lb_data.Items.Add(x + ": " + Info[X]);
                X++;
            }
        }

        

        private void tb_change_data_TextChanged(object sender, EventArgs e)
        {
            if (index_lb_data != -1)
            {

           
            Info[index_lb_data] = tb_change_data.Text;
            update();
            }
        }

        private void FormChange_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            f.newChange(Info, index);
        }

        
    }
}
