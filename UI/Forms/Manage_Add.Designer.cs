namespace Bank.UI.Forms
{
	partial class Manage_Add
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
			this.label2 = new System.Windows.Forms.Label();
			this.picForm = new System.Windows.Forms.PictureBox();
			this.lblForm = new System.Windows.Forms.Label();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkActive = new System.Windows.Forms.CheckBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.rdbTyprAdmin = new System.Windows.Forms.RadioButton();
			this.rdbTypeUser = new System.Windows.Forms.RadioButton();
			this.txtAccountID = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtRePassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblBrowser = new System.Windows.Forms.Label();
			this.picProfile = new System.Windows.Forms.PictureBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtmBirthday = new System.Windows.Forms.DateTimePicker();
			this.chkSexF = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIdentityCard = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.picChecked = new System.Windows.Forms.PictureBox();
			this.picCancel = new System.Windows.Forms.PictureBox();
			this.lblStatus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picForm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picChecked)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "User Name";
			// 
			// picForm
			// 
			this.picForm.BackColor = System.Drawing.Color.Transparent;
			this.picForm.Image = global::Bank.UI.Properties.Resources.add_user;
			this.picForm.Location = new System.Drawing.Point(12, 6);
			this.picForm.Name = "picForm";
			this.picForm.Size = new System.Drawing.Size(70, 70);
			this.picForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picForm.TabIndex = 12;
			this.picForm.TabStop = false;
			// 
			// lblForm
			// 
			this.lblForm.AutoSize = true;
			this.lblForm.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblForm.ForeColor = System.Drawing.Color.Blue;
			this.lblForm.Location = new System.Drawing.Point(88, 26);
			this.lblForm.Name = "lblForm";
			this.lblForm.Size = new System.Drawing.Size(67, 34);
			this.lblForm.TabIndex = 13;
			this.lblForm.Text = "ADD";
			// 
			// picClose
			// 
			this.picClose.BackColor = System.Drawing.Color.Transparent;
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = global::Bank.UI.Properties.Resources.close;
			this.picClose.Location = new System.Drawing.Point(541, 6);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(24, 24);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 14;
			this.picClose.TabStop = false;
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(97, 8);
			this.txtUsername.MaxLength = 50;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(144, 26);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.chkActive);
			this.panel1.Controls.Add(this.txtAmount);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.rdbTyprAdmin);
			this.panel1.Controls.Add(this.rdbTypeUser);
			this.panel1.Controls.Add(this.txtAccountID);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtRePassword);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtUsername);
			this.panel1.Location = new System.Drawing.Point(30, 82);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(535, 110);
			this.panel1.TabIndex = 24;
			// 
			// chkActive
			// 
			this.chkActive.AutoSize = true;
			this.chkActive.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkActive.Location = new System.Drawing.Point(452, 42);
			this.chkActive.Name = "chkActive";
			this.chkActive.Size = new System.Drawing.Size(68, 23);
			this.chkActive.TabIndex = 6;
			this.chkActive.Text = "Active";
			this.chkActive.UseVisualStyleBackColor = true;
			// 
			// txtAmount
			// 
			this.txtAmount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAmount.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtAmount.Location = new System.Drawing.Point(352, 70);
			this.txtAmount.MaxLength = 8;
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(144, 30);
			this.txtAmount.TabIndex = 7;
			this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(270, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 27);
			this.label11.TabIndex = 30;
			this.label11.Text = "Amount";
			// 
			// rdbTyprAdmin
			// 
			this.rdbTyprAdmin.AutoSize = true;
			this.rdbTyprAdmin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbTyprAdmin.Location = new System.Drawing.Point(257, 42);
			this.rdbTyprAdmin.Name = "rdbTyprAdmin";
			this.rdbTyprAdmin.Size = new System.Drawing.Size(114, 23);
			this.rdbTyprAdmin.TabIndex = 4;
			this.rdbTyprAdmin.Text = "Administrator";
			this.rdbTyprAdmin.UseVisualStyleBackColor = true;
			// 
			// rdbTypeUser
			// 
			this.rdbTypeUser.AutoSize = true;
			this.rdbTypeUser.Checked = true;
			this.rdbTypeUser.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbTypeUser.Location = new System.Drawing.Point(375, 42);
			this.rdbTypeUser.Name = "rdbTypeUser";
			this.rdbTypeUser.Size = new System.Drawing.Size(56, 23);
			this.rdbTypeUser.TabIndex = 5;
			this.rdbTypeUser.TabStop = true;
			this.rdbTypeUser.Text = "User";
			this.rdbTypeUser.UseVisualStyleBackColor = true;
			// 
			// txtAccountID
			// 
			this.txtAccountID.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAccountID.Location = new System.Drawing.Point(352, 8);
			this.txtAccountID.MaxLength = 6;
			this.txtAccountID.Name = "txtAccountID";
			this.txtAccountID.Size = new System.Drawing.Size(144, 26);
			this.txtAccountID.TabIndex = 3;
			this.txtAccountID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(270, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 19);
			this.label4.TabIndex = 26;
			this.label4.Text = "AccountID";
			// 
			// txtRePassword
			// 
			this.txtRePassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRePassword.Location = new System.Drawing.Point(97, 72);
			this.txtRePassword.MaxLength = 10;
			this.txtRePassword.Name = "txtRePassword";
			this.txtRePassword.Size = new System.Drawing.Size(144, 26);
			this.txtRePassword.TabIndex = 2;
			this.txtRePassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 19);
			this.label3.TabIndex = 24;
			this.label3.Text = "Re-Password";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(97, 40);
			this.txtPassword.MaxLength = 10;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(144, 26);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 19);
			this.label1.TabIndex = 22;
			this.label1.Text = "Password";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblBrowser);
			this.panel2.Controls.Add(this.picProfile);
			this.panel2.Controls.Add(this.txtAddress);
			this.panel2.Controls.Add(this.txtEmail);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.dtmBirthday);
			this.panel2.Controls.Add(this.chkSexF);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtLastName);
			this.panel2.Controls.Add(this.txtPhone);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtIdentityCard);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.txtFirstName);
			this.panel2.Location = new System.Drawing.Point(30, 198);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(535, 258);
			this.panel2.TabIndex = 30;
			// 
			// lblBrowser
			// 
			this.lblBrowser.AutoSize = true;
			this.lblBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblBrowser.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBrowser.Location = new System.Drawing.Point(496, 121);
			this.lblBrowser.Name = "lblBrowser";
			this.lblBrowser.Size = new System.Drawing.Size(31, 18);
			this.lblBrowser.TabIndex = 8;
			this.lblBrowser.Text = "•••";
			this.lblBrowser.Click += new System.EventHandler(this.lblBrowser_Click);
			// 
			// picProfile
			// 
			this.picProfile.BackColor = System.Drawing.Color.Transparent;
			this.picProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picProfile.Image = global::Bank.UI.Properties.Resources.no_camera;
			this.picProfile.Location = new System.Drawing.Point(417, 8);
			this.picProfile.Name = "picProfile";
			this.picProfile.Size = new System.Drawing.Size(110, 110);
			this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picProfile.TabIndex = 36;
			this.picProfile.TabStop = false;
			// 
			// txtAddress
			// 
			this.txtAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAddress.Location = new System.Drawing.Point(97, 192);
			this.txtAddress.MaxLength = 250;
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(423, 52);
			this.txtAddress.TabIndex = 7;
			this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
			this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(97, 160);
			this.txtEmail.MaxLength = 50;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(236, 26);
			this.txtEmail.TabIndex = 6;
			this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(6, 106);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 19);
			this.label12.TabIndex = 33;
			this.label12.Text = "Sex";
			// 
			// dtmBirthday
			// 
			this.dtmBirthday.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtmBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtmBirthday.Location = new System.Drawing.Point(97, 72);
			this.dtmBirthday.Name = "dtmBirthday";
			this.dtmBirthday.Size = new System.Drawing.Size(236, 26);
			this.dtmBirthday.TabIndex = 3;
			// 
			// chkSexF
			// 
			this.chkSexF.AutoSize = true;
			this.chkSexF.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkSexF.Location = new System.Drawing.Point(97, 104);
			this.chkSexF.Name = "chkSexF";
			this.chkSexF.Size = new System.Drawing.Size(71, 23);
			this.chkSexF.TabIndex = 4;
			this.chkSexF.Text = "Female";
			this.chkSexF.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 196);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 19);
			this.label10.TabIndex = 30;
			this.label10.Text = "Address";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 164);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 19);
			this.label9.TabIndex = 29;
			this.label9.Text = "Email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 19);
			this.label5.TabIndex = 28;
			this.label5.Text = "Phone";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(247, 8);
			this.txtLastName.MaxLength = 50;
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(86, 26);
			this.txtLastName.TabIndex = 1;
			this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
			this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
			// 
			// txtPhone
			// 
			this.txtPhone.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhone.Location = new System.Drawing.Point(97, 128);
			this.txtPhone.MaxLength = 10;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(236, 26);
			this.txtPhone.TabIndex = 5;
			this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(63, 19);
			this.label6.TabIndex = 24;
			this.label6.Text = "Birthday";
			// 
			// txtIdentityCard
			// 
			this.txtIdentityCard.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIdentityCard.Location = new System.Drawing.Point(97, 40);
			this.txtIdentityCard.MaxLength = 12;
			this.txtIdentityCard.Name = "txtIdentityCard";
			this.txtIdentityCard.Size = new System.Drawing.Size(236, 26);
			this.txtIdentityCard.TabIndex = 2;
			this.txtIdentityCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtIdentityCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 19);
			this.label7.TabIndex = 22;
			this.label7.Text = "Identity Card";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 12);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 19);
			this.label8.TabIndex = 5;
			this.label8.Text = "Name";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(97, 8);
			this.txtFirstName.MaxLength = 50;
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(144, 26);
			this.txtFirstName.TabIndex = 0;
			this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
			this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
			// 
			// picChecked
			// 
			this.picChecked.BackColor = System.Drawing.Color.Transparent;
			this.picChecked.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picChecked.Image = global::Bank.UI.Properties.Resources._checked;
			this.picChecked.Location = new System.Drawing.Point(216, 489);
			this.picChecked.Name = "picChecked";
			this.picChecked.Size = new System.Drawing.Size(56, 56);
			this.picChecked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picChecked.TabIndex = 36;
			this.picChecked.TabStop = false;
			this.picChecked.Click += new System.EventHandler(this.picChecked_Click);
			// 
			// picCancel
			// 
			this.picCancel.BackColor = System.Drawing.Color.Transparent;
			this.picCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picCancel.Image = global::Bank.UI.Properties.Resources.cancel;
			this.picCancel.Location = new System.Drawing.Point(321, 489);
			this.picCancel.Name = "picCancel";
			this.picCancel.Size = new System.Drawing.Size(56, 56);
			this.picCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCancel.TabIndex = 35;
			this.picCancel.TabStop = false;
			this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatus.ForeColor = System.Drawing.Color.Red;
			this.lblStatus.Location = new System.Drawing.Point(30, 462);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(535, 24);
			this.lblStatus.TabIndex = 37;
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Manage_Add
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Bank.UI.Properties.Resources.bkground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(586, 566);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.picChecked);
			this.Controls.Add(this.picCancel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.picClose);
			this.Controls.Add(this.lblForm);
			this.Controls.Add(this.picForm);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Manage_Add";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage_Add";
			this.Load += new System.EventHandler(this.Manage_Add_Load);
			((System.ComponentModel.ISupportInitialize)(this.picForm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picChecked)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox picForm;
		private System.Windows.Forms.Label lblForm;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkActive;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RadioButton rdbTyprAdmin;
		private System.Windows.Forms.RadioButton rdbTypeUser;
		private System.Windows.Forms.TextBox txtAccountID;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRePassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DateTimePicker dtmBirthday;
		private System.Windows.Forms.CheckBox chkSexF;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdentityCard;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label lblBrowser;
		private System.Windows.Forms.PictureBox picProfile;
		private System.Windows.Forms.PictureBox picChecked;
		private System.Windows.Forms.PictureBox picCancel;
		private System.Windows.Forms.Label lblStatus;
	}
}