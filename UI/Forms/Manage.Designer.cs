namespace Bank.UI.Forms
{
	partial class Manage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.grid = new System.Windows.Forms.DataGridView();
			this.mnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuMain_Add = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain_View = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain_Del = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.picDel = new System.Windows.Forms.PictureBox();
			this.picEdit = new System.Windows.Forms.PictureBox();
			this.picView = new System.Windows.Forms.PictureBox();
			this.picClose = new System.Windows.Forms.PictureBox();
			this.picAdd = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeAccount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IdentityCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sex = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CanDo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.mnuMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picDel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.BackgroundColor = System.Drawing.SystemColors.Control;
			this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.AccountID,
            this.TypeAccount,
            this.IdentityCard,
            this.FirstName,
            this.LastName,
            this.Birthday,
            this.Sex,
            this.Email,
            this.Phone,
            this.Address,
            this.Amount,
            this.CanDo,
            this.Picture,
            this.UserName,
            this.Password});
			this.grid.ContextMenuStrip = this.mnuMain;
			this.grid.GridColor = System.Drawing.SystemColors.Control;
			this.grid.Location = new System.Drawing.Point(12, 92);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(697, 257);
			this.grid.TabIndex = 0;
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain_Add,
            this.mnuMain_View,
            this.mnuMain_Edit,
            this.mnuMain_Del});
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuMain.Size = new System.Drawing.Size(167, 92);
			this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
			// 
			// mnuMain_Add
			// 
			this.mnuMain_Add.Image = global::Bank.UI.Properties.Resources.add_user;
			this.mnuMain_Add.Name = "mnuMain_Add";
			this.mnuMain_Add.ShortcutKeyDisplayString = "";
			this.mnuMain_Add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.mnuMain_Add.Size = new System.Drawing.Size(166, 22);
			this.mnuMain_Add.Text = "Add New";
			this.mnuMain_Add.ToolTipText = "Add new an Account";
			// 
			// mnuMain_View
			// 
			this.mnuMain_View.Image = global::Bank.UI.Properties.Resources.view;
			this.mnuMain_View.Name = "mnuMain_View";
			this.mnuMain_View.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.mnuMain_View.Size = new System.Drawing.Size(166, 22);
			this.mnuMain_View.Text = "View";
			this.mnuMain_View.ToolTipText = "View Account  Selected";
			// 
			// mnuMain_Edit
			// 
			this.mnuMain_Edit.Image = global::Bank.UI.Properties.Resources.edit;
			this.mnuMain_Edit.Name = "mnuMain_Edit";
			this.mnuMain_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.mnuMain_Edit.Size = new System.Drawing.Size(166, 22);
			this.mnuMain_Edit.Text = "Edit";
			this.mnuMain_Edit.ToolTipText = "Edit Account Selected";
			// 
			// mnuMain_Del
			// 
			this.mnuMain_Del.Image = global::Bank.UI.Properties.Resources.del;
			this.mnuMain_Del.Name = "mnuMain_Del";
			this.mnuMain_Del.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.mnuMain_Del.Size = new System.Drawing.Size(166, 22);
			this.mnuMain_Del.Text = "Delete";
			this.mnuMain_Del.ToolTipText = "Delete Account Selected";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(88, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picDel
			// 
			this.picDel.BackColor = System.Drawing.Color.Transparent;
			this.picDel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picDel.Image = global::Bank.UI.Properties.Resources.del;
			this.picDel.Location = new System.Drawing.Point(647, 66);
			this.picDel.Name = "picDel";
			this.picDel.Size = new System.Drawing.Size(20, 20);
			this.picDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picDel.TabIndex = 2;
			this.picDel.TabStop = false;
			this.toolTip1.SetToolTip(this.picDel, "Delete Account Selected");
			this.picDel.Click += new System.EventHandler(this.picDel_Click);
			// 
			// picEdit
			// 
			this.picEdit.BackColor = System.Drawing.Color.Transparent;
			this.picEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picEdit.Image = global::Bank.UI.Properties.Resources.edit;
			this.picEdit.Location = new System.Drawing.Point(621, 66);
			this.picEdit.Name = "picEdit";
			this.picEdit.Size = new System.Drawing.Size(20, 20);
			this.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picEdit.TabIndex = 3;
			this.picEdit.TabStop = false;
			this.toolTip1.SetToolTip(this.picEdit, "Edit Account Selected");
			this.picEdit.Click += new System.EventHandler(this.picEdit_Click);
			// 
			// picView
			// 
			this.picView.BackColor = System.Drawing.Color.Transparent;
			this.picView.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picView.Image = global::Bank.UI.Properties.Resources.view;
			this.picView.Location = new System.Drawing.Point(569, 66);
			this.picView.Name = "picView";
			this.picView.Size = new System.Drawing.Size(20, 20);
			this.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picView.TabIndex = 4;
			this.picView.TabStop = false;
			this.toolTip1.SetToolTip(this.picView, "View Account  Selected");
			this.picView.Click += new System.EventHandler(this.picView_Click);
			// 
			// picClose
			// 
			this.picClose.BackColor = System.Drawing.Color.Transparent;
			this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picClose.Image = global::Bank.UI.Properties.Resources.close;
			this.picClose.Location = new System.Drawing.Point(685, 6);
			this.picClose.Name = "picClose";
			this.picClose.Size = new System.Drawing.Size(24, 24);
			this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picClose.TabIndex = 8;
			this.picClose.TabStop = false;
			this.toolTip1.SetToolTip(this.picClose, "Close");
			this.picClose.Click += new System.EventHandler(this.picClose_Click);
			// 
			// picAdd
			// 
			this.picAdd.BackColor = System.Drawing.Color.Transparent;
			this.picAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picAdd.Image = global::Bank.UI.Properties.Resources.add_user;
			this.picAdd.Location = new System.Drawing.Point(595, 66);
			this.picAdd.Name = "picAdd";
			this.picAdd.Size = new System.Drawing.Size(20, 20);
			this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAdd.TabIndex = 9;
			this.picAdd.TabStop = false;
			this.toolTip1.SetToolTip(this.picAdd, "Add new an Account");
			this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Bank.UI.Properties.Resources.main_manageAccount;
			this.pictureBox1.Location = new System.Drawing.Point(12, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(70, 70);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// No
			// 
			this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.No.DataPropertyName = "No";
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
			this.No.DefaultCellStyle = dataGridViewCellStyle2;
			this.No.HeaderText = "No";
			this.No.Name = "No";
			this.No.ReadOnly = true;
			this.No.Width = 48;
			// 
			// AccountID
			// 
			this.AccountID.DataPropertyName = "AccountID";
			this.AccountID.HeaderText = "Account ID";
			this.AccountID.Name = "AccountID";
			this.AccountID.ReadOnly = true;
			// 
			// TypeAccount
			// 
			this.TypeAccount.DataPropertyName = "TypeAccount";
			this.TypeAccount.HeaderText = "Is User";
			this.TypeAccount.Name = "TypeAccount";
			this.TypeAccount.ReadOnly = true;
			this.TypeAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.TypeAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// IdentityCard
			// 
			this.IdentityCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.IdentityCard.DataPropertyName = "IdentityCard";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.IdentityCard.DefaultCellStyle = dataGridViewCellStyle3;
			this.IdentityCard.HeaderText = "Identity Card";
			this.IdentityCard.Name = "IdentityCard";
			this.IdentityCard.ReadOnly = true;
			this.IdentityCard.Width = 105;
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			this.FirstName.HeaderText = "First Name";
			this.FirstName.Name = "FirstName";
			this.FirstName.ReadOnly = true;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			this.LastName.ReadOnly = true;
			// 
			// Birthday
			// 
			this.Birthday.DataPropertyName = "Birthday";
			this.Birthday.HeaderText = "Birthday";
			this.Birthday.Name = "Birthday";
			this.Birthday.ReadOnly = true;
			// 
			// Sex
			// 
			this.Sex.DataPropertyName = "Sex";
			this.Sex.HeaderText = "Female";
			this.Sex.Name = "Sex";
			this.Sex.ReadOnly = true;
			this.Sex.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Sex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			// 
			// Phone
			// 
			this.Phone.DataPropertyName = "Phone";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Phone.DefaultCellStyle = dataGridViewCellStyle4;
			this.Phone.HeaderText = "Phone";
			this.Phone.Name = "Phone";
			this.Phone.ReadOnly = true;
			// 
			// Address
			// 
			this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Address.DataPropertyName = "Address";
			this.Address.HeaderText = "Address";
			this.Address.Name = "Address";
			this.Address.ReadOnly = true;
			this.Address.Width = 74;
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Amount.DefaultCellStyle = dataGridViewCellStyle5;
			this.Amount.HeaderText = "Amount";
			this.Amount.Name = "Amount";
			this.Amount.ReadOnly = true;
			// 
			// CanDo
			// 
			this.CanDo.DataPropertyName = "CanDo";
			this.CanDo.HeaderText = "Active";
			this.CanDo.Name = "CanDo";
			this.CanDo.ReadOnly = true;
			this.CanDo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.CanDo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// Picture
			// 
			this.Picture.DataPropertyName = "Picture";
			this.Picture.HeaderText = "Picture";
			this.Picture.Name = "Picture";
			this.Picture.ReadOnly = true;
			this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Picture.Visible = false;
			// 
			// UserName
			// 
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "UserName";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			this.UserName.Visible = false;
			// 
			// Password
			// 
			this.Password.DataPropertyName = "Password";
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			this.Password.Visible = false;
			// 
			// Manage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Bank.UI.Properties.Resources.bkground;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(721, 361);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.picAdd);
			this.Controls.Add(this.picClose);
			this.Controls.Add(this.picView);
			this.Controls.Add(this.picEdit);
			this.Controls.Add(this.picDel);
			this.Controls.Add(this.grid);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Manage";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage";
			this.Load += new System.EventHandler(this.Manage_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.mnuMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picDel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picDel;
		private System.Windows.Forms.PictureBox picEdit;
		private System.Windows.Forms.PictureBox picView;
		private System.Windows.Forms.PictureBox picClose;
		private System.Windows.Forms.ContextMenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem mnuMain_View;
		private System.Windows.Forms.ToolStripMenuItem mnuMain_Edit;
		private System.Windows.Forms.ToolStripMenuItem mnuMain_Del;
		private System.Windows.Forms.ToolStripMenuItem mnuMain_Add;
		private System.Windows.Forms.PictureBox picAdd;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn No;
		private System.Windows.Forms.DataGridViewTextBoxColumn AccountID;
		private System.Windows.Forms.DataGridViewCheckBoxColumn TypeAccount;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdentityCard;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Sex;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewCheckBoxColumn CanDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Picture;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
	}
}