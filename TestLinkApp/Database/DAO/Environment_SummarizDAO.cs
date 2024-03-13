using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TestLinkApp.Database.DTO;

namespace TestLinkApp.Database.DAO
{
	public class Environment_SummarizDAO
	{
		private static Environment_SummarizDAO instance;

		public static Environment_SummarizDAO Instance
		{
			get { if (instance == null) instance = new Environment_SummarizDAO(); return Environment_SummarizDAO.instance; }
			private set { Environment_SummarizDAO.instance = value; }
		}

		private Environment_SummarizDAO() { }

		public List<Environment_Summariz> GetListUrl()
		{
			List<Environment_Summariz> list = new List<Environment_Summariz>();

			string query = "SELECT * FROM Environment_Summariz";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Environment_Summariz environment_Summariz = new Environment_Summariz(item);
				list.Add(environment_Summariz);
			}

			return list;
		}
	}
}