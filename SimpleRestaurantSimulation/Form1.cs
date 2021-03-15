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
    enum menu { NoDrink, Tea, Cola, Pepsi };
    enum status { Busy, Free };
    public partial class Form1 : Form
    {
        Server server = new Server();
        Cook cook = new Cook();
        Cook cook2 = new Cook();

        public Form1()
        {
            InitializeComponent();
        }

        private void receiveRequestCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                menu drink = (menu)Enum.Parse(typeof(menu), typeDrink.SelectedItem.ToString());
                server.Receive(int.Parse(quantityChicken.Text), int.Parse(quantityEgg.Text), drink, customerName.Text);
            }
            catch (Exception ex)
            {
                textResult.Text = ex.Message;
            }

        }

        private async void sendCustomerRequestsCook_Click(object sender, EventArgs e)
        {
            try
            {
                textResult.Text = "";

                if (server.Tr == null)
                {
                    throw new NullReferenceException("order not sent to the Cook");
                }

                if (cook.Status == status.Busy)
                {
                    cook2.Tr = server.Tr;
                    server.Send();
                    await cook2.Process();
                    await server.Serve(cook2.Tr);
                    showResult();
                }
                else
                {
                    //TODO: What if the 2nd cook is busy
                    cook.Tr = server.Tr;
                    server.Send();
                    await cook.Process();
                    await server.Serve(cook.Tr);
                    showResult();
                }


            }
            catch (Exception ex)
            {
                textResult.Text = ex.Message;
            }
        }

        private void showResult()
        {
            try
            {
                string[] result = server.Result;
                if (result == null || result.Length == 0)
                {
                    throw new NullReferenceException("order not sent to the Cook");
                }
                for (int i = 0; i < result.Length; i++)
                {
                    textResult.AppendText(result[i]);
                    textResult.AppendText(Environment.NewLine);
                }

                textResult.AppendText("Please enjoy your food!");
                textResult.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                textResult.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Enum.GetValues(typeof(menu)).Length; i++)
            {
                typeDrink.Items.Add(((menu)i).ToString());
            }
            typeDrink.SelectedIndex = 0;

        }
    }
}
