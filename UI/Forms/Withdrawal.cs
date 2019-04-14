using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using Bank.UI.Classes;
using System;
using System.Windows.Forms;

namespace Bank.UI.Forms
{
	public partial class Withdrawal : Form
	{
		#region -- Const/Enum/Struct --

		private AccountDataSet.AccountRow dr;
		private const string STATUS01 = "Must have value!";
		private const string STATUS02 = "Must >= 50000!";
		private const string STATUS03 = "Re-password is incorrect!";
		private const string STATUS04 = "Must have > 6 charaters!";
		private const string STATUS05 = "Amount is not Enough!";
		private const string STATUS06 = "Success!";
		private const string STATUS07 = "Failed!";
		private const string STATUS08 = "Must < 10000000";

		#endregion -- Const/Enum/Struct --

		#region  -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="pRow"></param>
		public Withdrawal(AccountDataSet.AccountRow pRow)
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
				lblStatus.Text = STATUS08;
				txtAmount.Focus();
				return false;
			}

			if (!check.EqualAmount(dr.Amount, txtAmount.Text))
			{
				lblStatus.Text = STATUS05;
				txtAmount.Focus();
				return false;

			}
			//Check Password - RePassword
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
		/// Do Withdrawal
		/// </summary>
		private void DoWithdrawal()
		{
			if (CheckInput())
			{
				DialogResult result = MessageBox.Show(this, String.Format("Confirm to Witheawal {0} \n To {1}", txtAmount.Text, lblAccountID.Text)
					, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					try
					{
						HandleData handle = new HandleData();

						handle.ChangeState(dr.AccountID, 1);

						int _Amount = Convert.ToInt32(dr.Amount) - Convert.ToInt32(txtAmount.Text);
						if (handle.UpdateAmount(dr.AccountID, _Amount.ToString()))
						{
							MessageBox.Show(this, STATUS06, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
							picChecked.Visible = picCancel.Visible = false;
						}
						else
							MessageBox.Show(this, STATUS07, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

						handle.ChangeState(dr.AccountID, 0);

						txtAmount.Enabled = txtPassword.Enabled = txtRePassword.Enabled = false;
						picChecked.Visible = picCancel.Visible = false;
					}
					catch (Exception ex)
					{
						picChecked.Visible = picCancel.Visible = true;
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		#endregion -- Handle Methods --

		#region -- Private Methods --

		/// <summary>
		/// Load form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Withdrawal_Load(object sender, EventArgs e)
		{
			lblAccountID.Text = dr.AccountID;
		}

		/// <summary>
		/// Close  form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
				
		/// <summary>
		/// Clean data input
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picCancel_Click(object sender, EventArgs e)
		{
			lblStatus.Visible = false;
			txtAmount.Text = txtPassword.Text = txtRePassword.Text = String.Empty;	
		}

		/// <summary>
		/// Handle only input numbers
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
		/// Handle Withdrawal
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picChecked_Click(object sender, EventArgs e)
		{
			DoWithdrawal();
		}

		/// <summary>
		/// Handle hide lblStatus
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			lblStatus.Text = String.Empty;
		}

		#endregion -- Private Methods --
	}
}
