using System;

namespace petshop
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelLogIn = new System.Windows.Forms.Label();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(829, 60);
			this.label1.TabIndex = 0;
			this.label1.Text = "PET SHOP\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(26, 72);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(829, 477);
			this.panel1.TabIndex = 1;
			// 
			// labelLogIn
			// 
			this.labelLogIn.BackColor = System.Drawing.Color.Transparent;
			this.labelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogIn.Location = new System.Drawing.Point(32, 27);
			this.labelLogIn.Name = "labelLogIn";
			this.labelLogIn.Size = new System.Drawing.Size(209, 30);
			this.labelLogIn.TabIndex = 2;
			this.labelLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelLogIn.Click += new System.EventHandler(this.labelLogIn_Click);
			// 
			// btnLogOut
			// 
			this.btnLogOut.AutoSize = true;
			this.btnLogOut.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogOut.Location = new System.Drawing.Point(759, 27);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(93, 30);
			this.btnLogOut.TabIndex = 3;
			this.btnLogOut.Text = "LOG OUT";
			this.btnLogOut.UseVisualStyleBackColor = false;
			this.btnLogOut.Visible = false;
			this.btnLogOut.Click += new System.EventHandler(this.LogOutClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.labelLogIn);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label labelLogIn;
		private System.Windows.Forms.Button btnLogOut;
	}
}

