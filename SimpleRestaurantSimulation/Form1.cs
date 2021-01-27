using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleRestaurantSimulation
{
    public partial class Form1 : Form
    {
        Employee employee;
        Object o;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitNewRequest_Click(object sender, EventArgs e)
        {
            employee = new Employee();
            string itemMenu = "chicken";
            if (egg.Checked)
            {
                itemMenu = "egg";
            }
            o= employee.NewRequest(int.Parse(textQuantity.Text.ToString()), itemMenu);
            TextQualityResult.Text= employee.Inspect(o);
        }

        private void copyThePreviousRequest_Click(object sender, EventArgs e)
        {
            o = employee.CopyRequest();
            TextQualityResult.Text = employee.Inspect(o);
        }

        private void prepareFood_Click(object sender, EventArgs e)
        {
            textResult.Text = employee.PrepareFood(o);
        }
    }
}
