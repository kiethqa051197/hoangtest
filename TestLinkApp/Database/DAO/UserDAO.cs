using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Web;
using TestLinkApp.Database.DTO;

namespace TestLinkApp.Database.DAO
{
	public class UserDAO
	{
		private static UserDAO instance;

		public static UserDAO Instance
		{
			get { if (instance == null) instance = new UserDAO(); return instance; }
			private set { instance = value; }
		}

		private UserDAO() { }

		public bool Login(string userName, string password)
		{
			int result = DataProvider.Instance.ExecuteNoneQuery("thay câu query vô đây");

			return result > 0;
		}

		public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
		{
			int result = DataProvider.Instance.ExecuteNoneQuery("thay câu query vô đây");

			return result > 0;
		}

		public User GetAccountByUserName(string userName)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("thay câu query vô đây");

			foreach (DataRow item in data.Rows)
			{
				return new User(item);
			}

			return null;
		}

		public DataTable GetListAccount()
		{
			return DataProvider.Instance.ExecuteQuery("thay câu query vô đây");
		}

		public bool InsertAccount(string username, string displayname, int type)
		{
			string query = string.Format("thay câu query vô đây");
			int result = DataProvider.Instance.ExecuteNoneQuery(query);

			return result > 0;
		}
		public bool UpdateAccount(string username, string displayname)
		{
			string query = string.Format("thay câu query vô đây");
			int result = DataProvider.Instance.ExecuteNoneQuery(query);

			return result > 0;
		}

		public bool DeleteAccount(string username)
		{
			string query = string.Format("thay câu query vô đây");
			int result = DataProvider.Instance.ExecuteNoneQuery(query);

			return result > 0;
		}

		public bool ResetPass(string username)
		{
			string query = string.Format("Update Account SET password = N'1962026656160185351301320480154111117132155' where username = N'{0}'", username);
			int result = DataProvider.Instance.ExecuteNoneQuery(query);

			return result > 0;
		}
	}
}
}