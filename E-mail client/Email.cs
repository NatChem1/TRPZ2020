using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_client
{
	class Email
	{
		public string From { get; set; }
		public string To { get; set; }
		public string Copy { get; set; }
		public string Title { get; set; }
		public bool Send { get; set; }
		public string Text { get; set; }
		public bool Attachmebts { get; set; }
		public string FolderId { get; set; }
	}
}
