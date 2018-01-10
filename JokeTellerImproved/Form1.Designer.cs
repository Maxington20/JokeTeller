namespace JokeTellerImproved
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
			this.lblProgramTitle = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSetup = new System.Windows.Forms.Button();
			this.btnPunchline = new System.Windows.Forms.Button();
			this.txtJoke = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblProgramTitle
			// 
			this.lblProgramTitle.AutoSize = true;
			this.lblProgramTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgramTitle.Location = new System.Drawing.Point(110, 21);
			this.lblProgramTitle.Name = "lblProgramTitle";
			this.lblProgramTitle.Size = new System.Drawing.Size(157, 24);
			this.lblProgramTitle.TabIndex = 0;
			this.lblProgramTitle.Text = "The Joke Teller";
			// 
			// btnExit
			// 
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Location = new System.Drawing.Point(55, 276);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnReset
			// 
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.Location = new System.Drawing.Point(253, 276);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSetup
			// 
			this.btnSetup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSetup.Location = new System.Drawing.Point(83, 189);
			this.btnSetup.Name = "btnSetup";
			this.btnSetup.Size = new System.Drawing.Size(75, 23);
			this.btnSetup.TabIndex = 3;
			this.btnSetup.Text = "Setup";
			this.btnSetup.UseVisualStyleBackColor = true;
			this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
			// 
			// btnPunchline
			// 
			this.btnPunchline.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPunchline.Enabled = false;
			this.btnPunchline.Location = new System.Drawing.Point(210, 189);
			this.btnPunchline.Name = "btnPunchline";
			this.btnPunchline.Size = new System.Drawing.Size(75, 23);
			this.btnPunchline.TabIndex = 4;
			this.btnPunchline.Text = "Punchline";
			this.btnPunchline.UseVisualStyleBackColor = true;
			this.btnPunchline.Click += new System.EventHandler(this.btnPunchline_Click);
			// 
			// txtJoke
			// 
			this.txtJoke.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtJoke.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtJoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtJoke.Location = new System.Drawing.Point(55, 103);
			this.txtJoke.Multiline = true;
			this.txtJoke.Name = "txtJoke";
			this.txtJoke.ReadOnly = true;
			this.txtJoke.Size = new System.Drawing.Size(273, 39);
			this.txtJoke.TabIndex = 5;
			this.txtJoke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(378, 325);
			this.Controls.Add(this.txtJoke);
			this.Controls.Add(this.btnPunchline);
			this.Controls.Add(this.btnSetup);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblProgramTitle);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProgramTitle;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnSetup;
		private System.Windows.Forms.Button btnPunchline;
		private System.Windows.Forms.TextBox txtJoke;
	}
}

