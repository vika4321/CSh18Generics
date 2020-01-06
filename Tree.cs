using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
		public TItem NodeData { get; set; }
		public Tree<TItem> LeftTree { get; set; }
		public Tree<TItem> RightTree { get; set; }

		public Tree(TItem nodeValue)
		{
			this.NodeData = nodeValue;
			this.LeftTree = null;
			this.RightTree = null;
		}

		public void Insert(TItem newItem)
		{
			TItem currentNodeValue = this.NodeData;
			if (currentNodeValue.CompareTo(newItem) > 0)
			{
				//insert the new item into the left subtree
				if (this.LeftTree == null)
				{
					this.LeftTree = new Tree<TItem>(newItem);
				}
				else
				{
					this.LeftTree.Insert(newItem);
				}

			}
			else
			{
				//insert the new item into the right subtree
				if (this.RightTree == null)
				{
					this.RightTree = new Tree<TItem>(newItem);
				}
				else
				{
					this.RightTree.Insert(newItem);
				}
			}
		}

		public void WalkTree()
		{
			if (this.LeftTree != null)
			{
				this.LeftTree.WalkTree();
			}
			
			Console.WriteLine(this.NodeData.ToString());

			if (this.RightTree != null)
			{
				this.RightTree.WalkTree();
			}
		}
    }
}
