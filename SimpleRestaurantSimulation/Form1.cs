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
            try
            {
                //TODO: You should not create new Employee everytime when you click submit button. It should be only one enployee.
                employee = new Employee();
                string itemMenu = "chicken";
                if (egg.Checked)
                {
                    itemMenu = "egg";
                }
                o = employee.NewRequest(int.Parse(textQuantity.Text.ToString()), itemMenu);
                TextQualityResult.Text = employee.Inspect(o);
            }
            catch (Exception ex)
            {
                textResult.Text = ex.Message;
            }
            
        }

        private void copyThePreviousRequest_Click(object sender, EventArgs e)
        {
            try
            {
                o = employee.CopyRequest();
                TextQualityResult.Text = employee.Inspect(o);
            }
            catch (Exception ex)
            {

                textResult.Text = ex.Message;
            }
            
        }
        //TODO: I clicked this button twice and I'm getting this message in resultbox: "Exception of type 'System.Exception' was thrown.". This message is not clear. Please correct this.
        private void prepareFood_Click(object sender, EventArgs e)
        {
            try
            {
                textResult.Text = employee.PrepareFood(o);
            }
            catch (Exception ex)
            {

                textResult.Text = ex.Message;
            }
            
        }
    }
}
