using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
	class CustomerList
	{
		private List<Customer> customersList;
		public delegate void ChangeHandler(CustomerList customerList);
		public event ChangeHandler Changed;

		public CustomerList()
		{
			customersList = new List<Customer>();
		}	

		public Customer this[int i]
		{
			get{if (i < 0 || i >= customersList.Count())
				throw new ArgumentOutOfRangeException(i.ToString());
				else
				return customersList[i];}

			set { customersList[i] = value; Changed(this); }
		}

		public int count
		{
			get => customersList.Count;			
		}

		public void Add(Customer customer)
		{
			customersList.Add(customer);
			Changed(this);
		}

		public void Remove(Customer customer) 
		{
			customersList.Remove(customer);
			Changed(this);
		}

		public void Fill() => customersList = CustomerDB.GetCustomers();

		public void Save() => CustomerDB.SaveCustomers(customersList);

		public static CustomerList operator +(CustomerList customerList, Customer customer)
		{
			customerList.Add(customer);
			return customerList;
		}

		public static CustomerList operator -(CustomerList customerList, Customer customer)
		{
			customerList.Remove(customer);
			return customerList;
		}
	}
}
