using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Bank.Crosscutting.DataComponents;

namespace Bank.DataAccess.ServiceComponents
{
	public class ServiceAccount
	{
		#region -- Const/Enum/Struct --
		private const string STR_CONNECTION = @"Server= KIEN_CALVIN\SQLEXPRESS ;Database=BANK;Trusted_Connection=True;";

		SqlConnection sqlConnection = null;

		#endregion -- Const/Enum/Struct --

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		public ServiceAccount()
		{
			sqlConnection = new SqlConnection(STR_CONNECTION);
		}

		#endregion -- Contructor/Destructor --

		#region -- SQL --

		private const string SQL1 = @"SELECT * 
	FROM Account 
	WHERE UserName = @UserName";
		
		private const string SQL2 = @"INSERT INTO Account(
	UserName,
	Password,
	AccountID,
	TypeAccount,
	IdentityCard,
	FirstName,
	LastName,
	Birthday,
	Sex,
	Email,
	Phone,
	Address,
	Amount,
	CanDo,
	Picture)
VALUES(
	@UserName,
	@Password,
	@AccountID,
	@TypeAccount,
	@IdentityCard,
	@FirstName,
	@LastName,
	@Birthday,
	@Sex,
	@Email,
	@Phone,
	@Address,
	@Amount,
	@CanDo,
	@Picture)";

		private const string SQL3 = @"SELECT * 
	FROM Account 
	WHERE 
			UserName = @UserName 
		AND 
			Password = @Password";
		private const string SQL4 = @"
	UPDATE  Account
	SET Amount = @Amount
	WHERE   AccountID = @AccountID";

		private const string SQL5 = @"
	UPDATE  Account
	SET  Cando = @CanDo
	WHERE   AccountID = @AccountID";

		private const string SQL6 = @"SELECT * 
	FROM Account
	WHERE AccountID = @AccountID";

		private const string SQL7 = @"SELECT * FROM Account";

		private const string SQL8 = @"UPDATE Account
	SET
		TypeAccount = @TypeAccount,
	    IdentityCard = @IdentityCard,	 
	    FirstName = @FirstName,	 
	    LastName = @LastName,	 
	    Birthday = @Birthday,	 
	    Sex = @Sex,	 
	    Email = @Email,	 
	    Phone = @Phone,	 
	    Address	= @Address,	 
	    Amount = @Amount,	 
	    CanDo = @CanDo,	 
	    Picture	= @Picture 
	WHERE 
		AccountID = @AccountID";

		private const string SQL9 = @"
	SELECT * 
	FROM Account
	WHERE
			AccountID = @AccountID
		AND
			CanDo = @CanDo";

		private const string SQL10 = @"
	DELETE 
		FROM Account 
	WHERE 
		AccountID = @AccountID";

		#endregion -- SQL --		

		#region -- Handle Methods --

