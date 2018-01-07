namespace IsListPalindrome.ListNode
{
	public class ListNode<T>
	{
		private T _value;
		private ListNode<T> _next;

		public T Value
		{
			get
			{
				return _value;
			}
			set
			{
				_value = value;
			}
		}

		public ListNode<T> Next
		{
			get
			{
				return _next;
			}
			set
			{
				_next = value;
			}
		}

		public ListNode()
		{
			this._value = default(T);
			this._next = null;
		}

		public ListNode(T cValue, ListNode<T> cNext)
		{
			this._value = cValue;
			this._next = cNext;
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
			dynamic da = this._value, db = obj;
			return da == db;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
