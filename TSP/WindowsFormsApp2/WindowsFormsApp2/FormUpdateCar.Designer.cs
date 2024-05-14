
namespace WindowsFormsApp2
{
    partial class FormUpdateCar
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
            this.btnEmptyFields = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPriceForRepairing = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmptyFields
            // 
            this.btnEmptyFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnEmptyFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmptyFields.FlatAppearance.BorderSize = 2;
            this.btnEmptyFields.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.btnEmptyFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmptyFields.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmptyFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnEmptyFields.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEmptyFields.IconColor = System.Drawing.Color.Black;
            this.btnEmptyFields.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmptyFields.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmptyFields.Location = new System.Drawing.Point(58, 236);
            this.btnEmptyFields.Name = "btnEmptyFields";
            this.btnEmptyFields.Size = new System.Drawing.Size(160, 30);
            this.btnEmptyFields.TabIndex = 113;
            this.btnEmptyFields.Text = "Empty All Fields";
            this.btnEmptyFields.UseVisualStyleBackColor = false;
            this.btnEmptyFields.Click += new System.EventHandler(this.btnEmptyFields_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(238, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 106;
            this.label3.Text = "Make";
            // 
            // txtMake
            // 
            this.txtMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtMake.Location = new System.Drawing.Point(242, 51);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(160, 20);
            this.txtMake.TabIndex = 100;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(58, 284);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 192);
            this.dataGridView1.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(238, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 108;
            this.label5.Text = "Year";
            // 
            // txtModel
            // 
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtModel.Location = new System.Drawing.Point(427, 51);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(160, 20);
            this.txtModel.TabIndex = 99;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(238, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 19);
            this.label7.TabIndex = 110;
            this.label7.Text = "Price For Repair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(423, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "Color";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.BackColor = System.Drawing.Color.Teal;
            this.txtLicensePlate.Font = new System.Drawing.Font("Roboto Mono Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.txtLicensePlate.Location = new System.Drawing.Point(58, 51);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(160, 22);
            this.txtLicensePlate.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(423, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 105;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "License Plate";
            // 
            // txtSeats
            // 
            this.txtSeats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtSeats.Location = new System.Drawing.Point(427, 121);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(160, 20);
            this.txtSeats.TabIndex = 111;
            // 
            // txtColor
            // 
            this.txtColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtColor.Location = new System.Drawing.Point(427, 192);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(160, 20);
            this.txtColor.TabIndex = 101;
            // 
            // txtYear
            // 
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtYear.Location = new System.Drawing.Point(242, 121);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(160, 20);
            this.txtYear.TabIndex = 102;
            // 
            // txtPriceForRepairing
            // 
            this.txtPriceForRepairing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.txtPriceForRepairing.Location = new System.Drawing.Point(242, 192);
            this.txtPriceForRepairing.Name = "txtPriceForRepairing";
            this.txtPriceForRepairing.Size = new System.Drawing.Size(160, 20);
            this.txtPriceForRepairing.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(423, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 109;
            this.label6.Text = "Seats";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(58, 84);
            this.btnSearch.MaximumSize = new System.Drawing.Size(160, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 30);
            this.btnSearch.TabIndex = 112;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto Mono Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(427, 236);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(160, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 30);
            this.btnUpdate.TabIndex = 114;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUpdateCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(1343, 671);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEmptyFields);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtPriceForRepairing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Name = "FormUpdateCar";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnEmptyFields;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPriceForRepairing;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnUpdate;
    }
}