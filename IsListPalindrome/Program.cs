using ListNode;
using System;

namespace IsListPalindrome
{
	public static class Program
	{
		static void Main(string[] args)
		{
			ListNode<int> l = new ListNode<int>();
			l.value = 1;
			l.next = new ListNode<int>(2, new ListNode<int>(1,null));

			Console.Write(isListPalindrome(l));

			Console.Read();
		}

		static bool isListPalindrome(ListNode<int> l)
		{
			ListNode<int> temp = l;
			int count = 0;

			while (l != null)
			{
				Console.WriteLine(l.value);
				count++;

				if (l.next != null)
				{
					l = l.next;
				}
				else
				{
					break;
				}
			}

			return false;
		}

	}
}
