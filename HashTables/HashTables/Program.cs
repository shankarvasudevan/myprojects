using System;
using System.Collections.Generic;

namespace HashTables
{
	class MainClass
	{
		private const int MAX_HASH_ENTRIES = 10000;
		public static void Main (string[] args)
		{
			var bridalParty = new List<string> 
			{
				"Shankar",
				"Vruchi",
				"Aman",
				"Naman",
				"Dinesh",
				"Chiranth",
				"Sabinesh",
				"Akshat",
				"Krish",
				"Neeru",
				"Jaya",
				"Rajshri",
				"Natalia",
				"Sanaa"
			};

			string[] bridalPartyHt = GenerateHashTable (bridalParty);

			Console.WriteLine ("Was {0} in bridal party? {1}", "Sabinesh", Contains (bridalPartyHt, "Sabinesh"));
			Console.WriteLine ("Was {0} in bridal party? {1}", "Kelly", Contains (bridalPartyHt, "Kelly"));
			Console.WriteLine ("Was {0} in bridal party? {1}", "Shankar", Contains (bridalPartyHt, "Shankar"));
		}

		public static bool Contains(string[] ht, string val)
		{
			char[] valArr = val.ToCharArray ();

			int hash = 0;
			for (int i = 0; i < valArr.Length; i++) 
			{
				hash += (int)valArr [i];
			}

			if (ht [hash] == val) 
			{
				return true;
			}

			for (int i = hash + 1; ht [i] != null && i < MAX_HASH_ENTRIES; i++) 
			{
				if (ht [i] == val) 
				{
					return true;
				}
			}

			return false;
		}
			
		public static string[] GenerateHashTable(List<string> values)
		{
			string[] ht = new string[MAX_HASH_ENTRIES];

			foreach (var val in values) 
			{
				char[] valArr = val.ToCharArray ();
				int hash = 0;
				for (int i = 0; i < valArr.Length; i++) 
				{
					hash += (int)valArr[i];
				}

				if (ht [hash] == null) 
				{
					ht [hash] = val;
				} 
				else 
				{
					bool foundSlot = false;

					for (int i=hash+1; !foundSlot && i < MAX_HASH_ENTRIES; i++)
					{
						if (ht [i] == null) 
						{
							ht [i] = val;
							foundSlot = true;
						}
					}

					if (!foundSlot) 
					{
						throw new Exception ("Got collision");
					}
				}

			}

			return ht;
		}
	}
}
