using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_client
{
	class Test
	{
		public GetUser user;
		public bool SendEmail1()
		{
			user = GetUser.getInstance(string.Empty, string.Empty);
			
			return true;
		}
	}
}
