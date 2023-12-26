namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using Database;
    using Entities;

    public partial class frmClient : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();

        public frmClient()
        {
            InitializeComponent();
            DisplayAllClients();
        }

        // Create
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtNumberOfPersId.Text == "" ||
                txtCity.Text == "" ||
                txtAddress.Text == "" ||
                txtPhone.Text == "")
            {
                MessageBox.Show("Please fill all the fields to create a client.");
            }
            else
            {
                try
                {
                    Client newClient = new Client
                    {
                        Name = txtName.Text,
                        NumberOfPersonalID = Convert.ToInt32(txtNumberOfPersId.Text),
                        City = txtCity.Text,
                        Address = txtAddress.Text,
                        Phone = txtPhone.Text
                    };

                    dataAccess.CreateClient(newClient);
                    DisplayAllClients();
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
                    int clientId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    Client clientToUpdate = dataAccess.GetAllClients().First(x => x.Id == clientId);

                    if (txtName.Text.Length != 0)
                    {
                        clientToUpdate.Name = txtName.Text;
                    }

                    if (txtNumberOfPersId.Text.Length != 0)
                    {
                        clientToUpdate.NumberOfPersonalID = Convert.ToInt32(txtNumberOfPersId.Text);
                    }

                    if (txtCity.Text.Length != 0)
                    {
                        clientToUpdate.City = txtCity.Text;
                    }

                    if (txtAddress.Text.Length != 0)
                    {
                        clientToUpdate.Address = txtAddress.Text;
                    }

                    if (txtPhone.Text.Length != 0)
                    {
                        clientToUpdate.Phone = txtPhone.Text;
                    }

                    dataAccess.UpdateClient(clientToUpdate);
                    DisplayAllClients();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a client to update.");
            }
        }

        // Delete
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int clientIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    dataAccess.DeleteClient(clientIdToDelete);

                    DisplayAllClients();
                }
            }
            else
            {
                MessageBox.Show("Please select a client to delete.");
            }
        }

        // Empty all fields
        private void button4_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNumberOfPersId.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        // Display all cars
        private void DisplayAllClients()
        {
            List<Client> allClients = dataAccess.GetAllClients();
            dataGridView1.DataSource = allClients;
        }
    }
}