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
    public partial class Form1 : Form
    {
        Server server = new Server();
        Cook cook = new Cook();

        public Form1()
        {
            //server.Ready += cook.Process;
            //cook.Processed += server.Serve;
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
                server.Send();
                await cook.Process(server.Tr);
                await server.Serve();
                showResult();
              
                
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
                textResult.Text = "";
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
