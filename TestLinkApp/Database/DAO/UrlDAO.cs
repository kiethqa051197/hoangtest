using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TestLinkApp.Database.DTO;

namespace TestLinkApp.Database.DAO
{
	public class UrlDAO
	{
		private static UrlDAO instance;

		public static UrlDAO Instance
		{
			get { if (instance == null) instance = new UrlDAO(); return UrlDAO.instance; }
			private set { UrlDAO.instance = value; }
		}

		private UrlDAO() { }

		public List<Url> GetListUrl()
		{
			List<Url> list = new List<Url>();

			string query = "SELECT * FROM Url";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Url Url = new Url(item);
				list.Add(Url);
			}

			return list;
		}

		public Url GetUrlByEnvironment(int environment)
		{
			Url Url = null;

			string query = "SELECT * FROM Url WHERE Environment = N'" + environment + "'";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Url = new Url(item);
				return Url;
			}

			return Url;
		}
	}
}