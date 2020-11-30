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
    public partial class RSVPforEvent : Form
    {
        Form1 page;
        EventCoordinator eCoord;
        RSVP rsvp;

        public RSVPforEvent()
        {
            InitializeComponent();
        }

        public RSVPforEvent(Form1 f1, EventCoordinator coordinator)
        {
            eCoord = coordinator;
            page = f1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(textBox1.Text);
            int eid = Convert.ToInt32(textBox2.Text);
            if(eCoord.register(cid, eid))
            {
                
                string s = rsvp.generateTicket(eid, cid);
                MessageBox.Show("RSVP Successful\n" + s);
            }
            else
            {
                MessageBox.Show("RSVP Unsuccessful, check the inputs");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            page.Show();
        }
    }
}
