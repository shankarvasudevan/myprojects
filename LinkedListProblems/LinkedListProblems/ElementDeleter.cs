using System;

namespace LinkedListProblems
{
	public class ElementDeleter
	{
		public void Delete(StringNode elem)
		{
			while (elem != null) 
			{
				StringNode tmp = (StringNode) elem.Next;

				if (tmp != null) 
				{
					elem.Id = tmp.Id;
					elem.Data = tmp.Data;
					elem.Next = tmp.Next;
				}

				elem = tmp;
			}
		}
	}
}

