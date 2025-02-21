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
    public partial class Form1 : Form
    {
        
        
        public FormChange change;
        public Form1()
        {
            InitializeComponent();
            change = new FormChange(this);
        }

        Controller C;


        private void btn_Load_Click(object sender, EventArgs e)
        {
            C = new Controller();

            C.btn_Load_Click();
            lb_Song = C.Reload(lb_Song);
        }



        protected void lb_Song_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_details = C.lb_Song_SelectedIndexChanged(lb_details, lb_Song);
        }



        private void lb_details_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            C.btn_Search_Click();
            lb_Song = C.Reload(lb_Song);
        }

        private void tb_Search_Input_Click(object sender, EventArgs e)
        {

        }




        private void tb_Search_Input_TextChanged(object sender, EventArgs e)
        {
            tb_Search_Input = C.tb_Search_Input_TextChanged(tb_Search_Input);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            C.btn_Save_Click();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {

        }

        private void btn_Chart_Click(object sender, EventArgs e)
        {
            FormChart chart = new FormChart();
            chart.Show();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {

            if (C.indexSelectedSong != -1)
            {
                change.GetInformation(C.database.Album[C.indexSelectedSong].Infos, C.database.Tags, C.indexSelectedSong);
                change.Show();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void newChange(List<string> newInfo, int newIndex)
        {
            C.database.Album[newIndex].Infos = newInfo;
            lb_Song = C.Reload(lb_Song);
        }
    }
}
