
namespace WindowsFormsApp2
{
    partial class FormAddCar
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
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceForRepairing = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmptyFields = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(427, 196);
            this.btnAdd.MaximumSize = new System.Drawing.Size(160, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 78;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(58, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 192);
            this.dataGridView1.TabIndex = 62;
            // 
            // txtColor
            // 
            this.txtColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtColor.Location = new System.Drawing.Point(427, 135);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(160, 20);
            this.txtColor.TabIndex = 66;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtLicensePlate.Location = new System.Drawing.Point(242, 135);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(160, 20);
            this.txtLicensePlate.TabIndex = 63;
            // 
            // txtModel
            // 
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtModel.Location = new System.Drawing.Point(242, 65);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(160, 20);
            this.txtModel.TabIndex = 64;
            // 
            // txtMake
            // 
            this.txtMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtMake.Location = new System.Drawing.Point(58, 65);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(160, 20);
            this.txtMake.TabIndex = 65;
            // 
            // txtSeats
            // 
            this.txtSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtSeats.Location = new System.Drawing.Point(58, 135);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(160, 20);
            this.txtSeats.TabIndex = 77;
            // 
            // txtYear
            // 
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtYear.Location = new System.Drawing.Point(427, 65);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(160, 20);
            this.txtYear.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(54, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 76;
            this.label7.Text = "Price For Repair";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(54, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "Seats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(238, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "License Plate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(423, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Year";
            // 
            // txtPriceForRepairing
            // 
            this.txtPriceForRepairing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtPriceForRepairing.Location = new System.Drawing.Point(58, 206);
            this.txtPriceForRepairing.Name = "txtPriceForRepairing";
            this.txtPriceForRepairing.Size = new System.Drawing.Size(160, 20);
            this.txtPriceForRepairing.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(423, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(238, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 71;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.label3.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(54, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "Make";
            // 
            // btnEmptyFields
            // 
            this.btnEmptyFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnEmptyFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmptyFields.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnEmptyFields.FlatAppearance.BorderSize = 2;
            this.btnEmptyFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.btnEmptyFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyFields.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmptyFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnEmptyFields.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEmptyFields.IconColor = System.Drawing.Color.Black;
            this.btnEmptyFields.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmptyFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyFields.Location = new System.Drawing.Point(242, 196);
            this.btnEmptyFields.Name = "btnEmptyFields";
            this.btnEmptyFields.Size = new System.Drawing.Size(160, 30);
            this.btnEmptyFields.TabIndex = 79;
            this.btnEmptyFields.Text = "Empty All Fields";
            this.btnEmptyFields.UseVisualStyleBackColor = false;
            this.btnEmptyFields.Click += new System.EventHandler(this.btnEmptyFields_Click);
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1343, 671);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEmptyFields);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPriceForRepairing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Name = "FormAddCar";
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPriceForRepairing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnEmptyFields;
    }
}