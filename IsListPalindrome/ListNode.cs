using System;
using System.Collections.Generic;

namespace ListNode
{
	public class ListNode<T>
	{
		public ListNode()
		{
			this.value = default(T);
			this.next = null;
		}

		public ListNode(T cValue, ListNode<T> cNext)
		{
			this.value = cValue;
			this.next = cNext;
		}

		public static bool operator ==(ListNode<T> a, T b)
		{
			dynamic da = a, db = b;
			return da.value == db;
		}

		public static bool operator !=(ListNode<T> a, T b)
		{
			dynamic da = a, db = b;
			return da.value == db;
		}

		public override bool Equals(object obj)
		{
			dynamic da = this.value, db = obj;
			return da == db;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public T value { get; set; }
		public ListNode<T> next { get; set; }
	}
}
