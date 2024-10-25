using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_1_assingment_GUI_Part_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDivid.Visible = false;   
            lblAdd.Visible = false;
            lblMulti.Visible = false;
            lblSub.Visible = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            lblDivid.Visible = false;
            lblAdd.Visible = false;
            lblMulti.Visible = false;
            lblSub.Visible = false; lblAdd.Visible = true;
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {

            lblDivid.Visible = false;
            lblAdd.Visible = false;
            lblMulti.Visible = false;
            lblSub.Visible = false; lblDivid.Visible=true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAdd_Click(object sender, EventArgs e)
        {

        }

        private void lblSub_Click(object sender, EventArgs e)
        {

        }

        private void lblDivid_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblDivid.Visible = false;
            lblAdd.Visible = false;
            lblMulti.Visible = false;
            lblSub.Visible = false;
            lblSub.Visible = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            lblDivid.Visible = false;
            lblAdd.Visible = false;
            lblMulti.Visible = false;
            lblSub.Visible = false;
            lblMulti.Visible = true;
        }
    }
}
