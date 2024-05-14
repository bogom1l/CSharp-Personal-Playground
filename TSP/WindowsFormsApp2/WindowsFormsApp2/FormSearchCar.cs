namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class FormSearchCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FormSearchCar()
        {
            InitializeComponent();
            DisplayAllCars();
            CustomizeDataGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string licensePlate = txtLicensePlate.Text.Trim();
                string model = txtModel.Text.Trim();
                string make = txtMake.Text.Trim();
                string color = txtColor.Text.Trim();
                string year = txtYear.Text.Trim();
                string seats = txtSeats.Text.Trim();
                string priceForRepairing = txtPriceForRepairing.Text.Trim();

                List<Car> filteredCars =
                    dataAccess.GetFilteredCars(licensePlate, model, make, color, year, seats, priceForRepairing);
                dataGridView1.DataSource = filteredCars;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnEmptyFields_Click(object sender, EventArgs e)
        {
            txtLicensePlate.Text = "";
            txtModel.Text = "";
            txtMake.Text = "";
            txtColor.Text = "";
            txtYear.Text = "";
            txtSeats.Text = "";
            txtPriceForRepairing.Text = "";
        }

        private void CustomizeDataGridView()
        {
            dataGridView1.GridColor = Color.FromArgb(34, 40, 49);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto Mono Medium", 8, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Roboto Mono Medium", 8, FontStyle.Regular);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.DefaultCellStyle.ForeColor = Color.White;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.ForeColor = Color.Black;
                column.MinimumWidth = 150;
            }
        }

        private void DisplayAllCars()
        {
            List<Car> allCars = dataAccess.GetAllCars();
            dataGridView1.DataSource = allCars;
        }
    }
}