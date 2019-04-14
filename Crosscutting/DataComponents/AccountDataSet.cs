using System;
using System.ComponentModel;
using System.Data;

namespace Bank.Crosscutting.DataComponents
{
	/// <summary>
	/// 
	/// </summary>
	[ToolboxItem(false)]
	public class AccountDataSet : DataSet
	{

		#region --- Member Variables ---		        	

		private AccountDataTable tableAccount;

		#endregion --- Member Variables ---

		#region --- Properties ---

		public AccountDataTable Account
		{
			get
			{
				return this.tableAccount;
			}
		}

		#endregion --- Properties ---

		#region --- Contructors & Destructors ---

		public AccountDataSet()
		{
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		#endregion --- Contructors & Destructors ---

		#region --- Private Methods ---

		internal void InitVars()
		{
			this.InitVars(true);
		}

		internal void InitVars(bool initTable)
		{
			this.tableAccount = ((AccountDataTable)(base.Tables[AccountDataTable.TABLE_NAME]));
			if ((initTable == true))
			{
				if ((this.tableAccount != null))
				{
					this.tableAccount.InitVars();
				}
			}
		}

		private void InitClass()
		{
			this.DataSetName = "AccountDataSet";
			this.tableAccount = new AccountDataTable();
			base.Tables.Add(this.tableAccount);
		}

		#endregion --- Private Methods ---

		/// <summary>
		/// 
		/// </summary>
		public class AccountDataTable : TypedTableBase<AccountRow>
		{

			#region --- Enums, Structs, Constants ---

			public const string TABLE_NAME = "Account";
			public const string COL_USERNAME = "UserName";
			public const string COL_PASSWORD = "Password";
			public const string COL_ACCOUNTID = "AccountID";
			public const string COL_TYPEACCOUNT = "TypeAccount";
			public const string COL_IDENTITYCARD = "IdentityCard";
			public const string COL_FIRSTNAME = "FirstName";
			public const string COL_LASTNAME = "LastName";
			public const string COL_BIRTHDAY = "Birthday";
			public const string COL_SEX = "Sex";
			public const string COL_EMAIL = "Email";
			public const string COL_PHONE = "Phone";
			public const string COL_ADDRESS = "Address";
			public const string COL_AMOUNT = "Amount";
			public const string COL_CANDO = "CanDo";
			public const string COL_PICTURE = "Picture";

			#endregion --- Enums, Structs, Constants ---

			#region --- Memeber Variables ---

			private DataColumn columnUserName;
			private DataColumn columnPassword;
			private DataColumn columnAccountID;
			private DataColumn columnTypeAccount;
			private DataColumn columnIdentityCard;
			private DataColumn columnFirstName;
			private DataColumn columnLastName;
			private DataColumn columnBirthday;
			private DataColumn columnSex;
			private DataColumn columnEmail;
			private DataColumn columnPhone;
			private DataColumn columnAddress;
			private DataColumn columnAmount;
			private DataColumn columnCanDo;
			private DataColumn columnPicture;

			#endregion

			#region --- Properties ---

			public DataColumn UserNameColumn
			{
				get
				{
					return this.columnUserName;
				}
			}

			public DataColumn PasswordColumn
			{
				get
				{
					return this.columnPassword;
				}
			}

			public DataColumn AccountIDColumn
			{
				get
				{
					return this.columnAccountID;
				}
			}

			public DataColumn TypeAccountColumn
			{
				get
				{
					return this.columnTypeAccount;
				}
			}

			public DataColumn IdentityCardColumn
			{
				get
				{
					return this.columnIdentityCard;
				}
			}

			public DataColumn FirstNameColumn
			{
				get
				{
					return this.columnFirstName;
				}
			}

			public DataColumn LastNameColumn
			{
				get
				{
					return this.columnLastName;
				}
			}

			public DataColumn BirthdayColumn
			{
				get
				{
					return this.columnBirthday;
				}
			}

			public DataColumn SexColumn
			{
				get
				{
					return this.columnSex;
				}
			}

			public DataColumn EmailColumn
			{
				get
				{
					return this.columnEmail;
				}
			}

			public DataColumn PhoneColumn
			{
				get
				{
					return this.columnPhone;
				}
			}

			public DataColumn AddressColumn
			{
				get
				{
					return this.columnAddress;
				}
			}

			public DataColumn AmountColumn
			{
				get
				{
					return this.columnAmount;
				}
			}

			public DataColumn CanDoColumn
			{
				get
				{
					return this.columnCanDo;
				}
			}

			public DataColumn PictureColumn
			{
				get
				{
					return this.columnPicture;
				}
			}

			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			public AccountRow this[int index]
			{
				get
				{
					return ((AccountRow)(this.Rows[index]));
				}
			}

			#endregion --- Properties ---

			#region --- Contructors & Destructors ---

			public AccountDataTable()
			{
				this.TableName = TABLE_NAME;
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			#endregion --- Contructors & Destructors ---

			#region --- Public Methods ---

			public override DataTable Clone()
			{
				AccountDataTable cln = ((AccountDataTable)(base.Clone()));
				cln.InitVars();
				return cln;
			}

			protected override DataTable CreateInstance()
			{
				return new AccountDataTable();
			}

			public void AddAccountRow(AccountRow row)
			{
				this.Rows.Add(row);
			}

			public AccountRow AddAccountRow(
				string UserName,
				string Password,
				string AccountID,
				string TypeAccount,
				string IdentityCard,
				string FirstName,
				string LastName,
				string Birthday,
				string Sex,
				string Email,
				string Phone,
				string Address,
				string Amount,
				string CanDo,
				string Picture)
			{
				AccountRow rowAccountRow = ((AccountRow)(this.NewRow()));
				object[] columnValuesArray = new object[] {
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
									Picture};
				rowAccountRow.ItemArray = columnValuesArray;
				this.Rows.Add(rowAccountRow);
				return rowAccountRow;
			}

			public AccountRow FindByUserName(
					string UserName)
			{
				return ((AccountRow)(this.Rows.Find(new object[] {
							UserName})));
			}

			public AccountRow NewAccountRow()
			{
				return ((AccountRow)(this.NewRow()));
			}

			public void RemoveAccountRow(AccountRow row)
			{
				this.Rows.Remove(row);
			}

			#endregion --- Public Methods ---

			#region ---- Protected medthods ----

			/// <summary>
			/// Override NewRowFromBuilder to create AccountRow
			/// </summary>
			/// <param name="builder"></param>
			/// <returns></returns>
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new AccountRow(builder);
			}

			#endregion

			#region --- Private Methods ---

			/// <summary>
			/// 
			/// </summary>
			private void InitClass()
			{
				this.columnUserName =
					new DataColumn(COL_USERNAME, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnUserName);

				this.columnPassword =
					new DataColumn(COL_PASSWORD, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPassword);

				this.columnAccountID =
					new DataColumn(COL_ACCOUNTID, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAccountID);

				this.columnTypeAccount =
					new DataColumn(COL_TYPEACCOUNT, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTypeAccount);

				this.columnIdentityCard =
					new DataColumn(COL_IDENTITYCARD, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIdentityCard);

				this.columnFirstName =
					new DataColumn(COL_FIRSTNAME, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFirstName);

				this.columnLastName =
					new DataColumn(COL_LASTNAME, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLastName);

				this.columnBirthday =
					new DataColumn(COL_BIRTHDAY, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnBirthday);

				this.columnSex =
					new DataColumn(COL_SEX, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSex);

				this.columnEmail =
					new DataColumn(COL_EMAIL, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEmail);

				this.columnPhone =
					new DataColumn(COL_PHONE, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPhone);

				this.columnAddress =
					new DataColumn(COL_ADDRESS, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAddress);

				this.columnAmount =
					new DataColumn(COL_AMOUNT, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAmount);

				this.columnCanDo =
					new DataColumn(COL_CANDO, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCanDo);

				this.columnPicture =
					new DataColumn(COL_PICTURE, typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPicture);

			}

			internal void InitVars()
			{
				this.columnUserName = base.Columns[COL_USERNAME];
				this.columnPassword = base.Columns[COL_PASSWORD];
				this.columnAccountID = base.Columns[COL_ACCOUNTID];
				this.columnTypeAccount = base.Columns[COL_TYPEACCOUNT];
				this.columnIdentityCard = base.Columns[COL_IDENTITYCARD];
				this.columnFirstName = base.Columns[COL_FIRSTNAME];
				this.columnLastName = base.Columns[COL_LASTNAME];
				this.columnBirthday = base.Columns[COL_BIRTHDAY];
				this.columnSex = base.Columns[COL_SEX];
				this.columnEmail = base.Columns[COL_EMAIL];
				this.columnPhone = base.Columns[COL_PHONE];
				this.columnAddress = base.Columns[COL_ADDRESS];
				this.columnAmount = base.Columns[COL_AMOUNT];
				this.columnCanDo = base.Columns[COL_CANDO];
				this.columnPicture = base.Columns[COL_PICTURE];
			}

			#endregion --- Private Methods ---			
		}

		/// <summary>
		/// 
		/// </summary>
		public class AccountRow : DataRow
		{
			#region --- Memeber Variables ---

			private AccountDataTable tableAccount;

			#endregion --- Memeber Variables ---

			#region --- Properties ---

			/// <summary>
			/// 
			/// </summary>
			public AccountKey PrimaryKey
			{
				get
				{
					AccountKey key = new AccountKey();
					key.UserName = this.UserName;
					return key;
				}
			}

			public string UserName
			{
				get
				{
					if (this.IsUserNameNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.UserNameColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetUserNameNull();
					}
					else
					{
						this[this.tableAccount.UserNameColumn] = value;
					}

				}
			}

			public bool IsUserNameNull()
			{
				return this.IsNull(this.tableAccount.UserNameColumn);
			}

			public void SetUserNameNull()
			{
				this[this.tableAccount.UserNameColumn] = Convert.DBNull;
			}

			public string Password
			{
				get
				{
					if (this.IsPasswordNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.PasswordColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetPasswordNull();
					}
					else
					{
						this[this.tableAccount.PasswordColumn] = value;
					}

				}
			}

			public bool IsPasswordNull()
			{
				return this.IsNull(this.tableAccount.PasswordColumn);
			}

			public void SetPasswordNull()
			{
				this[this.tableAccount.PasswordColumn] = Convert.DBNull;
			}

			public string AccountID
			{
				get
				{
					if (this.IsAccountIDNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.AccountIDColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetAccountIDNull();
					}
					else
					{
						this[this.tableAccount.AccountIDColumn] = value;
					}

				}
			}

			public bool IsAccountIDNull()
			{
				return this.IsNull(this.tableAccount.AccountIDColumn);
			}

			public void SetAccountIDNull()
			{
				this[this.tableAccount.AccountIDColumn] = Convert.DBNull;
			}

			public string TypeAccount
			{
				get
				{
					if (this.IsTypeAccountNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.TypeAccountColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetTypeAccountNull();
					}
					else
					{
						this[this.tableAccount.TypeAccountColumn] = value;
					}

				}
			}

			public bool IsTypeAccountNull()
			{
				return this.IsNull(this.tableAccount.TypeAccountColumn);
			}

			public void SetTypeAccountNull()
			{
				this[this.tableAccount.TypeAccountColumn] = Convert.DBNull;
			}

			public string IdentityCard
			{
				get
				{
					if (this.IsIdentityCardNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.IdentityCardColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetIdentityCardNull();
					}
					else
					{
						this[this.tableAccount.IdentityCardColumn] = value;
					}

				}
			}

			public bool IsIdentityCardNull()
			{
				return this.IsNull(this.tableAccount.IdentityCardColumn);
			}

			public void SetIdentityCardNull()
			{
				this[this.tableAccount.IdentityCardColumn] = Convert.DBNull;
			}

			public string FirstName
			{
				get
				{
					if (this.IsFirstNameNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.FirstNameColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetFirstNameNull();
					}
					else
					{
						this[this.tableAccount.FirstNameColumn] = value;
					}

				}
			}

			public bool IsFirstNameNull()
			{
				return this.IsNull(this.tableAccount.FirstNameColumn);
			}

			public void SetFirstNameNull()
			{
				this[this.tableAccount.FirstNameColumn] = Convert.DBNull;
			}

			public string LastName
			{
				get
				{
					if (this.IsLastNameNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.LastNameColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetLastNameNull();
					}
					else
					{
						this[this.tableAccount.LastNameColumn] = value;
					}

				}
			}

			public bool IsLastNameNull()
			{
				return this.IsNull(this.tableAccount.LastNameColumn);
			}

			public void SetLastNameNull()
			{
				this[this.tableAccount.LastNameColumn] = Convert.DBNull;
			}

			public string Birthday
			{
				get
				{
					if (this.IsBirthdayNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.BirthdayColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetBirthdayNull();
					}
					else
					{
						this[this.tableAccount.BirthdayColumn] = value;
					}

				}
			}

			public bool IsBirthdayNull()
			{
				return this.IsNull(this.tableAccount.BirthdayColumn);
			}

			public void SetBirthdayNull()
			{
				this[this.tableAccount.BirthdayColumn] = Convert.DBNull;
			}

			public string Sex
			{
				get
				{
					if (this.IsSexNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.SexColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetSexNull();
					}
					else
					{
						this[this.tableAccount.SexColumn] = value;
					}

				}
			}

			public bool IsSexNull()
			{
				return this.IsNull(this.tableAccount.SexColumn);
			}

			public void SetSexNull()
			{
				this[this.tableAccount.SexColumn] = Convert.DBNull;
			}

			public string Email
			{
				get
				{
					if (this.IsEmailNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.EmailColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetEmailNull();
					}
					else
					{
						this[this.tableAccount.EmailColumn] = value;
					}

				}
			}

			public bool IsEmailNull()
			{
				return this.IsNull(this.tableAccount.EmailColumn);
			}

			public void SetEmailNull()
			{
				this[this.tableAccount.EmailColumn] = Convert.DBNull;
			}

			public string Phone
			{
				get
				{
					if (this.IsPhoneNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.PhoneColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetPhoneNull();
					}
					else
					{
						this[this.tableAccount.PhoneColumn] = value;
					}

				}
			}

			public bool IsPhoneNull()
			{
				return this.IsNull(this.tableAccount.PhoneColumn);
			}

			public void SetPhoneNull()
			{
				this[this.tableAccount.PhoneColumn] = Convert.DBNull;
			}

			public string Address
			{
				get
				{
					if (this.IsAddressNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.AddressColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetAddressNull();
					}
					else
					{
						this[this.tableAccount.AddressColumn] = value;
					}

				}
			}

			public bool IsAddressNull()
			{
				return this.IsNull(this.tableAccount.AddressColumn);
			}

			public void SetAddressNull()
			{
				this[this.tableAccount.AddressColumn] = Convert.DBNull;
			}

			public string Amount
			{
				get
				{
					if (this.IsAmountNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.AmountColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetAmountNull();
					}
					else
					{
						this[this.tableAccount.AmountColumn] = value;
					}

				}
			}

			public bool IsAmountNull()
			{
				return this.IsNull(this.tableAccount.AmountColumn);
			}

			public void SetAmountNull()
			{
				this[this.tableAccount.AmountColumn] = Convert.DBNull;
			}

			public string CanDo
			{
				get
				{
					if (this.IsCanDoNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.CanDoColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetCanDoNull();
					}
					else
					{
						this[this.tableAccount.CanDoColumn] = value;
					}

				}
			}

			public bool IsCanDoNull()
			{
				return this.IsNull(this.tableAccount.CanDoColumn);
			}

			public void SetCanDoNull()
			{
				this[this.tableAccount.CanDoColumn] = Convert.DBNull;
			}

			public string Picture
			{
				get
				{
					if (this.IsPictureNull())
					{
						return String.Empty;
					}
					return ((string)(this[this.tableAccount.PictureColumn]));
				}
				set
				{
					if (string.IsNullOrEmpty(value))
					{
						this.SetPictureNull();
					}
					else
					{
						this[this.tableAccount.PictureColumn] = value;
					}

				}
			}

			public bool IsPictureNull()
			{
				return this.IsNull(this.tableAccount.PictureColumn);
			}

			public void SetPictureNull()
			{
				this[this.tableAccount.PictureColumn] = Convert.DBNull;
			}


			#endregion --- Properties ---

			#region --- Contructors & Destructors ---	

			internal AccountRow(DataRowBuilder rb) : base(rb)
			{
				this.tableAccount = ((AccountDataTable)(this.Table));
			}

			#endregion --- Contructors & Destructors ---
		}

		/// <summary>
		/// Primary key of table Version
		/// </summary>
		public class AccountKey
		{
			#region ---- Member variables ----


			/// <summary>
			/// Field UserName
			/// </summary>
			private string userName;


			#endregion

			#region ---- Properties ----

			/// <summary>
			/// Get / Set UserName
			/// </summary>
			public string UserName
			{
				get
				{
					return this.userName;
				}
				set
				{
					this.userName = value;
				}
			}

			#endregion

			#region ---- Constructor & Destructor ----

			/// <summary>
			/// Default constructor
			/// </summary>
			public AccountKey()
			{

			}

			#endregion

		}
	}
}
