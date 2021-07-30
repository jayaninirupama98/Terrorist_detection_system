using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class Selection : Form
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPrincipal mm = new FrmPrincipal();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataM mm = new DataM();
            mm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginnew mm = new loginnew();
            mm.Show();
        }
    }
}
