using System;

namespace LinkedListProblems
{
	public class ElementDeleter
	{
		public void Delete(Node elem)
		{
			while (elem != null) 
			{
				Node tmp = elem.Next;

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

