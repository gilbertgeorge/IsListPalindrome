namespace ListNode
{
	class ListNode<T>
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

		public T value { get; set; }
		public ListNode<T> next { get; set; }
	}
}
