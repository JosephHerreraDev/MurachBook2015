using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

		public Customer()
		{
		}

		public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				if (value.Length > 30)
					throw new ArgumentOutOfRangeException(
						"Maximum length of First Name is 30");
				else
				firstName = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				if (value.Length > 30)
					throw new ArgumentOutOfRangeException(
						"Maximum length of Last Name is 30");
				else
					lastName = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set
			{
				if (value.Length > 30)
					throw new ArgumentOutOfRangeException(
						"Maximum length of Email is 30");
				else
					email = value;
			}
		}

		public string GetDisplayText() => firstName + " " + lastName + ", " + email;
	}
}
