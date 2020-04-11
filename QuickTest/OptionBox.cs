using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuickTest
{
    public partial class OptionBox : UserControl
    {
        public static string A;
        public static string B;
        public static string C;
        public static string D;
        public static string Selected;
        public OptionBox()
        {
            InitializeComponent();
        }

        private void OptionBox_Load(object sender, EventArgs e)
        {
            lblA.Text = A;
            lblB.Text = B;
            lblC.Text = C;
            lblD.Text = D;
        }

        private void radioA_CheckedChanged(object sender, EventArgs e)
        {
            Selected = radioA.Text;
        }

        private void radioB_CheckedChanged(object sender, EventArgs e)
        {
            Selected = radioB.Text;
        }

        private void radioC_CheckedChanged(object sender, EventArgs e)
        {
            Selected = radioC.Text;
        }

        private void radioD_CheckedChanged(object sender, EventArgs e)
        {
            Selected = radioD.Text;
        }
    }

        
    }
