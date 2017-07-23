using System;
using System.Collections.Generic;
using System.Linq;
using PracticeProblems;

namespace PracticeProblems
{
	public class BstToLinkedListConverter
	{
		/*
		 * Algorithm:
		 * - Start at root, create LinkedList for root
		 * - Look at left subtree, create LinkedList for left subtree & right subtree
		 * 
		 * Infix Traversal (Left, Node, Right)
		 * Prefix Traversal (Node, Left, Right)
		 * Postfix Traversal (Left, Right, Node)
		 * 
		 *    4
		 *  2	 6
		 * 1 3 	5 7
		 * 
		 * Infix (1,2,3,4,5,6,7)
		 * Prefix (4,2,1,3,6,5,7)
		 * Postfix (1,3,2,5,7,6,4)
		 * 
		 * Start at 4
		 * 
		 * 
		 * 
		 */
		public List<LinkedList<TreeNode<int>>> Convert(TreeNode<int> root)
		{
			if (root == null)
			{
				return new List<LinkedList<TreeNode<int>>>();
			}

			int level = 0;
			List<LinkedList<TreeNode<int>>> result = new List<LinkedList<TreeNode<int>>>();
			LinkedList<TreeNode<int>> list = new LinkedList<TreeNode<int>>();
			list.AddLast(root);

			result.Add(list);
			while (true)
			{
				list = new LinkedList<TreeNode<int>>();
				for (int i = 0; i < result[level].Count; i++)
				{
					TreeNode<int> curr = result[level].ElementAt(i);
					if (curr != null)
					{
						if (curr.Left != null)
						{
							list.AddLast(curr.Left);
						}

						if (curr.Right != null)
						{
							list.AddLast(curr.Right);
						}
					}
				}

				if (list.Count > 0)
				{
					result.Add(list);
				}
				else
				{
					break;
				}

				level++;
			}

			return result;
		}
	}
}
