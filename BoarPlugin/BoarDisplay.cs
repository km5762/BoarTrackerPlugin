using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoarTrackerPlugin
{
    public partial class BoarDisplay : Form
    {
        private int count = 0;

        public BoarDisplay()
        {
            InitializeComponent();
        }

        public void incrementCounter()
        {
            count++;
            this.displayedCount.Text = this.count.ToString() + " | 7";
        }

        public void resetCounter()
        {
            count = 0;
            this.displayedCount.Text = this.count.ToString() + " | 7";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
