using System;

namespace CustomerMaintenance
{
	/// <summary>
	/// Creates a Customer class 
	/// </summary>
    public class Customer
	{
		private string firstName;
		private string lastName;
		private string email;

		/// <summary>
		/// Customer empty Constructor
		/// </summary>
        public Customer()
		{
		}

		/// <summary>
		/// Customer constructor that receives params
		/// </summary>
		/// <param name="firstName"> Customer First Name </param>
		/// <param name="lastName"> Customer Last Name </param>
		/// <param name="email"> Customer Email </param>
        public Customer(string firstName, string lastName, string email)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.email = email;
		}

		/// <summary>
		/// First Name
		/// </summary>
        public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
                firstName = value;
			}
		}

		/// <summary>
		/// Last Name
		/// </summary>
        public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value;
			}
		}

		/// <summary>
		/// Email
		/// </summary>
        public string Email
		{
			get
			{
				return email;
			}
			set
			{
				email = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns> A string with the params </returns>
        public string GetDisplayText()
		{
			return firstName + " " + lastName + ", " + email;
		}
	}
}