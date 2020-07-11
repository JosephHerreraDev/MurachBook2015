using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
	class WholesaleCustomer : Customer
	{
		private string company;

		public WholesaleCustomer()
		{

		}

		public WholesaleCustomer(string firstName, string lastName, string email, string company)
		{
			base.FirstName = firstName;
			base.LastName = lastName;
			base.Email = email;
			Company = company;
		}

		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		public override string GetDisplayText()
		{
			return base.GetDisplayText() + "(" + Company + ")";
		}

	}
}
