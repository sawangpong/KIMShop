using KIM.data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM
{
	#region Enum
	public enum UserPermission
	{
		None,
		User,
		Supervisor,
		Manager,
		SystemAdmin = 9
	}

	public enum DataActionMode
	{
		None,
		Add,
		Edit,
		Delete,
		Create,
		Modify,
		Update,
		View
	}

	public enum ActionStatus
	{
		Hold = 0,
		Active = 1,
		Completed = 2,
		Cancel = 3
	}

	public enum CustomerType
	{
		Dealer = 1,
		Regular = 2,
		Walkin = 3,
		EndUser = 4
	}

	public enum CustomerIndustry
	{
		Other = 0,
		Manufacturer = 1,
		Trading = 2
	}

	public enum CustomerStatus
	{
		Suspend = 0,
		Normal = 1,
		Limited = 2
	}

	public enum VendorStatus
	{
		Suspend = 0,
		Normal = 1,
		Limited = 2
	}
	public enum VendorType
	{
		Trader = 0,
		Manufacturer = 1,
		ProductOwner = 2
	}

	public enum InputTypeValue
	{
		Number,
		Text
	}

	public enum ICControlMode
	{
		None,
		StockReceive = 1,
		StockIssue = 2,
		StockPurchse = 3,
		ReturnPurchase = 4,
		ShipmentOrder = 5,
		ReturnShipment = 6
	}

	#endregion

	public static class vars
	{
		public static string LANG_USE = "EN";
		public const string APP_KEY = "KimShop";
		public const string SYS_CONN_NAME = "KIMEntities";
		public const string DEFAULT_DB_NAME = "KIMDB";

		public static SysProfile SYS_PROFILE = new SysProfile();
		public static string CONNECTION_NAME = string.Empty;
		public static string COMPANY_CODE = "KIM NGOUN";

		public static string SERVER = @"OM-GM-06\SQLEXPRESS";
		public static string DBNAME = "KIMDB";
		public static string DBUSER = "sa";
		public static string DBPassword = "120486300";

		public static int USER_ID = 0;
		public static string USER_NAME = "";
		public static string COMP_NAME = System.Environment.MachineName;

		public static string USER_PASSWORD = string.Empty;
		public static UserPermission USER_PERMISSION = UserPermission.None;
		public static int PERMISSION_ID = (int)UserPermission.None;
		public static string PERMISSION_NAME = UserPermission.None.ToString();

		public static Hashtable LANG_DICT = new Hashtable();
	}
}
