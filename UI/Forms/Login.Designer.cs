namespace Bank.UI.Forms
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.pcbAccount = new System.Windows.Forms.PictureBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblUsername = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pcbAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			this.SuspendLayout();
			// 
			// txtUserName
			// 
			this.txtUserName.BackColor = System.Drawing.SystemColors.Window;
			this.txtUserName.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtUserName.Location = new System.Drawing.Point(19, 223);
			this.txtUserName.MaxLength = 50;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(235, 31);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
			this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
			// 
			// pcbAccount
			// 
			this.pcbAccount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.pcbAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pcbAccount.BackColor = System.Drawing.Color.Transparent;
			this.pcbAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pcbAccount.Enabled = false;
			this.pcbAccount.Image = global::Bank.UI.Properties.Resources.user;
			this.pcbAccount.Location = new System.Drawing.Point(73, 55);
			this.pcbAccount.Name = "pcbAccount";
			this.pcbAccount.Size = new System.Drawing.Size(128, 128);
			this.pcbAccount.TabIndex = 1;
			this.pcbAccount.TabStop = false;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuText;
			this.txtPassword.Location = new System.Drawing.Point(19, 259);
			this.txtPassword.MaxLength = 10;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(235, 31);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
			this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.Indigo;
			this.btnLogin.Location = new System.Drawing.Point(19, 296);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(235, 31);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.BackColor = System.Drawing.SystemColors.Window;
			this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblUsername.Location = new System.Drawing.Point(29, 226);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(92, 25);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.BackColor = System.Drawing.SystemColors.Window;
			this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.lblPassword.Location = new System.Drawing.Point(29, 262);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(85, 25);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Password";
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lblStatus.ForeColor = System.Drawing.Color.LavenderBlush;
			this.lblStatus.Location = new System.Drawing.Point(19, 203);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(235, 17);
			this.lblStatus.TabIndex = 4;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// picClose
			// 
			this.picClose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.picClose.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picClose.BackColor = System.Drawing.Color.Transparent;
			this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = global::Bank.UI.Properties.Resources.cancel;
			this.picClose.Location = new System.Drawing.Point(243, 3);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(30, 30);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 5;
			this.picClose.TabStop = false;
			this.toolTip1.SetToolTip(this.picClose, "Close this Application");
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.ToolTipTitle = "Close";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = global::Bank.UI.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(275, 410);
			this.Controls.Add(this.picClose);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.pcbAccount);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)(this.pcbAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.PictureBox pcbAccount;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}