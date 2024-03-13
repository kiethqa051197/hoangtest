using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TestLinkApp.Database.DTO
{
	public class User
	{
		public User(string privilege, string userName, string passWord = null)
		{
			this.Privilege = privilege;
			this.UserName = userName;
			this.PassWord = passWord;
		}

		public User(DataRow row)
		{
			this.Privilege = row["privilege"].ToString();
			this.UserName = row["userName"].ToString();
			this.PassWord = row["passWord"].ToString();
		}

		private string privilege;
		private string userName;
		private string passWord;

		public string Privilege { get => privilege; set => privilege = value; }
		public string UserName { get => userName; set => userName = value; }
		public string PassWord { get => passWord; set => passWord = value; }
	}
}