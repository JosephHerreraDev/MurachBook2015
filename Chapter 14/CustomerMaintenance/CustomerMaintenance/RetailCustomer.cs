using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
	class RetailCustomer : Customer
	{
		private string homePhone;

		public string HomePhone
		{
			get { return homePhone; }
			set { homePhone = value; }
		}

		public RetailCustomer() { }

		public RetailCustomer(string firstName, string lastName, string email, string homePhone)
		{
			base.FirstName = firstName;
			base.LastName = lastName;
			base.Email = email;
			HomePhone = homePhone;
		}

		public override string GetDisplayText()
		{
			return base.GetDisplayText() + " ph:" + HomePhone;
		}

	}
}
