﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
	public struct Customer
	{
		private string firstName;
		private string lastName;
		private string email;


		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}	
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		public string GetDisplayText() => firstName + " " + lastName + ", " + email;


		public Customer(string firstname, string lastname, string email)
		{
			this.firstName = firstname;
			this.lastName = lastname;
			this.email = email;
		}
		
		
	}
}