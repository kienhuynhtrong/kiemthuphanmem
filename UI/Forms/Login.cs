using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bank.Business.HandleComponents;
using Bank.UI.Classes;

namespace Bank.UI.Forms
{
	public partial class Login : Form
	{
		#region -- Const/Enum/Struct --

		private const string STATUS01 = "UserName mustn't null.";
		private const string STATUS02 = "Password mustn't null.";
		private const string STATUS03 = "The specified account does not exist.";
		private const string STATUS04 = "That password is incorrect.";
		private const string STATUS05 = "Must have > 6 charaters!";

		#endregion -- Const/Enum/Struct --

		#region -- Constructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		public Login()
		{
			InitializeComponent();
		}

		#endregion -- Constructor/Destructor --

		#region -- Handle Methods --

		/// <summary>
		/// Check input
		/// </summary>
		/// <returns></returns>
		public bool CheckInput()
		{
			InputCheck check = new InputCheck();

            //Image img = Image.FromFile(@"C:\Users\kienh\Pictures\IMG_0155.png"); //địa chỉ cái hình ok
            //HandleData handle = new HandleData();
            //handle.InsertData("admin", "123456", "ST0001", 1, "272500000", "Hà Hoàng", "Hiệp", DateTime.Now, 0,
            //    "test1@gmail.com", "0123456789", "371 - Nguyễn Kiệm - P3 - Gò Vấp - Tp.Hồ Chí Minh", "10000000", 0, img);

            try
			{
				if (check.CheckIsEmpty(txtUserName.Text))
				{					
					txtUserName.Focus();
					lblStatus.Text = STATUS01;
					return false;
				}

				if (check.CheckIsEmpty(txtPassword.Text))
				{					
					txtPassword.Focus();
					lblStatus.Text = STATUS02;
					return false;
				}

				if (!check.CheckPWLength(txtPassword.Text))
				{					
					txtPassword.Text = String.Empty;
					lblStatus.Text = STATUS05;
					txtPassword.Focus();
					return false;
				}

				if (!check.CheckUSExist(txtUserName.Text))
				{
					lblStatus.Text = STATUS03;
					txtUserName.Focus();
					return false;
				}

				if (!check.CheckLogin(txtUserName.Text, txtPassword.Text))
				{					
					txtPassword.Text = String.Empty;
					txtPassword.Focus();
					lblStatus.Text = STATUS04;
					return false;
				}

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return true;
		}

		#endregion -- Handle Methods --

		#region -- Private Methods --

		/// <summary>
		/// Login account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			if(CheckInput())
			{
				Main frm = new Main(txtUserName.Text);
				frm.ShowDialog(this);
				this.Close();
			}	
		}

		/// <summary>
		/// Handle textchanged txtUser
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtUserName_TextChanged(object sender, EventArgs e)
		{
			lblStatus.Text = String.Empty;
			lblUsername.Visible = String.IsNullOrEmpty(txtUserName.Text);
		}

		/// <summary>
		/// Handle textchanged txtPassword
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtPassword_TextChanged(object sender, EventArgs e)
		{
			lblStatus.Text = String.Empty;
			lblPassword.Visible = String.IsNullOrEmpty(txtPassword.Text);
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
		/// Handle enter key txtPassword
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (CheckInput())
				{
					Main frm = new Main(txtUserName.Text);
					frm.ShowDialog(this);
					this.Close();
				}
			}
		}

		/// <summary>
		/// Handle enter key txtUser
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtUserName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				txtPassword.Focus();
		}

		#endregion --Private Methods --


	}
}
