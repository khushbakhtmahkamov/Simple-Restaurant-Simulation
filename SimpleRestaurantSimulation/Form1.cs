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
    enum typeDrinkList { NoDrink, Tea, Coffee, Juice, Water, Cola, Pepsi };
    public partial class Form1 : Form
    {
        enum menu {Chicken, Egg, TypesDrink};
        Server server = new Server();

        Employee employee = new Employee();
        Object o;
        public Form1()
        {
            InitializeComponent();
        }

        private void submitNewRequest_Click(object sender, EventArgs e)
        {
            try
            {                
                string itemMenu = "chicken";
                //if (egg.Checked)
                {
                    itemMenu = "egg";
                }
               // o = employee.NewRequest(int.Parse(textQuantity.Text.ToString()), itemMenu);
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

        private void receiveRequestCustomer_Click(object sender, EventArgs e)
        {
            //server.Receive(int.Parse(quantityChicken.Text),int.Parse(quantityEgg.Text),typeDrink.se;

           // MessageBox.Show(typeDrink.SelectedValue.ToString());
        }

        private void sendCustomerRequestsCook_Click(object sender, EventArgs e)
        {

        }

        private void serveFoodCustomers_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeDrink.DataSource = Enum.GetValues(typeof(typeDrinkList));
        }
    }
}
