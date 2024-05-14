namespace WindowsFormsApp2
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using Database;
    using Entities;
    using FontAwesome.Sharp;

    public partial class frmCar : Form
    {
        private readonly DataAccess dataAccess = new DataAccess();
        private readonly Panel leftBorderBtn;

        private IconButton currentBtn;
        private Form currentChildForm;

        public frmCar()
        {
            InitializeComponent();
            CenterToScreen();

            // Panel
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            // Form
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        // *** PANEL BUTTONS *** //
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 102, 102);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                // Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = Color.FromArgb(178, 216, 216);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(0, 76, 76);
                currentBtn.ForeColor = Color.FromArgb(178, 216, 216);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(178, 216, 216);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            // open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            // End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(178, 216, 216);
            lblTitleChildForm.Text = "Home";
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 216, 216));
            OpenChildForm(new FormDashboard());
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 216, 216));
            OpenChildForm(new FormAddCar());
        }

        private void btnMenuDelete_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 216, 216));
            OpenChildForm(new FormDeleteCar());
        }

        private void btnMenuUpdate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 216, 216));
            OpenChildForm(new FormUpdateCar());
        }

        private void btnMenuSearch_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(178, 216, 216));
            OpenChildForm(new FormSearchCar());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }


        // Populate with 30 example cars
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] randomMakes =
                { "Toyota", "Ford", "VW", "Honda", "Nissan", "Mercedes-Benz", "BMW", "Audi", "Porsche", "Mazda" };
            string[] randomModels =
            {
                "M5", "Focus", "Civic", "A3", "Corolla", "Accord", "Golf", "Passat", "E90", "Auris", "Panamera", "F10"
            };
            string[] randomColors = { "Red", "Blue", "White", "Black", "Silver", "Gray" };

            for (int i = 0; i < 30; i++)
            {
                Car randomCar = new Car
                {
                    LicensePlate = "RA " + rnd.Next(1000, 9999) + " ND",
                    Model = randomModels[rnd.Next(randomModels.Length)],
                    Make = randomMakes[rnd.Next(randomMakes.Length)],
                    Color = randomColors[rnd.Next(randomColors.Length)],
                    Year = rnd.Next(1996, 2024),
                    Seats = rnd.Next(2, 8),
                    PriceForRepairing = rnd.Next(100, 25000)
                };
                dataAccess.CreateCar(randomCar);
            }

            MessageBox.Show("30 example cars populated successfully!");
        }

        // Delete All Cars Button
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all cars?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataAccess.DeleteAllCars();
            }
        }
    }
}