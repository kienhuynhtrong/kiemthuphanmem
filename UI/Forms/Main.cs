
using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using System;
using System.Windows.Forms;

namespace Bank.UI.Forms
{
	public partial class Main : Form
	{
		private string Username;
		private AccountDataSet.AccountRow dr;
		HandleData handle;

		private const string STATUS01 = "Account was Denied!";

		#region -- Contructor/Destructor --
		public Main(string pUserName)
		{
			InitializeComponent();
			this.Username = pUserName;
			handle = new HandleData();
		}

		#endregion -- Contructor/Destructor

		#region -- Private Methods --
		private void Main_Load(object sender, EventArgs e)
		{

			AccountDataSet ds = handle.GetData(Username);
			dr = ds.Account[0];
			lblName.Text = String.Format("{0} {1}", dr.LastName, dr.FirstName);
			if(dr.TypeAccount =="0")
			{
				picManage.Visible = false;
			}
		}	

		private void picLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void picInfor_Click(object sender, EventArgs e)
		{
			Information frm = new Information(dr);
			frm.Show();
		}

		private void picDeposit_Click(object sender, EventArgs e)
		{
			if (dr.CanDo == "0")
			{
				Deposit frm = new Deposit(dr);
				frm.ShowDialog(this);
			}
			else
				MessageBox.Show(this, STATUS01, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void picWithdrawal_Click(object sender, EventArgs e)
		{
			if (dr.CanDo=="0")
			{
				Withdrawal frm = new Withdrawal(dr);
				frm.ShowDialog(this); 
			}
			else
				MessageBox.Show(this, STATUS01, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void picTransfer_Click(object sender, EventArgs e)
		{
			if (dr.CanDo=="0")
			{
				Transfer frm = new Transfer(dr);
				frm.ShowDialog(this); 
			}
			else
				MessageBox.Show(this, STATUS01, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void picManage_Click(object sender, EventArgs e)
		{
			if (dr.CanDo == "0")
			{
				Manage frm = new Manage();
				frm.ShowDialog(this);
			}
			else
				MessageBox.Show(this, STATUS01, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		#endregion -- Private Methods --


	}
}
