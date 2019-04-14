using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using Bank.UI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bank.UI.Forms
{
	public partial class Manage_Add : Form
	{

		#region -- Const/Enum/Struct --

		private string typeForm;
		private AccountDataSet.AccountRow dr;

		private const string STATUS01 = "Must have value!";
		private const string STATUS02 = "Must >= 50000!";
		private const string STATUS03 = "Re-password is incorrect!";
		private const string STATUS04 = "Must have > 6 charaters!";
		private const string STATUS05 = "Amount is not Enough!";
		private const string STATUS06 = "Not exist Account!";
		private const string STATUS07 = "Exist this Username!";
		private const string STATUS08 = "Birthday is not > {0}";
		private const string STATUS09 = "Success!";
		private const string STATUS10 = "Failed!";
		private const string STATUS11 = "Must > 18 age!";
		private const string STATUS12 = "Email is incorrect!";

		private const string TYPEVIEW = "VIEW";
		private const string TYPEEDIT = "EDIT";

		#endregion -- Const/Enum/Struct --	

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		public Manage_Add()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="ptypeForm"></param>
		/// <param name="pRow"></param>
		public Manage_Add(string ptypeForm, AccountDataSet.AccountRow pRow)
		{
			InitializeComponent();
			dr = pRow;
			typeForm = ptypeForm;

		}

		#endregion -- Contructor/Destructor --

		#region -- Handle Methods --

		/// <summary>
		/// Load form view
		/// </summary>
		private void LoadView()
		{
			this.Size = new Size(this.Size.Width, this.Size.Height - 95);
			picForm.Image = Properties.Resources.view;
			lblForm.Text = TYPEVIEW;

			txtUsername.Enabled
		  = txtPassword.Enabled
		  = txtRePassword.Enabled
		  = txtAccountID.Enabled
		  = txtAmount.Enabled
		  = txtFirstName.Enabled
		  = txtLastName.Enabled
		  = txtIdentityCard.Enabled
		  = txtPhone.Enabled
		  = txtEmail.Enabled
		  = txtAddress.Enabled
		  = chkActive.Enabled
		  = chkSexF.Enabled
		  = dtmBirthday.Enabled
		  = lblBrowser.Enabled
		  = rdbTypeUser.Enabled
		  = rdbTyprAdmin.Enabled

		  = picCancel.Visible
		  = picChecked.Visible
		  = false;

			txtAccountID.Text = dr.AccountID;
			txtAmount.Text = dr.Amount;
			txtFirstName.Text = dr.FirstName;
			txtLastName.Text = dr.LastName;
			txtPhone.Text = dr.Phone;
			txtEmail.Text = dr.Email;
			txtAddress.Text = dr.Address;
			dtmBirthday.Text = dr.Birthday;
			txtIdentityCard.Text = dr.IdentityCard;
			picProfile.Image = new Encrypt().DecryptImage(dr.Picture);
			chkSexF.Checked = (Convert.ToInt32(dr.Sex) == 1) ? true : false;
			chkActive.Checked = (Convert.ToInt32(dr.CanDo) == 0) ? true : false;
			if (Convert.ToInt32(dr.TypeAccount) == 0)
				rdbTypeUser.Checked = true;
			else
				rdbTyprAdmin.Checked = true;
		}

		/// <summary>
		/// Load form Edit
		/// </summary>
		private void LoadEdit()
		{
			picForm.Image = Properties.Resources.edit;
			lblForm.Text = TYPEEDIT;

			txtUsername.Enabled
		  = txtPassword.Enabled
		  = txtRePassword.Enabled
		  = txtAccountID.Enabled
		  = false;

			txtAccountID.Text = dr.AccountID;
			txtAmount.Text = dr.Amount;
			txtFirstName.Text = dr.FirstName;
			txtLastName.Text = dr.LastName;
			txtPhone.Text = dr.Phone;
			txtEmail.Text = dr.Email;
			txtAddress.Text = dr.Address;
			dtmBirthday.Text = dr.Birthday;
			txtIdentityCard.Text = dr.IdentityCard;
			picProfile.Image = new Encrypt().DecryptImage(dr.Picture);
			chkSexF.Checked = (Convert.ToInt32(dr.Sex) == 1) ? true : false;
			chkActive.Checked = (Convert.ToInt32(dr.CanDo) == 0) ? true : false;
			if (Convert.ToInt32(dr.TypeAccount) == 0)
				rdbTypeUser.Checked = true;
			else
				rdbTyprAdmin.Checked = true;
		}

		/// <summary>
		/// Check Input
		/// </summary>
		/// <returns></returns>
		public bool CheckInput()
		{
			InputCheck check = new InputCheck();

			#region  Check Username

			if (check.CheckIsEmpty(txtUsername.Text))
			{
				lblStatus.Text = STATUS01;
				txtUsername.Focus();
				return false;
			}

			if (!check.CheckUSExist(txtUsername.Text))
			{
				lblStatus.Text = STATUS07;
				txtUsername.Focus();
				return false;
			}

			#endregion Check Username

			#region Check Password/Repassword

			if (check.CheckIsEmpty(txtPassword.Text))
			{
				lblStatus.Text = STATUS01;
				txtPassword.Focus();
				return false;
			}

			if (!check.CheckPWLength(txtPassword.Text))
			{
				lblStatus.Text = STATUS04;
				txtPassword.Focus();
				return false;
			}

			if (check.CheckIsEmpty(txtRePassword.Text))
			{
				lblStatus.Text = STATUS01;
				txtRePassword.Focus();
				return false;
			}

			if (!check.CheckPWLength(txtRePassword.Text))
			{
				lblStatus.Text = STATUS04;
				txtRePassword.Focus();
				return false;
			}

			if (!check.CheckPW(txtPassword.Text, txtRePassword.Text))
			{
				lblStatus.Text = STATUS03;
				txtRePassword.Focus();
				return false;
			}

			#endregion Check Password/Repassword

			#region Check AccountID

			if (check.CheckIsEmpty(txtAccountID.Text))
			{
				lblStatus.Text = STATUS01;
				txtAccountID.Focus();
				return false;
			}
			if (!check.CheckIDExist(txtAccountID.Text))
			{
				lblStatus.Text = STATUS06;
				txtAccountID.Focus();
				return false;
			}

			if (!check.CheckIDLength(txtAccountID.Text))
			{
				lblStatus.Text = STATUS04;
				txtAccountID.Focus();
				return false;
			}
			#endregion Check AccountID

			#region Check Amount

			if (check.CheckIsEmpty(txtAmount.Text))
			{
				lblStatus.Text = STATUS01;
				txtAmount.Focus();
				return false;
			}

			if (check.CheckMinAmount(txtAmount.Text))
			{
				lblStatus.Text = STATUS02;
				txtAmount.Focus();
				return false;
			}

			#endregion Check Amount

			#region Check Name

			if (check.CheckIsEmpty(txtFirstName.Text))
			{
				lblStatus.Text = STATUS01;
				txtFirstName.Focus();
				return false;
			}
			if (check.CheckIsEmpty(txtLastName.Text))
			{
				lblStatus.Text = STATUS01;
				txtLastName.Focus();
				return false;
			}


			#endregion Check Name

			#region Check Identity Card

			if (check.CheckIsEmpty(txtIdentityCard.Text))
			{
				lblStatus.Text = STATUS01;
				txtIdentityCard.Focus();
				return false;
			}

			#endregion Check Identity Card

			#region Check Birthday

			if (check.CheckBirthDay(dtmBirthday.Value))
			{
				lblStatus.Text = String.Format(STATUS08, DateTime.Today.ToShortDateString());
				dtmBirthday.Focus();
				return false;
			}

			if (check.CheckYearBD(dtmBirthday.Value))
			{
				lblStatus.Text = STATUS11;
				dtmBirthday.Focus();
				return false;
			}

			#endregion Check Birthday

			#region Check Phone
			if (check.CheckIsEmpty(txtPhone.Text))
			{
				lblStatus.Text = STATUS01;
				txtPhone.Focus();
				return false;
			}

			#endregion Check Phone

			#region Check Email

			if (check.CheckIsEmpty(txtEmail.Text))
			{
				lblStatus.Text = STATUS01;
				txtEmail.Focus();
				return false;
			}

			if (check.CheckEmail(txtEmail.Text))
			{
				lblStatus.Text = STATUS12;
				txtEmail.Focus();
				return false;
			}

			#endregion Check Email

			#region Check Address

			if (check.CheckIsEmpty(txtAddress.Text))
			{
				lblStatus.Text = STATUS01;
				txtAddress.Focus();
				return false;
			}

			#endregion  Check Address

			return true;
		}

		/// <summary>
		/// Do Update an Account
		/// </summary>
		public void UpdateData()
		{
			try
			{
				HandleData handle = new HandleData();
				if (handle.UpdateData(txtAccountID.Text, (rdbTypeUser.Checked) ? 0 : 1,
					txtIdentityCard.Text, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), dtmBirthday.Value, (chkSexF.Checked) ? 1 : 0,
					txtEmail.Text, txtPhone.Text, txtAddress.Text.Trim(), txtAmount.Text, chkActive.Checked ? 0 : 1, picProfile.Image))
				{

					MessageBox.Show(this, STATUS09, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
					picChecked.Visible = picCancel.Visible = false;
				}
				else
					MessageBox.Show(this, STATUS10, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				picChecked.Visible = picCancel.Visible = true;
				throw ex;
			}
		}

		/// <summary>
		/// Do Insert an Account
		/// </summary>
		public void InsertData()
		{
			try
			{
				HandleData handle = new HandleData();
				if (handle.InsertData(txtUsername.Text, txtPassword.Text, txtAccountID.Text, (rdbTypeUser.Checked) ? 0 : 1,
					txtIdentityCard.Text, txtFirstName.Text.Trim(), txtLastName.Text.Trim(), dtmBirthday.Value, (chkSexF.Checked) ? 1 : 0,
					txtEmail.Text, txtPhone.Text, txtAddress.Text.Trim(), txtAmount.Text, chkActive.Checked ? 0 : 1, picProfile.Image))
				{

					MessageBox.Show(this, STATUS09, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
					picChecked.Visible = picCancel.Visible = false;
				}
				else
					MessageBox.Show(this, STATUS10, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		#endregion -- Handle Methods --

		#region -- Private Methods --

		/// <summary>
		/// Handle Only input number
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Visible = false;
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Handle cant input " "
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Visible = false;
			if (Char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Handle Insert or update data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picChecked_Click(object sender, EventArgs e)
		{
			if (CheckInput())
			{
				if (String.Equals(TYPEEDIT, typeForm))
				{
					DialogResult result = MessageBox.Show(this, String.Format("Confirm to Edit {0}", txtAccountID.Text)
					   , "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
						UpdateData();
				}
				else
				{
					DialogResult result = MessageBox.Show(this, String.Format("Confirm to Add {0}", txtAccountID.Text)
					, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
						InsertData();
				}
			}
		}

		/// <summary>
		/// Handle choose file image
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblBrowser_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Select Image";
				dlg.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					picProfile.Image = Image.FromFile(dlg.FileName);
				}
			}
		}

		/// <summary>
		/// Close form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// clean data input
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picCancel_Click(object sender, EventArgs e)
		{
			if (picChecked.Visible)
			{
				picProfile.Image = Properties.Resources.no_camera;

				txtUsername.Text
			  = txtPassword.Text
			  = txtRePassword.Text
			  = txtAccountID.Text
			  = txtAmount.Text
			  = txtFirstName.Text
			  = txtLastName.Text
			  = txtIdentityCard.Text
			  = txtPhone.Text
			  = txtEmail.Text
			  = txtAddress.Text
			  = String.Empty;
			}
		}

		/// <summary>
		/// Load form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Manage_Add_Load(object sender, EventArgs e)
		{
			if (String.Equals(TYPEVIEW, typeForm))
			{
				LoadView();
			}
			if (String.Equals(TYPEEDIT, typeForm))
			{
				LoadEdit();
			}
		}

		/// <summary>
		/// Hide lblStatus
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Text = String.Empty;
		}

		/// <summary>
		/// Handle edit Name
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtFirstName_Leave(object sender, EventArgs e)
		{
			string name = txtFirstName.Text.Trim();
			string[] text = name.Split(' ');
			name = String.Empty;
			foreach (string item in text)
			{
				name = name + item + " ";
			}
			txtFirstName.Text = name;
		}

		/// <summary>
		/// Handle edit name
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtLastName_TextChanged(object sender, EventArgs e)
		{
			string name = txtLastName.Text.Trim();
			string[] text = name.Split(' ');
			name = String.Empty;
			foreach (string item in text)
			{
				name = name + item + " ";
			}
			txtLastName.Text = name;
		}

		/// <summary>
		/// handle edit address
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtAddress_Leave(object sender, EventArgs e)
		{
			string name = txtAddress.Text.Trim();
			string[] text = name.Split(' ');
			name = String.Empty;
			foreach (string item in text)
			{
				name = name + item + " ";
			}
			txtAddress.Text = name;
		}

		#endregion -- Private Methods --

	}
}

