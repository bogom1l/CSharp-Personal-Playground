namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class FormUpdateCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FormUpdateCar()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int carId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    Car carToUpdate = dataAccess.GetAllCars().First(x => x.Id == carId);

                    if (txtLicensePlate.Text.Length != 0)
                    {
                        carToUpdate.LicensePlate = txtLicensePlate.Text;
                    }

                    if (txtModel.Text.Length != 0)
                    {
                        carToUpdate.Model = txtModel.Text;
                    }

                    if (txtMake.Text.Length != 0)
                    {
                        carToUpdate.Make = txtMake.Text;
                    }

                    if (txtColor.Text.Length != 0)
                    {
                        carToUpdate.Color = txtColor.Text;
                    }

                    if (txtYear.Text.Length != 0)
                    {
                        carToUpdate.Year = Convert.ToInt32(txtYear.Text);
                    }

                    if (txtSeats.Text.Length != 0)
                    {
                        carToUpdate.Seats = Convert.ToInt32(txtSeats.Text);
                    }

                    if (txtPriceForRepairing.Text.Length != 0)
                    {
                        carToUpdate.PriceForRepairing = Convert.ToDouble(txtPriceForRepairing.Text);
                    }

                    dataAccess.UpdateCar(carToUpdate);
                    DisplayAllCars();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a car to update.");
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