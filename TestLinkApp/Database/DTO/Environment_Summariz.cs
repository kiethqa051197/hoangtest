using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast;

namespace TestLinkApp.Database.DTO
{
	public class Environment_Summariz
	{
		public Environment_Summariz(string functionName)
		{
			this.FunctionName = functionName;
		}

		public Environment_Summariz(DataRow row)
		{
			this.FunctionName = row["functionName"].ToString();
		}

		private string functionName;

		public string FunctionName { get => functionName; set => functionName = value; }
	}
}