using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_client
{
	class NewEmail
	{
		public GetUser user;
		public bool SendEmail()
		{
			user = GetUser.getInstance(string.Empty, string.Empty);
			var email = new Email();
			email.From =user.Login;
			return true;
		}
	}
}
