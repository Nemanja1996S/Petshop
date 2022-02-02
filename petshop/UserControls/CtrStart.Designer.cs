namespace petshop.UserControls
{
	partial class CtrStart
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.lbIn = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labela = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRating = new System.Windows.Forms.Button();
            this.btnAllCities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available pet-shops in your city:";
            // 
            // lbIn
            // 
            this.lbIn.BackColor = System.Drawing.Color.Azure;
            this.lbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIn.FormattingEnabled = true;
            this.lbIn.ItemHeight = 24;
            this.lbIn.Location = new System.Drawing.Point(72, 74);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(231, 196);
            this.lbIn.TabIndex = 1;
            this.lbIn.SelectedIndexChanged += new System.EventHandler(this.LbIn_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.AutoSize = true;
            this.btnSort.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(112, 312);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(156, 30);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort by service type";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose service type";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // labela
            // 
            this.labela.BackColor = System.Drawing.Color.Azure;
            this.labela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(393, 74);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(275, 196);
            this.labela.TabIndex = 5;
            this.labela.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labela.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(706, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 160);
            this.panel1.TabIndex = 6;
            // 
            // btnAddRating
            // 
            this.btnAddRating.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRating.Location = new System.Drawing.Point(690, 74);
            this.btnAddRating.Name = "btnAddRating";
            this.btnAddRating.Size = new System.Drawing.Size(86, 31);
            this.btnAddRating.TabIndex = 7;
            this.btnAddRating.Text = "Add rating";
            this.btnAddRating.UseVisualStyleBackColor = false;
            this.btnAddRating.Visible = false;
            this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
            // 
            // btnAllCities
            // 
            this.btnAllCities.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAllCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllCities.Location = new System.Drawing.Point(151, 283);
            this.btnAllCities.Name = "btnAllCities";
            this.btnAllCities.Size = new System.Drawing.Size(75, 23);
            this.btnAllCities.TabIndex = 8;
            this.btnAllCities.Text = "All cities";
            this.btnAllCities.UseVisualStyleBackColor = false;
            this.btnAllCities.Click += new System.EventHandler(this.btnAllCities_Click);
            // 
            // CtrStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAllCities);
            this.Controls.Add(this.btnAddRating);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lbIn);
            this.Controls.Add(this.label1);
            this.Name = "CtrStart";
            this.Size = new System.Drawing.Size(800, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox lbIn;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label labela;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnAddRating;
		private System.Windows.Forms.Button btnAllCities;
	}
}
