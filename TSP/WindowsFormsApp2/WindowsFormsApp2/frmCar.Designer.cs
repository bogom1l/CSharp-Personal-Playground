namespace WindowsFormsApp2
{
    partial class frmCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenuDelete = new FontAwesome.Sharp.IconButton();
            this.btnMenuUpdate = new FontAwesome.Sharp.IconButton();
            this.btnMenuAdd = new FontAwesome.Sharp.IconButton();
            this.btnMenuSearch = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnMenuDelete);
            this.panelMenu.Controls.Add(this.btnMenuUpdate);
            this.panelMenu.Controls.Add(this.btnMenuAdd);
            this.panelMenu.Controls.Add(this.btnMenuSearch);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(233, 643);
            this.panelMenu.TabIndex = 25;
            // 
            // btnMenuDelete
            // 
            this.btnMenuDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuDelete.FlatAppearance.BorderSize = 0;
            this.btnMenuDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnMenuDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnMenuDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuDelete.IconSize = 36;
            this.btnMenuDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDelete.Location = new System.Drawing.Point(0, 363);
            this.btnMenuDelete.Name = "btnMenuDelete";
            this.btnMenuDelete.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnMenuDelete.Size = new System.Drawing.Size(233, 69);
            this.btnMenuDelete.TabIndex = 15;
            this.btnMenuDelete.Text = "Delete";
            this.btnMenuDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuDelete.UseVisualStyleBackColor = true;
            this.btnMenuDelete.Click += new System.EventHandler(this.btnMenuDelete_Click);
            // 
            // btnMenuUpdate
            // 
            this.btnMenuUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUpdate.FlatAppearance.BorderSize = 0;
            this.btnMenuUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnMenuUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnMenuUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuUpdate.IconSize = 36;
            this.btnMenuUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUpdate.Location = new System.Drawing.Point(0, 294);
            this.btnMenuUpdate.Name = "btnMenuUpdate";
            this.btnMenuUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnMenuUpdate.Size = new System.Drawing.Size(233, 69);
            this.btnMenuUpdate.TabIndex = 14;
            this.btnMenuUpdate.Text = "Update";
            this.btnMenuUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuUpdate.UseVisualStyleBackColor = true;
            this.btnMenuUpdate.Click += new System.EventHandler(this.btnMenuUpdate_Click);
            // 
            // btnMenuAdd
            // 
            this.btnMenuAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuAdd.FlatAppearance.BorderSize = 0;
            this.btnMenuAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnMenuAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnMenuAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuAdd.IconSize = 36;
            this.btnMenuAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAdd.Location = new System.Drawing.Point(0, 225);
            this.btnMenuAdd.Name = "btnMenuAdd";
            this.btnMenuAdd.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnMenuAdd.Size = new System.Drawing.Size(233, 69);
            this.btnMenuAdd.TabIndex = 13;
            this.btnMenuAdd.Text = "Add";
            this.btnMenuAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuAdd.UseVisualStyleBackColor = true;
            this.btnMenuAdd.Click += new System.EventHandler(this.btnMenuAdd_Click);
            // 
            // btnMenuSearch
            // 
            this.btnMenuSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnMenuSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuSearch.FlatAppearance.BorderSize = 0;
            this.btnMenuSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenuSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnMenuSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnMenuSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenuSearch.IconSize = 36;
            this.btnMenuSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSearch.Location = new System.Drawing.Point(0, 156);
            this.btnMenuSearch.Name = "btnMenuSearch";
            this.btnMenuSearch.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnMenuSearch.Size = new System.Drawing.Size(233, 69);
            this.btnMenuSearch.TabIndex = 12;
            this.btnMenuSearch.Text = "Search";
            this.btnMenuSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuSearch.UseVisualStyleBackColor = false;
            this.btnMenuSearch.Click += new System.EventHandler(this.btnMenuSearch_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 36;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 87);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnDashboard.Size = new System.Drawing.Size(233, 69);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 87);
            this.panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 36;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(12, 0, 23, 0);
            this.btnHome.Size = new System.Drawing.Size(233, 87);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Welcome!";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(233, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(843, 87);
            this.panelTitleBar.TabIndex = 26;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(775, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(22, 24);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.Location = new System.Drawing.Point(733, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(817, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitleChildForm.Location = new System.Drawing.Point(69, 33);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(56, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 37;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(26, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(37, 37);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.panelDesktop.Controls.Add(this.button2);
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(233, 87);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(843, 556);
            this.panelDesktop.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(637, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 82);
            this.button2.TabIndex = 22;
            this.button2.Text = "Delete All Cars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(440, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 86);
            this.button1.TabIndex = 21;
            this.button1.Text = "Populate With Random Cars";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(23, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "<- Update a car from the database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(23, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "<- Delete a car from the database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(23, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "<- Add a car to the database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "<- Search for a car";
            // 
            // frmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 643);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Name = "frmCar";
            this.Text = "frmCar";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMenuDelete;
        private FontAwesome.Sharp.IconButton btnMenuUpdate;
        private FontAwesome.Sharp.IconButton btnMenuAdd;
        private FontAwesome.Sharp.IconButton btnMenuSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}