using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyBudget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public void submit_Click(object sender, EventArgs e)
        {
            BudgetPropertys bProperty = new BudgetPropertys();
            //Starts the income section
            var amounts = new List<decimal>();
                        
            amounts.Add(numberConvert(payCheck1.Text));
            amounts.Add(numberConvert(payCheck2.Text));
            amounts.Add(numberConvert(payCheck3.Text));
            amounts.Add(numberConvert(payCheck4.Text));






            decimal sum = amounts.Sum();

            incomeOutput.Text = "$" + Convert.ToString(sum);


            // Starts the Uncontrolable section
            var uncontrols = new List<decimal>();


            bProperty.Car = numberConvert(carPayment.Text);
            bProperty.Insurance = numberConvert(insrancesPayment.Text);
            bProperty.Utilties = numberConvert(uPayments.Text);
            bProperty.House = numberConvert(rentPayment.Text);
            bProperty.Goods = numberConvert(houseHoldPayment.Text);
            bProperty.Fuel = numberConvert(fuelPayment.Text);

            uncontrols.Add(bProperty.Car);
            uncontrols.Add(bProperty.Insurance);
            uncontrols.Add(bProperty.House);
            uncontrols.Add(bProperty.Goods);
            uncontrols.Add(bProperty.Utilties);
            uncontrols.Add(bProperty.Fuel);

            decimal uncontrol = uncontrols.Sum();


            uncontrolOutput.Text = "$" + Convert.ToString(uncontrol);

            //Starts the Controlable Section
            var controls = new List<decimal>();

            bProperty.Cards = numberConvert(creditPayments.Text);
            bProperty.Savings = numberConvert(savingsPayment.Text);

            controls.Add(bProperty.Cards);
            controls.Add(bProperty.Savings);

            decimal control = controls.Sum();

            controlOutput.Text = "$" + Convert.ToString(control);

            decimal expenses = control + uncontrol;

            expensesOutput.Text = "$" + Convert.ToString(expenses);

            leftoverOutput.Text = "$" + Convert.ToString(sum - expenses);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //We have to give owner ship to Form2 inorder for it to update the credit card amount. and then we open the window to allow user
            // to enter the credit card amounts to be added.
            AddCards cCards = new AddCards();
            cCards.Owner = (Form)this;
            cCards.Show();
        }

        private void creditPayments_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void creditPayments_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.creditPayments, "test");
        }

        //This method takes the check that is passed in as a string and checks to make sure that value isnt null. if it is then 
        //it will give it a 0 value and then convert it to decimal. 
        public static decimal numberConvert(string amount)
        {
           
            if (amount == null)
            {
                amount = "0";
            }
            decimal returnAmount;

            decimal.TryParse(amount, out returnAmount);

            return returnAmount;

        }
    }
}
