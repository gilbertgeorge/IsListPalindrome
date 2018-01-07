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
			ListNode<int> oddCountList = new ListNode<int>();
			oddCountList.Value = 1;
			oddCountList.Next = new ListNode<int>(2, new ListNode<int>(4, new ListNode<int>(6, new ListNode<int>(4, new ListNode<int>(2, new ListNode<int>(1, null))))));
			PrintMirroredValues(ref oddCountList);

			//even example
			ListNode<int> evenCountList = new ListNode<int>();
			evenCountList.Value = 2;
			evenCountList.Next = new ListNode<int>(4, new ListNode<int>(5, new ListNode<int>(5, new ListNode<int>(4, new ListNode<int>(2, null)))));
			PrintMirroredValues(ref evenCountList);

			//failed example
			ListNode<int> failList = new ListNode<int>();
			failList.Value = 2;
			failList.Next = new ListNode<int>(4, new ListNode<int>(5, new ListNode<int>(3, new ListNode<int>(4, new ListNode<int>(2, null)))));
			PrintMirroredValues(ref failList);

			//chars!
			ListNode<char> charList = new ListNode<char>();
			charList.Value = 'a';
			charList.Next = new ListNode<char>('b', new ListNode<char>('c', new ListNode<char>('d', new ListNode<char>('c', new ListNode<char>('b', new ListNode<char>('a', null))))));
			PrintMirroredValues(ref charList);

			Console.Read();
		}

		private static void PrintMirroredValues<T>(ref ListNode<T> list) where T : struct
		{
			string mirroredValues;
			var status = isListPalindrome(ref list, out mirroredValues);

			if (status)
			{
				Console.WriteLine($"Palindrome found, mirrored values are: {mirroredValues}");
			}
			else
			{
				Console.WriteLine($"No palindrome found.");
			}
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
					stack.Push(l.Value);
					list.Add(l.Value);
					l = l.Next;
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
