namespace Bank.UI.Forms
{
	partial class Transfer
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblAccountID = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtRePassword = new System.Windows.Forms.TextBox();
			this.picCancel = new System.Windows.Forms.PictureBox();
			this.picChecked = new System.Windows.Forms.PictureBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtToAccountID = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picChecked)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(88, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Transfer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Account ID";
			// 
			// picClose
			// 
			this.picClose.BackColor = System.Drawing.Color.Transparent;
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = global::Bank.UI.Properties.Resources.close;
			this.picClose.Location = new System.Drawing.Point(370, 6);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(24, 24);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 7;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "Amount";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Password";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(32, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 24);
			this.label5.TabIndex = 11;
			this.label5.Text = "Re-password";
			// 
			// lblAccountID
			// 
			this.lblAccountID.AutoSize = true;
			this.lblAccountID.BackColor = System.Drawing.Color.Transparent;
			this.lblAccountID.Enabled = false;
			this.lblAccountID.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAccountID.Location = new System.Drawing.Point(164, 86);
			this.lblAccountID.Name = "lblAccountID";
			this.lblAccountID.Size = new System.Drawing.Size(103, 24);
			this.lblAccountID.TabIndex = 12;
			this.lblAccountID.Text = "Account ID";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(164, 194);
			this.txtPassword.MaxLength = 6;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(180, 31);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			// 
			// txtRePassword
			// 
			this.txtRePassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRePassword.Location = new System.Drawing.Point(164, 231);
			this.txtRePassword.MaxLength = 6;
			this.txtRePassword.Name = "txtRePassword";
			this.txtRePassword.Size = new System.Drawing.Size(180, 31);
			this.txtRePassword.TabIndex = 3;
			this.txtRePassword.UseSystemPasswordChar = true;
			this.txtRePassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
			// 
			// picCancel
			// 
			this.picCancel.BackColor = System.Drawing.Color.Transparent;
			this.picCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picCancel.Image = global::Bank.UI.Properties.Resources.cancel;
			this.picCancel.Location = new System.Drawing.Point(234, 292);
			this.picCancel.Name = "picCancel";
			this.picCancel.Size = new System.Drawing.Size(56, 56);
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCancel.TabIndex = 16;
			this.picCancel.TabStop = false;
			this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
			// 
			// picChecked
			// 
			this.picChecked.BackColor = System.Drawing.Color.Transparent;
			this.picChecked.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picChecked.Image = global::Bank.UI.Properties.Resources._checked;
			this.picChecked.Location = new System.Drawing.Point(119, 292);
			this.picChecked.Name = "picChecked";
			this.picChecked.Size = new System.Drawing.Size(56, 56);
			this.picChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picChecked.TabIndex = 17;
			this.picChecked.TabStop = false;
			this.picChecked.Click += new System.EventHandler(this.picChecked_Click);
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmount.Location = new System.Drawing.Point(164, 157);
			this.txtAmount.MaxLength = 8;
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(180, 31);
			this.txtAmount.TabIndex = 1;
			this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.Red;
			this.lblStatus.Location = new System.Drawing.Point(36, 265);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(308, 24);
			this.lblStatus.TabIndex = 19;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtToAccountID
			// 
			this.txtToAccountID.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtToAccountID.Location = new System.Drawing.Point(164, 120);
			this.txtToAccountID.MaxLength = 6;
			this.txtToAccountID.Name = "txtToAccountID";
			this.txtToAccountID.Size = new System.Drawing.Size(180, 31);
			this.txtToAccountID.TabIndex = 0;
			this.txtToAccountID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtToAccountID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToAccountID_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(32, 123);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(127, 24);
			this.label6.TabIndex = 20;
			this.label6.Text = "To Account ID";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Bank.UI.Properties.Resources.main_transfer;
			this.pictureBox1.Location = new System.Drawing.Point(12, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// Transfer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Bank.UI.Properties.Resources.bkground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(400, 368);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtToAccountID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.picChecked);
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.txtRePassword);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblAccountID);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.picClose);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Transfer";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transfer";
			this.Load += new System.EventHandler(this.Transfer_Load);
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picChecked)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblAccountID;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtRePassword;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.PictureBox picChecked;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.TextBox txtToAccountID;
		private System.Windows.Forms.Label label6;


		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
	}
}