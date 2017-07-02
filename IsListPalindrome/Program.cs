using ListNode;
using System;
using System.Collections.Generic;

namespace IsListPalindrome
{
	public static class IsListPalindrome
	{
		public static void Main(string[] args)
		{
			ListNode<int> l = new ListNode<int>();
			l.value = 1;
			l.next = new ListNode<int>(2, new ListNode<int>(4, new ListNode<int>(6, new ListNode<int>(4, new ListNode<int>(2, new ListNode<int>(1, null))))));

			Console.Write(isListPalindrome(ref l));

			Console.Read();
		}

		private static bool isListPalindrome<T>(ref ListNode<T> l) where T : struct
		{
			bool retVal = false;
			Stack<T> values = new Stack<T>();
			ListNode<T> t = new ListNode<T>();
			t = l;

			while (l != null)
			{
				if (l.next != null)
				{
					values.Push(l.value);
					l = l.next;
				}
				else
				{
					int count = values.Count;
					while (values.Count > count / 2)
					{
						values.Pop();
					}

					for(int v = 0;v < values.Count;v++)
					{
						Console.Write(t.value);

						if (t == values.Peek())
						{
							t = t.next;
							values.Pop();
						}
						else
						{
							break;
						}
					}

					retVal = true;
				}
			}

			return retVal;
		}

	}
}
