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
using System.Windows.Forms;

namespace Bank.UI.Forms
{
	public partial class Transfer : Form
	{

		#region -- Const/Enum/Struct --

		AccountDataSet.AccountRow dr;
		private const string STATUS01 = "Must have value!";
		private const string STATUS02 = "Must >= 50000!";
		private const string STATUS03 = "Re-password is incorrect!";
		private const string STATUS04 = "Must have > 6 charaters!";
		private const string STATUS05 = "Amount is not Enough!";
		private const string STATUS06 = "Not exist Account!";
		private const string STATUS07 = "Success!";
		private const string STATUS08 = "Failed!";
		private const string STATUS09 = "Account was Denied!";
		private const string STATUS10 = "Must < 10000000!";

		#endregion -- Const/Enum/Struct --

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="pRow"></param>
		public Transfer(AccountDataSet.AccountRow pRow)
		{
			InitializeComponent();
			this.dr = pRow;
		}

		#endregion -- Contructor/Destructor --

		#region -- Handle Methods --

		/// <summary>
		/// Check Input
		/// </summary>
		/// <returns></returns>
		private bool CheckInput()
		{
			InputCheck check = new InputCheck();

			//Check To AccountID
			if (check.CheckIsEmpty(txtToAccountID.Text))
			{
				lblStatus.Text = STATUS01;
				txtToAccountID.Focus();
				return false;
			}
			if (!check.CheckIDExist(txtToAccountID.Text))
			{
				lblStatus.Text = STATUS06;
				txtToAccountID.Focus();
				return false;
			}

			if(!check.CheckIDState(txtToAccountID.Text))
			{
				lblStatus.Text = STATUS09;
				txtToAccountID.Focus();
				return false;
			}
			//Check Amount
			if (check.CheckIsEmpty(txtAmount.Text))
			{
				lblStatus.Text = STATUS01;
				txtAmount.Focus();
				return false;
			}

			if (!check.CheckMinAmount(txtAmount.Text))
			{
				lblStatus.Text = STATUS02;
				txtAmount.Focus();
				return false;
			}

			if (!check.CheckMaxAmount(txtAmount.Text))
			{
				lblStatus.Text = STATUS10;
				txtAmount.Focus();
				return false;
			}
			if (!check.EqualAmount(dr.Amount,txtAmount.Text))
			{
				lblStatus.Text = STATUS05;
				txtAmount.Focus();
				return false;
			}

			//Check Password/Repassword
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
						
			return true;
		}

		/// <summary>
		/// Do Transfer Amount
		/// </summary>
		public void DoTransfer()
		{
			if (CheckInput())
			{
				try
				{
					DialogResult result = MessageBox.Show(this,
						String.Format("Confirm to Transfer {0} \n From{1} To {2}", txtAmount.Text, lblAccountID.Text, txtToAccountID.Text),
					"Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (result == DialogResult.Yes)
					{
						HandleData handle = new HandleData();
						handle.ChangeState(dr.AccountID, 1);
						handle.ChangeState(txtToAccountID.Text, 1);

						AccountDataSet.AccountRow _ToAccount = handle.GetDataAccount(txtToAccountID.Text);

						int _AmountFromAccount = Convert.ToInt32(dr.Amount) - Convert.ToInt32(txtAmount.Text);
						int _AmountToAccount = Convert.ToInt32(_ToAccount.Amount) + Convert.ToInt32(txtAmount.Text);

						if (handle.UpdateAmount(dr.AccountID, _AmountFromAccount.ToString()) &&
						handle.UpdateAmount(_ToAccount.AccountID, _AmountToAccount.ToString()))
						{
							MessageBox.Show(this, STATUS07, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
							picChecked.Visible = picCancel.Visible = false;
						}
						else
							MessageBox.Show(this, STATUS08, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
						handle.ChangeState(dr.AccountID, 0);

						handle.ChangeState(dr.AccountID, 0);
						handle.ChangeState(txtToAccountID.Text, 0);

						txtAmount.Enabled = txtToAccountID.Enabled = txtPassword.Enabled = txtRePassword.Enabled = false;
						picChecked.Visible = picCancel.Visible = false;
					}
				}
				catch (Exception ex)
				{
					picChecked.Visible = picCancel.Visible = true;
					MessageBox.Show(ex.Message);
				}

			}
		}

		#endregion -- Handle Methos --

		#region -- Private Methods --

		/// <summary>
		/// Load form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Transfer_Load(object sender, EventArgs e)
		{
			this.lblAccountID.Text = dr.AccountID;
		}

		/// <summary>
		/// clean data input
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picCancel_Click(object sender, EventArgs e)
		{
			if (picChecked.Enabled == true)
				txtAmount.Text = txtToAccountID.Text = txtPassword.Text = txtRePassword.Text = String.Empty;
		}

		/// <summary>
		/// Handle transfer
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picChecked_Click(object sender, EventArgs e)
		{
			DoTransfer();
		}

		/// <summary>
		/// Handle only input number
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Text = String.Empty;
			if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		/// <summary>
		/// Hide lblStatus
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Text = String.Empty;
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
		/// Handle cant input " "
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtToAccountID_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Text = String.Empty;
			if (Char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		#endregion -- Private Methods --


	}
}
