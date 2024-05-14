namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class FormDeleteCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public FormDeleteCar()
        {
            InitializeComponent();
            DisplayAllCars();
            CustomizeDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this car?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int carIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    dataAccess.DeleteCar(carIdToDelete);

                    DisplayAllCars();
                }
            }
            else
            {
                MessageBox.Show("Please select a car to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string licensePlate = txtLicensePlate.Text.Trim();

                List<Car> filteredCars =
                    dataAccess.GetFilteredCars(licensePlate, null, null, null, null, null, null);
                dataGridView1.DataSource = filteredCars;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
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