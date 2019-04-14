using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using System;
using System.Data;
using System.Windows.Forms;
using TABLE = Bank.Crosscutting.DataComponents.AccountDataSet.AccountDataTable;

namespace Bank.UI.Forms
{
	public partial class Manage : Form
	{

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
        public Manage()
        {
            InitializeComponent();
        }

		#endregion -- Contructor/Destructor --

		#region -- Handle Methods --

		/// <summary>
		/// Load grid
		/// </summary>
		private void DoLoad()
		{
			AccountDataSet ds = new HandleData().GetAll();
			grid.DataSource = ds.Account;
			for (int i = 0; i < grid.Rows.Count; i++)
			{
				grid.Rows[i].Cells["No"].Value = (i+1).ToString();
				grid.Rows[i].Cells[TABLE.COL_TYPEACCOUNT].Value = (grid.Rows[i].Cells[TABLE.COL_TYPEACCOUNT].Value.ToString() == "0") ? true : false;
				grid.Rows[i].Cells[TABLE.COL_SEX].Value = (grid.Rows[i].Cells[TABLE.COL_SEX].Value.ToString() == "1") ? true : false;
				grid.Rows[i].Cells[TABLE.COL_CANDO].Value = (grid.Rows[i].Cells[TABLE.COL_CANDO].Value.ToString() == "0") ? true : false;
			}
			grid.Rows[0].Selected = true;
		}

		/// <summary>
		/// Do add Account
		/// </summary>
		private void DoAdd()
		{
			Manage_Add frm = new Manage_Add();
			frm.ShowDialog(this);
			DoLoad();
		}

		/// <summary>
		/// Do View Account
		/// </summary>
		private void DoView()
		{
			AccountDataSet.AccountRow dr = ((DataRowView)grid.CurrentRow.DataBoundItem).Row as AccountDataSet.AccountRow;
			dr.TypeAccount = grid.CurrentRow.Cells[TABLE.COL_TYPEACCOUNT].Value.ToString() == "True" ? "0" : "1";
			dr.Sex = grid.CurrentRow.Cells[TABLE.COL_SEX].Value.ToString() == "True" ? "1" : "0";
			dr.CanDo = grid.CurrentRow.Cells[TABLE.COL_TYPEACCOUNT].Value.ToString();

			Manage_Add frm = new Manage_Add("VIEW", dr);
			frm.ShowDialog(this);
		}

		/// <summary>
		/// Do Edit Account
		/// </summary>
		private void DoEdit()
		{
			AccountDataSet.AccountRow dr = ((DataRowView)grid.CurrentRow.DataBoundItem).Row as AccountDataSet.AccountRow;
			dr.TypeAccount = grid.CurrentRow.Cells[TABLE.COL_TYPEACCOUNT].Value.ToString() == "True" ? "0" : "1";
			dr.Sex = grid.CurrentRow.Cells[TABLE.COL_SEX].Value.ToString() == "True" ? "1" : "0";
			dr.CanDo = grid.CurrentRow.Cells[TABLE.COL_TYPEACCOUNT].Value.ToString();

			Manage_Add frm = new Manage_Add("EDIT", dr);
			frm.ShowDialog(this);
			DoLoad();
		}

		/// <summary>
		/// Do Delete Account
		/// </summary>
		private void DoDelete()
		{
			AccountDataSet.AccountRow dr = ((DataRowView)grid.CurrentRow.DataBoundItem).Row as AccountDataSet.AccountRow;
			DialogResult result = MessageBox.Show(this, String.Format("Confirm to Delete {0}", dr.AccountID)
					, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				HandleData handle = new HandleData();
				handle.Delete(dr.AccountID);
				DoLoad();
			}
		}

		#endregion -- Handle Methods --

		#region -- Private Methods --

		/// <summary>
		/// Load form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Manage_Load(object sender, EventArgs e)
		{
			DoLoad();
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
		/// View Account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picView_Click(object sender, EventArgs e)
		{
			DoView();
		}

		/// <summary>
		/// Edit Account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picEdit_Click(object sender, EventArgs e)
		{
			DoEdit();
		}

		private void picDel_Click(object sender, EventArgs e)
		{
			DoDelete();
		}

		/// <summary>
		/// Add Account
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void picAdd_Click(object sender, EventArgs e)
		{
			DoAdd();
		}

		/// <summary>
		/// Handle select item mnustrip
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == mnuMain_Add)
			{
				DoAdd();
			}
			if(e.ClickedItem == mnuMain_View)
			{
				DoView();
			}
			if (e.ClickedItem == mnuMain_Edit)
			{
				DoEdit();
			}
			if (e.ClickedItem == mnuMain_Del)
			{
				DoDelete();
			}
		}


		#endregion -- Private Methods --
	}
}