		/// <summary>
		/// Insert new Account
		/// </summary>
		/// <param name="pUserName"></param>
		/// <param name="pPassword"></param>
		/// <param name="pAccountID"></param>
		/// <param name="pTypeAccount"></param>
		/// <param name="pIdentityCard"></param>
		/// <param name="pFirstName"></param>
		/// <param name="pLastName"></param>
		/// <param name="pBirthday"></param>
		/// <param name="pSex"></param>
		/// <param name="pEmail"></param>
		/// <param name="pPhone"></param>
		/// <param name="pAddress"></param>
		/// <param name="pAmount"></param>
		/// <param name="pCanDo"></param>
		/// <param name="pPicture"></param>
		/// <returns></returns>
		public bool InsertData(
	string pUserName,
	string pPassword,
	string pAccountID,
	string pTypeAccount,
	string pIdentityCard,
	string pFirstName,
	string pLastName,
	string pBirthday,
	string pSex,
	string pEmail,
	string pPhone,
	string pAddress,
	string pAmount,
	string pCanDo,
	string pPicture
			)
		{
            try
            {
                if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();
                SqlCommand cmd = new SqlCommand(SQL2, sqlConnection);

                cmd.Parameters.AddWithValue("@UserName", pUserName);
                cmd.Parameters.AddWithValue("@Password", pPassword);
                cmd.Parameters.AddWithValue("@AccountID", pAccountID);
                cmd.Parameters.AddWithValue("@TypeAccount", pTypeAccount);
                cmd.Parameters.AddWithValue("@IdentityCard", pIdentityCard);
                cmd.Parameters.AddWithValue("@FirstName", pFirstName);
                cmd.Parameters.AddWithValue("@LastName", pLastName);
                cmd.Parameters.AddWithValue("@Birthday", pBirthday);
                cmd.Parameters.AddWithValue("@Sex", pSex);
                cmd.Parameters.AddWithValue("@Email", pEmail);
                cmd.Parameters.AddWithValue("@Phone", pPhone);
                cmd.Parameters.AddWithValue("@Address", pAddress);
                cmd.Parameters.AddWithValue("@Amount", pAmount);
                cmd.Parameters.AddWithValue("@CanDo", pCanDo);
                cmd.Parameters.AddWithValue("@Picture", pPicture);

                int resuilt = cmd.ExecuteNonQuery();
                sqlConnection.Close();
                return resuilt > 0 ? true : false;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
		}

		/// <summary>
		/// Update Account
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <param name="pTypeAccount"></param>
		/// <param name="pIdentityCard"></param>
		/// <param name="pFirstName"></param>
		/// <param name="pLastName"></param>
		/// <param name="pBirthday"></param>
		/// <param name="pSex"></param>
		/// <param name="pEmail"></param>
		/// <param name="pPhone"></param>
		/// <param name="pAddress"></param>
		/// <param name="pAmount"></param>
		/// <param name="pCanDo"></param>
		/// <param name="pPicture"></param>
		/// <returns></returns>
		public bool UpdateData(
	string pAccountID,
	string pTypeAccount,
	string pIdentityCard,
	string pFirstName,
	string pLastName,
	string pBirthday,
	string pSex,
	string pEmail,
	string pPhone,
	string pAddress,
	string pAmount,
	string pCanDo,
	string pPicture
		){
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();
				SqlCommand cmd = new SqlCommand(SQL8, sqlConnection);

				cmd.Parameters.AddWithValue("@AccountID", pAccountID);
				cmd.Parameters.AddWithValue("@TypeAccount", pTypeAccount);
				cmd.Parameters.AddWithValue("@IdentityCard", pIdentityCard);
				cmd.Parameters.AddWithValue("@FirstName", pFirstName);
				cmd.Parameters.AddWithValue("@LastName", pLastName);
				cmd.Parameters.AddWithValue("@Birthday", pBirthday);
				cmd.Parameters.AddWithValue("@Sex", pSex);
				cmd.Parameters.AddWithValue("@Email", pEmail);
				cmd.Parameters.AddWithValue("@Phone", pPhone);
				cmd.Parameters.AddWithValue("@Address", pAddress);
				cmd.Parameters.AddWithValue("@Amount", pAmount);
				cmd.Parameters.AddWithValue("@CanDo", pCanDo);
				cmd.Parameters.AddWithValue("@Picture", pPicture);

				int resuilt = cmd.ExecuteNonQuery();
				sqlConnection.Close();
				return resuilt > 0 ? true : false;
			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		/// <summary>
		/// Check Exist Username
		/// </summary>
		/// <param name="pUserName"></param>
		/// <returns></returns>
		public bool IsExist(string pUserName)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(SQL1, sqlConnection);
				cmd.Parameters.AddWithValue("@UserName", pUserName);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();

				return (ds.Account.Rows.Count > 0) ? true : false;

			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		/// <summary>
		/// Check Login 
		/// </summary>
		/// <param name="pUserName"></param>
		/// <param name="pPassword"></param>
		/// <returns></returns>
		public bool CheckLogin(string pUserName, string pPassword)
		{
			try
			{				
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(SQL3, sqlConnection);
				cmd.Parameters.AddWithValue("@UserName", pUserName);
				cmd.Parameters.AddWithValue("@Password", pPassword);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();

				return (ds.Account.Rows.Count > 0) ? true : false;

			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		/// <summary>
		/// Get Data
		/// </summary>
		/// <param name="pUserName"></param>
		/// <returns></returns>
		public AccountDataSet GetData(string pUserName)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(SQL1, sqlConnection);
				cmd.Parameters.AddWithValue("@UserName", pUserName);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();

				return ds;
			}
			catch (Exception ex)
			{
				throw ex;
			}

		}

		/// <summary>
		/// Get data Account
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <returns></returns>
		public AccountDataSet.AccountRow GetDataAccount(string pAccountID)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(SQL6, sqlConnection);
				cmd.Parameters.AddWithValue("@AccountID", pAccountID);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();
				return ds.Account[0];
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Update Amount
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <param name="pAmount"></param>
		/// <returns></returns>
		public bool UpdateAmount(string pAccountID, string pAmount)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();
				SqlCommand cmd = new SqlCommand(SQL4, sqlConnection);

				cmd.Parameters.AddWithValue("@AccountID", pAccountID);
				cmd.Parameters.AddWithValue("@Amount", pAmount);

				int resuilt = cmd.ExecuteNonQuery();
				sqlConnection.Close();
				return resuilt > 0 ? true : false;
			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		public bool Delete(string pAccountID)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();
				SqlCommand cmd = new SqlCommand(SQL10, sqlConnection);

				cmd.Parameters.AddWithValue("@AccountID", pAccountID);

				int resuilt = cmd.ExecuteNonQuery();
				sqlConnection.Close();
				return resuilt > 0 ? true : false;
			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		/// <summary>
		/// Check Exist Account ID
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <returns></returns>
		public bool IsExistAccount(string pAccountID)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(SQL6, sqlConnection);
				cmd.Parameters.AddWithValue("@AccountID", pAccountID);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();

				return (ds.Account.Rows.Count > 0) ? true : false;

			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		/// <summary>
		/// Get All Data
		/// </summary>
		/// <returns></returns>
		public AccountDataSet GetAll()
		{

			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlCommand cmd = new SqlCommand(SQL7, sqlConnection);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();
				return ds;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Change State Account
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <param name="pCanDo"></param>
		/// <returns></returns>
		public bool ChangeState(string pAccountID, string pCanDo)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();
				SqlCommand cmd = new SqlCommand(SQL5, sqlConnection);

				cmd.Parameters.AddWithValue("@AccountID", pAccountID);
				cmd.Parameters.AddWithValue("@CanDo", pCanDo);

				int resuilt = cmd.ExecuteNonQuery();
				sqlConnection.Close();
				return resuilt > 0 ? true : false;
			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		/// <summary>
		/// Check Account is Actived or Denied
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <param name="pCanDo"></param>
		/// <returns></returns>
		public bool IsActiveState(string pAccountID, string pCanDo)
		{
			try
			{
				if (sqlConnection != null && sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();
				SqlCommand cmd = new SqlCommand(SQL9, sqlConnection);

				cmd.Parameters.AddWithValue("@AccountID", pAccountID);
				cmd.Parameters.AddWithValue("@CanDo", pCanDo);

				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				AccountDataSet ds = new AccountDataSet();
				sda.Fill(ds, AccountDataSet.AccountDataTable.TABLE_NAME);
				sqlConnection.Close();

				return (ds.Account.Rows.Count > 0) ? true : false;
			}
			catch (Exception ex)
			{
				return false;
				throw ex;
			}
		}

		#endregion -- Handle Methods --

	}
}

