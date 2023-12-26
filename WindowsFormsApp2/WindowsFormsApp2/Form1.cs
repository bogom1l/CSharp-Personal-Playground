namespace WindowsFormsApp2
{
    using System;
    using System.Windows.Forms;
    using Database;

    public partial class Form1 : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public Form1()
        {
            InitializeComponent();

            dataAccess.CreateCarTable();
            dataAccess.CreateClientTable();
            dataAccess.CreateRepairTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmCar = new frmCar();
            frmCar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmClient = new frmClient();
            frmClient.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmRepair = new frmRepair();
            frmRepair.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetClientsLeftCarsForRepairLast24Hours();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetMinMaxPriceForRepairByCarMake();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetUnpaidRepairedCars();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetPaidRepairedCars();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetTop3MostFrequentlyRepairedCars();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = dataAccess.GetTop1ClientSpentMostMoneyOnRepairs();
        }
    }
}