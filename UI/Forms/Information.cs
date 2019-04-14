using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using System;
using System.Windows.Forms;

namespace Bank.UI.Forms
{
	public partial class Information : Form
	{

		#region -- Const/Enum/Struct --

		AccountDataSet.AccountRow dr;

		#endregion -- Const/Enum/Struct --

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		/// <param name="_dr"></param>
		public Information(AccountDataSet.AccountRow _dr)
		{
			InitializeComponent();
			dr = _dr;
		}

		#endregion -- Contructor/Destructor --

		#region -- Handle Methods --

		/// <summary>
		/// Load Data
		/// </summary>
		public void LoadData()
		{
			lblAccountID.Text = dr.AccountID;
			lblAmount.Text = dr.Amount;
			lblState.Text = (dr.CanDo == "0") ? "Actived" : "Denied";
			lblFullname.Text = String.Format("{0} {1}", dr.LastName, dr.FirstName);
			lblInfentityCard.Text = dr.IdentityCard;
			lblBirthday.Text = dr.Birthday;
			lblSex.Text = (Convert.ToInt32(dr.Sex) == 0) ? "Male" : "Female";
			lblEmail.Text = dr.Email;
			lblPhone.Text = dr.Phone;
			lblAddress.Text = dr.Address;
			if (!String.IsNullOrEmpty(dr.Picture))
				picProfile.Image = new Encrypt().DecryptImage(dr.Picture);
		}

		#endregion -- Handle Methods --

		#region -- Private Methods --

		/// <summary>
		/// Load form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Information_Load(object sender, EventArgs e)
		{
			LoadData();
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

		#endregion -- Private Methods --
				
	}
}
