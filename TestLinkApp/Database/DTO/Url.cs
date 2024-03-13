using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TestLinkApp.Database.DTO
{
	public class Url
	{
		public Url(string environment, string information, string link)
		{
			this.Environment = environment;
			this.Information = information;
			this.Link = link;
		}

		public Url(DataRow row)
		{
			this.Environment = row["environment"].ToString();
			this.Information = row["information"].ToString();
			this.Link = row["link"].ToString();
		}

		private string environment;
		private string information;
		private string link;

		public string Environment { get => environment; set => environment = value; }
		public string Information { get => information; set => information = value; }
		public string Link { get => link; set => link = value; }
	}
}