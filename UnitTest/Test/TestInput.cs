using Bank.UI.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bank.UnitTest.Test
{
	/// <summary>
	/// Summary description for Test
	/// </summary>
	[TestClass]
	public class TestInput
	{
		
		[TestMethod]
		public void TestEmpty()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.CheckIsEmpty(""), true);
			Assert.AreEqual(check.CheckIsEmpty("sds"), false);
			Assert.AreEqual(check.CheckIsEmpty(" "), true);
		}

		[TestMethod]
		public void TestLength()
		{
			InputCheck check = new InputCheck();

			//CheckLengthUser

			Assert.AreEqual(check.CheckLengthUserName("sds12"), false);
			Assert.AreEqual(check.CheckLengthUserName("sdsdsw"), true);
			Assert.AreEqual(check.CheckLengthUserName("sdsdasa"), true);
			
			//CheckLengthAmount

			Assert.AreEqual(check.CheckAmountLength("10000"), true);
			Assert.AreEqual(check.CheckAmountLength("100000"), true);
			Assert.AreEqual(check.CheckAmountLength("1000"), false);

			//CheckLengthPassword

			Assert.AreEqual(check.CheckPWLength("sds12"), false);
			Assert.AreEqual(check.CheckPWLength("sdsdsw"), true);
			Assert.AreEqual(check.CheckPWLength("sdsdasa"), true);

			//CheckLengthAccountID

			Assert.AreEqual(check.CheckPWLength("sds12"), false);
			Assert.AreEqual(check.CheckPWLength("sdsdsw"), true);
			Assert.AreEqual(check.CheckPWLength("sdsdasa"), true);

		}

		[TestMethod]
		public void TestExist()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.CheckUSExist("admin3"), true);
			Assert.AreEqual(check.CheckUSExist("admin"),false);
			Assert.AreEqual(check.CheckIDExist("ST003"), true);
			Assert.AreEqual(check.CheckIDExist("ST009"), false);
		}

		[TestMethod]
		public void TestBirthday()
		{
			InputCheck check = new InputCheck();
			DateTime dateTime = DateTime.Parse("20/12/2020");
			Assert.AreEqual(check.CheckBirthDay(dateTime), false);
			dateTime = DateTime.Parse("20/12/2000");
			Assert.AreEqual(check.CheckBirthDay(dateTime), true);
			Assert.AreEqual(check.CheckYearBD(dateTime), true);
			dateTime = DateTime.Parse("20/12/2001");
			Assert.AreEqual(check.CheckYearBD(dateTime), true);
			dateTime = DateTime.Parse("20/12/2002");
			Assert.AreEqual(check.CheckYearBD(dateTime), false);
		}

		[TestMethod]
		public void TestEmail()
		{
			InputCheck check = new InputCheck();
			string pEmail = "js@proseware.com9";
			Assert.AreEqual(check.CheckEmail(pEmail), false);
			pEmail = "MA@hostname.coMCom";
			Assert.AreEqual(check.CheckEmail(pEmail), false);
			pEmail = "ma@jjf..com";
			Assert.AreEqual(check.CheckEmail(pEmail), false);
			pEmail = "ma@hostname.com";
			Assert.AreEqual(check.CheckEmail(pEmail), true);
		}

		[TestMethod]
		public void TestLogin()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.CheckLogin("admin", "123456"), true);
			Assert.AreEqual(check.CheckLogin("admin3", "123456"), false);
			Assert.AreEqual(check.CheckLogin("admin", ""), false);
			Assert.AreEqual(check.CheckLogin("", "123456"), false);
			Assert.AreEqual(check.CheckLogin("", ""), false);

		}

		[TestMethod]
		public void TestEqualPW()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.CheckPW("123456", "123456"), true);
			Assert.AreEqual(check.CheckPW("123456", "12346"), false);
			Assert.AreEqual(check.CheckPW("", ""), true); // check Trống đã viết riêng
		}

		[TestMethod]
		public void TestEqualAmount()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.EqualAmount("200000", "150000"), true);
			Assert.AreEqual(check.EqualAmount("200000", "150001"), false);
			Assert.AreEqual(check.EqualAmount("200000", "149999"), true); 
		}

		[TestMethod]
		public void TestMinAccount()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.CheckMinAmount("49999"), false);
			Assert.AreEqual(check.CheckMinAmount("50000"), true);
			Assert.AreEqual(check.CheckMinAmount("100000"), true);
		}

		[TestMethod]
		public void TestMaxAccount()
		{
			InputCheck check = new InputCheck();
			Assert.AreEqual(check.CheckMaxAmount("10000000"), false);
			Assert.AreEqual(check.CheckMaxAmount("9999999"), true);
			Assert.AreEqual(check.CheckMaxAmount("5230000"), true);
		}
	}
}
