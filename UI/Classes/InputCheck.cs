using Bank.Business.HandleComponents;
using System;
using System.Text.RegularExpressions;

namespace Bank.UI.Classes
{
	public class InputCheck
	{
		public bool CheckIsEmpty(string pValue)
		{
			if (String.IsNullOrEmpty(pValue) || String.IsNullOrWhiteSpace(pValue))
			{
				return true;
			}
			else
				return false;
		}

		#region UserName		

		public bool CheckUSExist(string pUserName)
		{
			HandleData handle = new HandleData();
			return handle.IsExist(pUserName);
		}

		public bool CheckLengthUserName(string pUserName)
		{
			return pUserName.Length >= 6;
		}

		#endregion UserName

		#region Password/Re-Password

		public bool CheckPW(string pPassword, string pRePassword)
		{
			return String.Equals(pPassword, pRePassword);
			 
		}

		public bool CheckPWLength(string pPassword)
		{
			return pPassword.Length >= 6;
		}

		#endregion Password/Re-Password

		#region CheckLogin

		public bool CheckLogin(string pUserName,string pPassword)
		{
			HandleData handle = new HandleData();
			return handle.CheckLogin(pUserName, pPassword);
		}

		#endregion CheckLogin

		#region Amount

		public bool CheckMinAmount(string pAmount)
		{
			return Convert.ToInt64(pAmount) >= 50000;
		}
	
		public bool CheckMaxAmount(string pAmount)
		{
			return Convert.ToInt64(pAmount) < 10000000;
		}

		public bool CheckAmountLength(string pAmount)
		{
			return pAmount.Length >= 5;
		}

		#endregion Amount

		#region Withdrawal

		public bool EqualAmount(string pAmountHad,string pAmount)
		{
			return Convert.ToInt64(pAmountHad) >= Convert.ToInt64(pAmount)+50000;
		}

		#endregion Withdrawal

		#region AccountID

		public bool CheckIDLength(string pAccountID)
		{
			return pAccountID.Length >= 6;
		}
		public bool CheckIDExist(string pAccountID)
		{
			HandleData handle = new HandleData();
			return handle.IsExistAccount(pAccountID);
		}

		public bool CheckIDState(string pAccountID)
		{
			HandleData handle = new HandleData();
			return handle.IsActiveState(pAccountID);
		}

		#endregion AccountID

		#region Name

		#endregion Name

		#region IdentityCard
		
		#endregion IdentityCard

		#region BirthDay

		public bool CheckBirthDay(DateTime pDateTime)
		{			
			if (DateTime.Now <= pDateTime)
				return false;
			return true;
		}

		public bool CheckYearBD(DateTime pDateTime)
		{
			if (DateTime.Now.Year - pDateTime.Year < 18)
				return false;
			return true;
		}

		#endregion BirthDay

		#region Email

		public bool CheckEmail(string pEmail)
		{
			Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
			Match match = regex.Match(pEmail);
			return match.Success;
		}

		#endregion Email

	}
}
