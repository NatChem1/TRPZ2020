using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_client
{
	class GetUser
	{
		public string Password { get; private set; }
		public string Login { get; private set; }
		protected GetUser(string login, string password)
		{
			this.Login = string.Empty;
		}

		private static GetUser currentuser;
		public static GetUser getInstance(string login, string password)
		{
			if (currentuser == null)
				currentuser = new GetUser(login, password);
			return currentuser;
		}

	}
}
