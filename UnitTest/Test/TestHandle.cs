using Bank.Business.HandleComponents;
using Bank.Crosscutting.DataComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Data;

namespace Bank.UnitTest.Test
{
	[TestClass]
	public class TestHandle
	{
		[TestMethod]
		public void TestExist()
		{
			HandleData handle = new HandleData();
			Assert.AreEqual(handle.IsExist("admin"), true);
			Assert.AreEqual(handle.IsExist("admin5"), false);
		}

		[TestMethod]
		public void TestExistAccount()
		{
			HandleData handle = new HandleData();
			Assert.AreEqual(handle.IsExistAccount("ST003"), true);
			Assert.AreEqual(handle.IsExist("ST005"), false);
		}

		[TestMethod]
		public void TestLogin()
		{
			HandleData handle = new HandleData();

			Assert.AreEqual(handle.CheckLogin("admin3","123456"), true);
			Assert.AreEqual(handle.CheckLogin("admin5","123456"), false);
		}

		[TestMethod]
		public void TestGetData()
		{
			HandleData handle = new HandleData();

			AccountDataSet ds = handle.GetData("admin3");
			bool result = ds.Account.Count > 0 ? true : false;
			Assert.AreEqual(result, true);

			ds = new AccountDataSet();
			ds = handle.GetData("admin");
			result = ds.Account.Count > 0 ? true : false;
			Assert.AreEqual(result, false);
		}

		[TestMethod]
		public void TestGetAll()
		{
			HandleData handle = new HandleData();

			AccountDataSet ds = handle.GetAll();
			bool result = ds.Account.Count > 0 ? true : false;
			Assert.AreEqual(result, true);

			ds = new AccountDataSet();
			ds = handle.GetAll();
			result = ds.Account.Count > 0 ? true : false;
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void TestActiveState()
		{
			HandleData handle = new HandleData();
			Assert.AreEqual(handle.IsActiveState("ST003"), true);
			Assert.AreEqual(handle.IsActiveState("ST005"), false);
		}

		[TestMethod]
		public void TestUpdateData()
		{
			HandleData handle = new HandleData();
			Image img = Image.FromFile(@"C:\Users\Hugo\Pictures\Image\cat1.png");

			bool result = handle.UpdateData("ST003", 1, "0000000000", "Hoang", "Hiep", DateTime.Now, 0,
				"fvd@gmail.com", "0987654321", "Nguyen Kiem Street", "10000000", 0, img);
			Assert.AreEqual(result, true);

			result = handle.UpdateData("ST001", 1, "0000000000", "Hoang", "Hiep", DateTime.Now, 0,
				"fvd@gmail.com", "0987654321", "Nguyen Kiem Street", "10000000", 0, img);
			Assert.AreEqual(result, false);
		}

		[TestMethod]
		public void TestInsertData()
		{
			HandleData handle = new HandleData();
			Image img = Image.FromFile(@"C:\Users\Hugo\Pictures\Image\cat1.png");

			bool result = handle.InsertData("admin","123456","ST001", 1, "0000000000", "Hoang", "Hiep", DateTime.Now, 0,
				"fvd@gmail.com", "0987654321", "Nguyen Kiem Street", "10000000", 0, img);
			Assert.AreEqual(result, true);

			result = handle.InsertData("admin", "123456", "ST001", 1, "0000000000", "Hoang", "Hiep", DateTime.Now, 0,
				"fvd@gmail.com", "0987654321", "Nguyen Kiem Street", "10000000", 0, img);
			Assert.AreEqual(result, false);
		}

		[TestMethod]
		public void TestUpdateAmount()
		{
			HandleData handle = new HandleData();
			Assert.AreEqual(handle.UpdateAmount("ST003","1000000"), true);
						
			Assert.AreEqual(handle.UpdateAmount("ST010", "1000000"), false);
		}

		[TestMethod]
		public void TestChangeState()
		{
			HandleData handle = new HandleData();
			Assert.AreEqual(handle.ChangeState("ST003",0), true);

			Assert.AreEqual(handle.ChangeState("ST010", 1), false);
		}

		[TestMethod]
		public void TestGetDataAccount()
		{
			HandleData handle = new HandleData();

			AccountDataSet.AccountRow dr = handle.GetDataAccount("ST003");
			bool result = dr.IsAccountIDNull();
			Assert.AreEqual(result, true);

			dr = handle.GetDataAccount("ST010");
			result = dr.IsAccountIDNull();
			Assert.AreEqual(result, false);
		}

		[TestMethod]
		public void TestDeleteData()
		{
			HandleData handle = new HandleData();
			Assert.AreEqual(handle.Delete("ST001"), true);
			Assert.AreEqual(handle.Delete("ST010"), false);

		}
	}
}
