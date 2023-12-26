namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class frmRepair : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public frmRepair()
        {
            InitializeComponent();
            DisplayAllRepairs();
        }


        // Create
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCarId.Text == "" || txtClientId.Text == "" ||
                txtStartDate.Text == "" ||
                txtEndDate.Text == "")
            {
                MessageBox.Show("Please fill all the fields to create a repair.");
            }
            else
            {
                try
                {
                    Repair newRepair = new Repair
                    {
                        CarId = Convert.ToInt32(txtCarId.Text),
                        ClientId = Convert.ToInt32(txtClientId.Text),
                        DateOfStartingRepair = txtStartDate.Text,
                        DateOfFinishingRepair = txtEndDate.Text,
                        IsPaid = checkBoxIsPaid.Checked,
                        IsReturned = checkBoxIsReturned.Checked
                    };

                    dataAccess.CreateRepair(newRepair);
                    DisplayAllRepairs();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        // Update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int repairId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    Repair repairToUpdate = dataAccess.GetAllRepairs().First(x => x.Id == repairId);

                    if (txtCarId.Text.Length != 0)
                    {
                        repairToUpdate.CarId = Convert.ToInt32(txtCarId.Text);
                    }

                    if (txtClientId.Text.Length != 0)
                    {
                        repairToUpdate.ClientId = Convert.ToInt32(txtClientId.Text);
                    }

                    if (txtStartDate.Text.Length != 0)
                    {
                        repairToUpdate.DateOfStartingRepair = txtStartDate.Text;
                    }

                    if (txtEndDate.Text.Length != 0)
                    {
                        repairToUpdate.DateOfFinishingRepair = txtEndDate.Text;
                    }

                    repairToUpdate.IsPaid = checkBoxIsPaid.Checked;
                    repairToUpdate.IsReturned = checkBoxIsReturned.Checked;

                    dataAccess.UpdateRepair(repairToUpdate);
                    DisplayAllRepairs();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a repair to update.");
            }
        }

        // Delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this repair?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int repairIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    dataAccess.DeleteRepair(repairIdToDelete);

                    DisplayAllRepairs();
                }
            }
            else
            {
                MessageBox.Show("Please select a repair to delete.");
            }
        }


        // Empty all fields
        private void button4_Click(object sender, EventArgs e)
        {
            txtCarId.Text = "";
            txtClientId.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            checkBoxIsPaid.Checked = false;
            checkBoxIsReturned.Checked = false;
        }


        // Display all repairs
        private void DisplayAllRepairs()
        {
            List<Repair> allRepairs = dataAccess.GetAllRepairs();
            dataGridView1.DataSource = allRepairs;
        }
    }
}