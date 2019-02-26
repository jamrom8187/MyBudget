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
    public partial class AddCards : Form
    {
        public AddCards()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Card1.Hide();
                Card2.Hide();
                Card3.Hide();
                Card4.Hide();
                Card5.Hide();
                Card6.Hide();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();

                MessageBox.Show("You have selected 0 cards");

            }
           else if (comboBox1.SelectedIndex == 1)
            {
                Card1.Show();
                Card2.Hide();
                Card3.Hide();
                Card4.Hide();
                Card5.Hide();
                Card6.Hide();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Card1.Show();
                Card2.Show();
                Card3.Hide();
                Card4.Hide();
                Card5.Hide();
                Card6.Hide();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Hide();
                Card5.Hide();
                Card6.Hide();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Hide();
                Card6.Hide();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 5)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Hide();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 6)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Hide();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 7)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Hide();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 8)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Hide();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 9)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Hide();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 10)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Show();
                Card11.Hide();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 11)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Show();
                Card11.Show();
                Card12.Hide();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 12)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Show();
                Card11.Show();
                Card12.Show();
                Card13.Hide();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 13)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Show();
                Card11.Show();
                Card12.Show();
                Card13.Show();
                Card14.Hide();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 14)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Show();
                Card11.Show();
                Card12.Show();
                Card13.Show();
                Card14.Show();
                Card15.Hide();


            }
            else if (comboBox1.SelectedIndex == 15)
            {
                Card1.Show();
                Card2.Show();
                Card3.Show();
                Card4.Show();
                Card5.Show();
                Card6.Show();
                Card7.Show();
                Card8.Show();
                Card9.Show();
                Card10.Show();
                Card11.Show();
                Card12.Show();
                Card13.Show();
                Card14.Show();
                Card15.Show();


            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Card1.Hide();
            Card2.Hide();
            Card3.Hide();
            Card4.Hide();
            Card5.Hide();
            Card6.Hide();
            Card7.Hide();
            Card8.Hide();
            Card9.Hide();
            Card10.Hide();
            Card11.Hide();
            Card12.Hide();
            Card13.Hide();
            Card14.Hide();
            Card15.Hide();
        }

        private void addTo_Click(object sender, EventArgs e)
        {
            List<decimal> creditCardsList = new List<decimal>();

            creditCardsList.Add(Convert.ToDecimal(Card1.Text));
            creditCardsList.Add(Convert.ToDecimal(Card2.Text));
            creditCardsList.Add(Convert.ToDecimal(Card3.Text));
            creditCardsList.Add(Convert.ToDecimal(Card4.Text));
            creditCardsList.Add(Convert.ToDecimal(Card5.Text));
            creditCardsList.Add(Convert.ToDecimal(Card6.Text));
            creditCardsList.Add(Convert.ToDecimal(Card7.Text));
            creditCardsList.Add(Convert.ToDecimal(Card8.Text));
            creditCardsList.Add(Convert.ToDecimal(Card9.Text));
            creditCardsList.Add(Convert.ToDecimal(Card10.Text));
            creditCardsList.Add(Convert.ToDecimal(Card11.Text));
            creditCardsList.Add(Convert.ToDecimal(Card12.Text));
            creditCardsList.Add(Convert.ToDecimal(Card13.Text));
            creditCardsList.Add(Convert.ToDecimal(Card14.Text));
            creditCardsList.Add(Convert.ToDecimal(Card15.Text));

            Form1 mainForm = new Form1();
            

            this.Owner.Controls.Find("creditPayments", true).First().Text = Convert.ToString(creditCardsList.Sum());
            this.Close();
        }
    }
}
