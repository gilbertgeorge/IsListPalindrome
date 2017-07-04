using IsListPalindrome.ListNode;
using System;
using System.Collections.Generic;

namespace IsListPalindrome.Program
{
	public static class IsListPalindrome
	{
		public static void Main(string[] args)
		{
			//odd example
			ListNode<int> i = new ListNode<int>();
			i._value = 1;
			i._next = new ListNode<int>(2, new ListNode<int>(4, new ListNode<int>(6, new ListNode<int>(4, new ListNode<int>(2, new ListNode<int>(1, null))))));
			string mirroredValues;

			Console.WriteLine(isListPalindrome(ref i, out mirroredValues));
			Console.WriteLine(mirroredValues);

			//even example
			i = new ListNode<int>();
			i._value = 2;
			i._next = new ListNode<int>(4, new ListNode<int>(5, new ListNode<int>(5, new ListNode<int>(4, new ListNode<int>(2, null)))));

			Console.WriteLine(isListPalindrome(ref i, out mirroredValues));
			Console.WriteLine(mirroredValues);

			//failed example
			i = new ListNode<int>();
			i._value = 2;
			i._next = new ListNode<int>(4, new ListNode<int>(5, new ListNode<int>(3, new ListNode<int>(4, new ListNode<int>(2, null)))));

			Console.WriteLine(isListPalindrome(ref i, out mirroredValues));
			Console.WriteLine(mirroredValues);

			//chars!
			ListNode<char> c = new ListNode<char>();
			c._value = 'a';
			c._next = new ListNode<char>('b', new ListNode<char>('c', new ListNode<char>('d', new ListNode<char>('c', new ListNode<char>('b', new ListNode<char>('a', null))))));

			Console.WriteLine(isListPalindrome(ref c, out mirroredValues));
			Console.WriteLine(mirroredValues);
			Console.Read();
		}

		private static bool isListPalindrome<T>(ref ListNode<T> l, out string mirroredValues) where T : struct
		{
			Stack<T> stack = new Stack<T>();
			List<T> list = new List<T>();
			mirroredValues = string.Empty;

			for(;;)
			{
				if (l != null)
				{
					stack.Push(l._value);
					list.Add(l._value);
					l = l._next;
				}
				else
				{
					for (int v = 0; v < list.Count/2 ; v++)
					{
						if (list[v].Equals(stack.Peek()))
						{
							mirroredValues += list[v].ToString() + " ";
							stack.Pop();
						}
						else
						{
							return false;
						}
					}

					return true;
				}
			}
		}
	}
}
