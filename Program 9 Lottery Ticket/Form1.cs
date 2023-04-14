using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_9_Lottery_Ticket
{//coded by India Gonzales CIS 2324-001
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetMyTicket();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetMyTicket()
        {
            try
            {
                Lottery_Ticket myTicket = new Lottery_Ticket();

                const int SIZE = 5;
                int[] lotteryNumbers = new int[SIZE];

                for (int index = 0; index < lotteryNumbers.Length; index++)
                {
                    myTicket.Pick();
                    lotteryNumbers[index] = myTicket.GetNum();
                }
                Array.Sort(lotteryNumbers);

                label1.Text = lotteryNumbers[0].ToString();
                label2.Text = lotteryNumbers[1].ToString();
                label3.Text = lotteryNumbers[2].ToString();
                label4.Text = lotteryNumbers[3].ToString();
                label5.Text = lotteryNumbers[4].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GetWinningNumbers();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void GetWinningNumbers()
        {
            try
            {
                Lottery_Ticket winningTicket = new Lottery_Ticket();

                const int SIZE = 5;
                int[] lotteryNumbers = new int[SIZE];

                for (int index = 0; index < lotteryNumbers.Length; index++)
                {
                    winningTicket.Pick();
                    lotteryNumbers[index] = winningTicket.GetNum();
                }
                Array.Sort(lotteryNumbers);

                label6.Text = lotteryNumbers[0].ToString();
                label7.Text = lotteryNumbers[1].ToString();
                label8.Text = lotteryNumbers[2].ToString();
                label9.Text = lotteryNumbers[3].ToString();
                label10.Text = lotteryNumbers[4].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClearAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ClearAll()
        {
            try
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ExitForm();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ExitForm()
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
