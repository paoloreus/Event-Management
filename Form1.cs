using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars
{
    public partial class Form1 : Form
    {
       EventCoordinator eCoord = new EventCoordinator(200, 1000, 101, 5000);
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer nForm = new FrmCustomer(this, eCoord);
            this.Hide();
            nForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using Star Wars Management!", "Close Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formView vForm = new formView(this, "Paolo");
            this.Hide();
            vForm.Show();
            
        }
    }
}
