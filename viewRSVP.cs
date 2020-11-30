using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIpractice
{
    public partial class viewRSVP : Form
    {
        Form1 page;
        EventCoordinator eCoord;
        public viewRSVP()
        {
            InitializeComponent();
        }

        public viewRSVP(Form1 f1, EventCoordinator coordinator)
        {
            eCoord = coordinator;
            page = f1;
            InitializeComponent();
            textBox1.Text = eCoord.viewRegs();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            page.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
