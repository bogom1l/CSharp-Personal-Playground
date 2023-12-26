namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class frmCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public frmCar()
        {
            InitializeComponent();
            DisplayAllCars();
        }

        // Create a car
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLicensePlate.Text == "" || txtModel.Text == "" ||
                txtMake.Text == "" ||
                txtColor.Text == "" ||
                txtYear.Text == "" ||
                txtSeats.Text == "" ||
                txtPriceForRepairing.Text == "")
            {
                MessageBox.Show("Please fill all the fields to create a car.");
            }
            else
            {
                Car newCar = new Car
                {
                    LicensePlate = txtLicensePlate.Text,
                    Model = txtModel.Text,
                    Make = txtMake.Text,
                    Color = txtColor.Text,
                    Year = Convert.ToInt32(txtYear.Text),
                    Seats = Convert.ToInt32(txtSeats.Text),
                    PriceForRepairing = Convert.ToDouble(txtPriceForRepairing.Text)
                };

                dataAccess.CreateCar(newCar);
                DisplayAllCars();
            }
        }

        // Update a car
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
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
            else
            {
                MessageBox.Show("Please select a car to update.");
            }
        }

        // Delete a car
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int carIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                dataAccess.DeleteCar(carIdToDelete);

                DisplayAllCars();
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        // Display all cars
        private void DisplayAllCars()
        {
            List<Car> allCars = dataAccess.GetAllCars();
            dataGridView1.DataSource = allCars;
        }

        // Empty all fields
        private void button4_Click(object sender, EventArgs e)
        {
            txtLicensePlate.Text = "";
            txtModel.Text = "";
            txtMake.Text = "";
            txtColor.Text = "";
            txtYear.Text = "";
            txtSeats.Text = "";
            txtPriceForRepairing.Text = "";
        }
    }
}