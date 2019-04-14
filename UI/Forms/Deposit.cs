using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using Bank.UI.Classes;
using System;
using System.Windows.Forms;

namespace Bank.UI.Forms
{
	public partial class Deposit : Form
	{
		#region -- Const/Enum/Struct --

		private AccountDataSet.AccountRow dr;
		private const string STATUS01 = "Must have value!";
		private const string STATUS02 = "Must >= 50000!";
		private const string STATUS03 = "Re-password is incorrect!";
		private const string STATUS04 = "Must have > 6 charaters!";
		private const string STATUS05 = "Success!";
		private const string STATUS06 = "Failed!";
		private const string STATUS07 = "Must < 10000000";

		#endregion -- Const/Enum/Struct --

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="pRow"></param>
		public Deposit(AccountDataSet.AccountRow pRow)
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
			if(!check.CheckMaxAmount(txtAmount.Text))
			{
				lblStatus.Text = STATUS07;
				txtAmount.Focus();
				return false;
			}
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
				txtRePassword.Text = String.Empty;
				txtRePassword.Focus();
				return false;
			}

			if (!check.CheckPW(txtPassword.Text, txtRePassword.Text))
			{
				lblStatus.Text = STATUS03;
				txtRePassword.Text = String.Empty;
				txtRePassword.Focus();
				return false;
			}			

			return true;
		}

		/// <summary>
		/// Do Deposit
		/// </summary>
		public void DoDeposit()
		{
			if (CheckInput())
			{
				DialogResult result = MessageBox.Show(this, String.Format("Confirm to Deposit {0} \n To {1}", txtAmount.Text, lblAccountID.Text)
					, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					int _Amount = Convert.ToInt32(dr.Amount);
					_Amount += Convert.ToInt32(txtAmount.Text);
					try
					{
						HandleData handle = new HandleData();

						handle.ChangeState(dr.AccountID, 1);

						if (handle.UpdateAmount(dr.AccountID, _Amount.ToString()))
						{
							MessageBox.Show(this, STATUS05, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
							picChecked.Visible = picCancel.Visible = false;
						}
						else
							MessageBox.Show(this, STATUS06, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
		/// Close form
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
			lblStatus.Text = String.Empty;
			txtAmount.Text = txtPassword.Text = txtRePassword.Text = String.Empty;
			txtAmount.Focus();
		}

		/// <summary>
		/// Load form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Deposit_Load(object sender, EventArgs e)
		{
			lblAccountID.Text = dr.AccountID;
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
		/// Handle Deposit
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picChecked_Click(object sender, EventArgs e)
		{
			DoDeposit();
		}

		/// <summary>
		/// Handle hide status label
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
