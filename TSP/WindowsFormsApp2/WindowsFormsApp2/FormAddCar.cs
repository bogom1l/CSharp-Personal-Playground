namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class FormAddCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FormAddCar()
        {
            InitializeComponent();
            DisplayAllCars();
            CustomizeDataGridView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                try
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
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
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