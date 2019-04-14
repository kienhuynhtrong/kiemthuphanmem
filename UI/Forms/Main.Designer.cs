namespace Bank.UI.Forms
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.lblName = new System.Windows.Forms.Label();
			this.picManage = new System.Windows.Forms.PictureBox();
			this.picTransfer = new System.Windows.Forms.PictureBox();
			this.picWithdrawal = new System.Windows.Forms.PictureBox();
			this.picDeposit = new System.Windows.Forms.PictureBox();
			this.picInfor = new System.Windows.Forms.PictureBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.picLogout = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picManage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTransfer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picWithdrawal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDeposit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picInfor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.Color.Orange;
			this.lblName.Location = new System.Drawing.Point(371, 394);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(229, 23);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name user";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// picManage
			// 
			this.picManage.BackColor = System.Drawing.Color.Transparent;
			this.picManage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picManage.Image = global::Bank.UI.Properties.Resources.main_manageAccount;
			this.picManage.Location = new System.Drawing.Point(164, 210);
			this.picManage.Name = "picManage";
			this.picManage.Size = new System.Drawing.Size(96, 96);
			this.picManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picManage.TabIndex = 6;
			this.picManage.TabStop = false;
			this.toolTip.SetToolTip(this.picManage, "Manage Account");
			this.picManage.Click += new System.EventHandler(this.picManage_Click);
			// 
			// picTransfer
			// 
			this.picTransfer.BackColor = System.Drawing.Color.Transparent;
			this.picTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picTransfer.Image = global::Bank.UI.Properties.Resources.main_transfer;
			this.picTransfer.Location = new System.Drawing.Point(492, 72);
			this.picTransfer.Name = "picTransfer";
			this.picTransfer.Size = new System.Drawing.Size(96, 96);
			this.picTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picTransfer.TabIndex = 5;
			this.picTransfer.TabStop = false;
			this.toolTip.SetToolTip(this.picTransfer, "Transfer Money");
			this.picTransfer.Click += new System.EventHandler(this.picTransfer_Click);
			// 
			// picWithdrawal
			// 
			this.picWithdrawal.BackColor = System.Drawing.Color.Transparent;
			this.picWithdrawal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picWithdrawal.Image = global::Bank.UI.Properties.Resources.main_withdrawal;
			this.picWithdrawal.Location = new System.Drawing.Point(277, 72);
			this.picWithdrawal.Name = "picWithdrawal";
			this.picWithdrawal.Size = new System.Drawing.Size(96, 96);
			this.picWithdrawal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picWithdrawal.TabIndex = 4;
			this.picWithdrawal.TabStop = false;
			this.toolTip.SetToolTip(this.picWithdrawal, "Withdrawal");
			this.picWithdrawal.Click += new System.EventHandler(this.picWithdrawal_Click);
			// 
			// picDeposit
			// 
			this.picDeposit.BackColor = System.Drawing.Color.Transparent;
			this.picDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picDeposit.Image = global::Bank.UI.Properties.Resources.main_deposit;
			this.picDeposit.Location = new System.Drawing.Point(62, 72);
			this.picDeposit.Name = "picDeposit";
			this.picDeposit.Size = new System.Drawing.Size(96, 96);
			this.picDeposit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picDeposit.TabIndex = 3;
			this.picDeposit.TabStop = false;
			this.toolTip.SetToolTip(this.picDeposit, "Deposit\r\n");
			this.picDeposit.Click += new System.EventHandler(this.picDeposit_Click);
			// 
			// picInfor
			// 
			this.picInfor.BackColor = System.Drawing.Color.Transparent;
			this.picInfor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picInfor.Image = global::Bank.UI.Properties.Resources.main_information;
			this.picInfor.Location = new System.Drawing.Point(390, 210);
			this.picInfor.Name = "picInfor";
			this.picInfor.Size = new System.Drawing.Size(96, 96);
			this.picInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picInfor.TabIndex = 2;
			this.picInfor.TabStop = false;
			this.toolTip.SetToolTip(this.picInfor, "Infomation");
			this.picInfor.Click += new System.EventHandler(this.picInfor_Click);
			// 
			// picLogout
			// 
			this.picLogout.BackColor = System.Drawing.Color.Transparent;
			this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picLogout.Image = global::Bank.UI.Properties.Resources.main_logout;
			this.picLogout.Location = new System.Drawing.Point(606, 389);
			this.picLogout.Name = "picLogout";
			this.picLogout.Size = new System.Drawing.Size(32, 32);
			this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogout.TabIndex = 7;
			this.picLogout.TabStop = false;
			this.toolTip.SetToolTip(this.picLogout, "Logout");
			this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::Bank.UI.Properties.Resources.main_background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(650, 433);
			this.Controls.Add(this.picLogout);
			this.Controls.Add(this.picManage);
			this.Controls.Add(this.picTransfer);
			this.Controls.Add(this.picWithdrawal);
			this.Controls.Add(this.picDeposit);
			this.Controls.Add(this.picInfor);
			this.Controls.Add(this.lblName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Main_Load);
			((System.ComponentModel.ISupportInitialize)(this.picManage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTransfer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picWithdrawal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDeposit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picInfor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.PictureBox picInfor;
		private System.Windows.Forms.PictureBox picDeposit;
		private System.Windows.Forms.PictureBox picWithdrawal;
		private System.Windows.Forms.PictureBox picTransfer;
		private System.Windows.Forms.PictureBox picManage;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.PictureBox picLogout;
	}
}