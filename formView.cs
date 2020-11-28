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
    public partial class formView : Form
    {
        Form1 page;
        EventCoordinator eCoord;
        CustomerManager cm;
        int x = 0;
        int y = 18;
        public formView()
        {
            InitializeComponent();
        }

        public formView(Form1 f1, EventCoordinator coordinator)
        {
            page = f1;
            InitializeComponent();
            Label[] labels = new Label[coordinator.getNumCustomers()];
            Label[] fields = new Label[coordinator.getNumCustomers()];
           
            for(int i = 0; i < coordinator.getNumCustomers(); i++)
            {
                /* lblid.Text = coordinator.getCustomerList()[i].getId().ToString();
                 lblName.Text = coordinator.getCustomerList()[i].getFirstName();
                 lblLast.Text = coordinator.getCustomerList()[i].getLastName();
                 lblPhone.Text = coordinator.getCustomerList()[i].getPhone(); */

                fields[i] = new Label();
                fields[i].Text = "Customer ID:";
                fields[i].Location = new Point((x + 70), y);
                

                labels[i] = new Label();
                labels[i].Text = coordinator.getCustomerList()[i].getId().ToString();
                labels[i].Location = new Point((x + 70), y);

                this.Controls.Add(fields[i]);
                this.Controls.Add(labels[i]);

                fields[i].Show();
                labels[i].Show();





            }
            
        }
        private void formView_Load(object sender, EventArgs e)
        {

            //setting up first name
            /*Label lblFirstName = new Label();
            lblFirstName.Text = coordinator.getCustomerList()[i].getFirstName();
            lblFirstName.Location = new Point(400, 60);
            lblFirstName.AutoSize = true;
            this.Controls.Add(lblFirstName);

            //setting up last name
            Label lblLastName = new Label();
            lblLastName.Text = coordinator.getCustomerList()[i].getLastName();
            lblLastName.Location = new Point(400, 100);
            lblLastName.AutoSize = true;
            this.Controls.Add(lblLastName);

            //setting up phone
            Label lblPhoneNum = new Label();
            lblPhoneNum.Text = coordinator.getCustomerList()[i].getPhone();
            lblPhoneNum.Location = new Point(400, 140);
            lblPhoneNum.AutoSize = true;
            this.Controls.Add(lblPhoneNum); */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            page.Show();
        }
    }
}
