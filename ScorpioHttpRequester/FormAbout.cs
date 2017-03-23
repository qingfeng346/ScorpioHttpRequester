using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScorpioHttpRequester
{
    public partial class FormAbout : Form
    {
        
        public FormAbout()
        {
            InitializeComponent();
        }
        private void FormAbout_Load(object sender, EventArgs e)
        {
            label1.Text = "当前版本 : " + Util.Version;
;       }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.OpenUrl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Util.CheckVersion(true);
        }
    }
}
