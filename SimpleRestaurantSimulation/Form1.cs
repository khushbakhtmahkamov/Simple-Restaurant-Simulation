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

        //TODO: There are 3 tables. Server receives from these customers:
        //table 1: Customer a: 10 Chicken, 10 egg, Tea
        //table 2: Customer b: 10 Chicken, 10 egg, Cola
        //table 3: Customer c: 10 Chicken, 10 egg, Pepsi

        //Server clicks Send button after receiving each customer. 
        //The result is showing like this now:
        /*  Customer a is served Cola, 10 chicken, 10 egg
            Please enjoy your food!
            Customer b is served Tea, 10 chicken, 10 egg
            Please enjoy your food!
            Customer c is served Pepsi 10 chicken, 10 egg
            Please enjoy your food!
        */
        /*But it should show drinks firts. like this:  
         *  Customer a is served Cola   [Here write "table #1" or "Please enjoy your drink!"]
         *  Customer b is served Tea    [Here write "table #2" or "Please enjoy your drink!"]
         *  Customer c is served Pepsi  [Here write "table #3" or "Please enjoy your drink!"]
         *  Customer a is served 10 chicken, 10 egg
                Please enjoy your food!
         *  Customer b is served 10 chicken, 10 egg
                Please enjoy your food!                
         *  Customer c is served 10 chicken, 10 egg
                Please enjoy your food!
            */
        private async void sendCustomerRequestsCook_Click(object sender, EventArgs e)
        {
            try
            {
                //textResult.Text = "";

                if (server.Tr == null)
                {
                    throw new NullReferenceException("order not sent to the Cook");
                }
                Boolean b = true;
                TableRequests tr = server.Tr;
                server.Send();
                while (b)
                {
                    if (cook.Status == status.Free)
                    {
                        await cook.Process(tr);
                        await server.Serve(tr);
                        showResult();
                        b = false;
                    }
                    else if (cook2.Status == status.Free)
                    {
                        await cook2.Process(tr);
                        await server.Serve(tr);
                        showResult();
                        b = false;
                    }
                    System.Threading.Thread.Sleep(1000);
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
