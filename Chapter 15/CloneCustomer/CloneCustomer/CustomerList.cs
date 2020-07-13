using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CloneCustomer
{
    public class CustomerList : IEnumerable<Customer>
	{
        private List<Customer> customers = new List<Customer>();

		public int Count => customers.Count;

		public Customer this[int i] => customers[i];

		public void Add(Customer customer) => customers.Add(customer);

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator<Customer> IEnumerable<Customer>.GetEnumerator()
		{
			foreach (Customer item in customers)
			{
				yield return item;
			}
		}
	}
}
