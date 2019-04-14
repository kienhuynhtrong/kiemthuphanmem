using Bank.Crosscutting.DataComponents;
using Bank.DataAccess.ServiceComponents;
using System;
using System.Drawing;
using TABLE = Bank.Crosscutting.DataComponents.AccountDataSet.AccountDataTable;

namespace Bank.Business.HandleComponents
{
	public class HandleData
	{

		#region  -- Const/Enum/Struct --

		ServiceAccount service = null;
		Encrypt encrypt = new Encrypt();

		#endregion -- Const/Enum/Struct --

		#region -- Contructor/Destructor --

		/// <summary>
		/// Contructor
		/// </summary>
		public HandleData()
		{
			service = new ServiceAccount();
		}
		
		#endregion -- Contructor/Destructor --

		#region -- Handle Methods --

		/// <summary>
		/// Check Exist Username
		/// </summary>
		/// <param name="pUserName"></param>
		/// <returns></returns>
		public bool IsExist(string pUserName)
		{
			try
			{
				string _pUserName = encrypt.Encrypt_UP(pUserName);
				return service.IsExist(_pUserName);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Check Exist Account
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <returns></returns>
		public bool IsExistAccount(string pAccountID)
		{
			try
			{
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				return service.IsExistAccount(_pAccountID);
			}
			catch (Exception ex)
			{

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
				string _pUserName = encrypt.Encrypt_UP(pUserName);
				string _pPassword = encrypt.Encrypt_UP(pPassword);

				return service.CheckLogin(_pUserName,_pPassword);
			}
			catch (Exception ex)
			{

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
				string _pUserName = encrypt.Encrypt_UP(pUserName);
				AccountDataSet ds =  service.GetData(_pUserName);

				if (ds.Account.Count>0)
				{
					ds.Account[0].AccountID = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_ACCOUNTID].ToString());
					ds.Account[0].TypeAccount = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_TYPEACCOUNT].ToString());
					ds.Account[0].IdentityCard = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_IDENTITYCARD].ToString());
					ds.Account[0].FirstName = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_FIRSTNAME].ToString());
					ds.Account[0].LastName = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_LASTNAME].ToString());
					ds.Account[0].Birthday = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_BIRTHDAY].ToString());
					ds.Account[0].Sex = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_SEX].ToString());
					ds.Account[0].Email = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_EMAIL].ToString());
					ds.Account[0].Phone = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_PHONE].ToString());
					ds.Account[0].Address = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_ADDRESS].ToString());
					ds.Account[0].Amount = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_AMOUNT].ToString());
					ds.Account[0].CanDo = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_CANDO].ToString());
					ds.Account[0].Picture = encrypt.Decrypt(ds.Account.Rows[0][TABLE.COL_PICTURE].ToString()); 
				}

				return ds;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Update Account
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <param name="pTypeAccount">0:User	1:Admin</param>
		/// <param name="pIdentityCard"></param>
		/// <param name="pFirstName"></param>
		/// <param name="pLastName"></param>
		/// <param name="pBirthday"></param>
		/// <param name="pSex">0:Male	1:Female</param>
		/// <param name="pEmail"></param>
		/// <param name="pPhone"></param>
		/// <param name="pAddress"></param>
		/// <param name="pAmount"></param>
		/// <param name="pCando">0:Access	1:Denied</param>
		/// <param name="pPicture"></param>
		/// <returns></returns>
		public bool UpdateData(
	string pAccountID,
	int pTypeAccount,
	string pIdentityCard,
	string pFirstName,
	string pLastName,
	DateTime pBirthday,
	int pSex,
	string pEmail,
	string pPhone,
	string pAddress,
	string pAmount,
	int pCando,
	Image pPicture
	   ){
			try
			{
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				string _pTypeAccount = encrypt.EncryptByKey(pTypeAccount.ToString());
				string _pIdentityCard = encrypt.EncryptByKey(pIdentityCard);
				string _pFirstName = encrypt.EncryptByKey(pFirstName);
				string _pLastName = encrypt.EncryptByKey(pLastName);
				string _pBirthday = encrypt.EncryptByKey(pBirthday.ToString());
				string _pSex = encrypt.EncryptByKey(pSex.ToString());
				string _pEmail = encrypt.EncryptByKey(pEmail);
				string _pPhone = encrypt.EncryptByKey(pPhone);
				string _pAddress = encrypt.EncryptByKey(pAddress);
				string _pAmount = encrypt.EncryptByKey(pAmount);
				string _pCando = encrypt.EncryptByKey(pCando.ToString());

				string _pPicture = encrypt.EncryptImage(pPicture);
				_pPicture = encrypt.EncryptByKey(_pPicture);

				return service.UpdateData(_pAccountID, _pTypeAccount, _pIdentityCard, _pFirstName, _pLastName,
						_pBirthday, _pSex, _pEmail, _pPhone, _pAddress, _pAmount, _pCando, _pPicture);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Get Data Account
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <returns></returns>
		public AccountDataSet.AccountRow GetDataAccount(string pAccountID)
		{
			try
			{
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				AccountDataSet.AccountRow dr = service.GetDataAccount(_pAccountID);

				dr.AccountID = encrypt.Decrypt(dr.AccountID);
				dr.TypeAccount = encrypt.Decrypt(dr.TypeAccount);
				dr.IdentityCard = encrypt.Decrypt(dr.IdentityCard);
				dr.FirstName = encrypt.Decrypt(dr.FirstName);
				dr.LastName = encrypt.Decrypt(dr.LastName);
				dr.Birthday = encrypt.Decrypt(dr.Birthday);
				dr.Sex = encrypt.Decrypt(dr.Sex);
				dr.Email = encrypt.Decrypt(dr.Email);
				dr.Phone = encrypt.Decrypt(dr.Phone);
				dr.Address = encrypt.Decrypt(dr.Address);
				dr.Amount = encrypt.Decrypt(dr.Amount);
				dr.CanDo = encrypt.Decrypt(dr.CanDo);


				return dr;
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Insert a Account
		/// </summary>
		/// <param name="pUserName"></param>
		/// <param name="pPassword"></param>
		/// <param name="pAccountID"></param>
		/// <param name="pTypeAccount">0:User	1:Admin</param>
		/// <param name="pIdentityCard"></param>
		/// <param name="pFirstName"></param>
		/// <param name="pLastName"></param>
		/// <param name="pBirthday"></param>
		/// <param name="pSex">0:Male	1:Female</param>
		/// <param name="pEmail"></param>
		/// <param name="pPhone"></param>
		/// <param name="pAddress"></param>
		/// <param name="pAmount"></param>
		/// <param name="pCando">0:Access	1:Denied</param>
		/// <param name="pPicture"></param>
		/// <returns></returns>
		public bool InsertData(
	string pUserName,
	string pPassword,
	string pAccountID,
	int pTypeAccount,
	string pIdentityCard,
	string pFirstName,
	string pLastName,
	DateTime pBirthday,
	int pSex,
	string pEmail,
	string pPhone,
	string pAddress,
	string pAmount,
	int pCando,
	Image pPicture
			)
		{
			string _pUserName = encrypt.Encrypt_UP(pUserName);
			string _pPassword = encrypt.Encrypt_UP(pPassword);
			string _pAccountID = encrypt.EncryptByKey(pAccountID);
			string _pTypeAccount = encrypt.EncryptByKey(pTypeAccount.ToString());
			string _pIdentityCard = encrypt.EncryptByKey(pIdentityCard);
			string _pFirstName = encrypt.EncryptByKey(pFirstName);
			string _pLastName = encrypt.EncryptByKey(pLastName);
			string _pBirthday = encrypt.EncryptByKey(pBirthday.ToString());
			string _pSex = encrypt.EncryptByKey(pSex.ToString());
			string _pEmail = encrypt.EncryptByKey(pEmail);
			string _pPhone = encrypt.EncryptByKey(pPhone);
			string _pAddress = encrypt.EncryptByKey(pAddress);
			string _pAmount = encrypt.EncryptByKey(pAmount);
			string _pCando = encrypt.EncryptByKey(pCando.ToString());

			string _pPicture = encrypt.EncryptImage(pPicture);
			_pPicture = encrypt.EncryptByKey(_pPicture);

			try
			{
				return service.InsertData(_pUserName, _pPassword, _pAccountID, _pTypeAccount, _pIdentityCard, _pFirstName, _pLastName,
						_pBirthday, _pSex, _pEmail, _pPhone, _pAddress, _pAmount, _pCando, _pPicture);
			}
			catch (Exception ex)
			{

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
				AccountDataSet ds = service.GetAll();
				foreach (AccountDataSet.AccountRow row in ds.Account)
				{
					row.AccountID = encrypt.Decrypt(row.AccountID);
					row.TypeAccount = encrypt.Decrypt(row.TypeAccount);
					row.IdentityCard = encrypt.Decrypt(row.IdentityCard);
					row.FirstName = encrypt.Decrypt(row.FirstName);
					row.LastName = encrypt.Decrypt(row.LastName);
					row.Birthday = encrypt.Decrypt(row.Birthday);
					row.Sex = encrypt.Decrypt(row.Sex);
					row.Email = encrypt.Decrypt(row.Email);
					row.Phone = encrypt.Decrypt(row.Phone);
					row.Address = encrypt.Decrypt(row.Address);
					row.Amount = encrypt.Decrypt(row.Amount);
					row.CanDo = encrypt.Decrypt(row.CanDo);
					row.Picture = encrypt.Decrypt(row.Picture);
				}
				return ds;
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
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				string _pAmount = encrypt.EncryptByKey(pAmount);

				return service.UpdateAmount(_pAccountID, _pAmount);
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
		/// <param name="pCanDo"> 0: Can	1:Can't</param>
		/// <returns></returns>
		public bool ChangeState(string pAccountID, int pCanDo)
		{
			try
			{
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				string _pCanDo = encrypt.EncryptByKey(pCanDo.ToString());

				return service.ChangeState(_pAccountID, _pCanDo);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		/// <summary>
		/// Check Account is Actived or Denied
		/// </summary>
		/// <param name="pAccountID"></param>
		/// <returns></returns>
		public bool IsActiveState(string pAccountID)
		{
			try
			{
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				string _pCanDo = encrypt.EncryptByKey("0");

				return service.IsActiveState(_pAccountID, _pCanDo);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		public bool Delete(string pAccountID)
		{
			try
			{
				string _pAccountID = encrypt.EncryptByKey(pAccountID);
				return service.Delete(_pAccountID);
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}

		#endregion -- Handle Methods --

	}
}
