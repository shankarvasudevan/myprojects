using System;
using NUnit.Framework;
using PracticeProblems;

namespace PracticProblems.Tests
{
	[TestFixture]
	public class StringReverserTest
	{
		[Test]
		public void Reverse_EmptyArray_ReturnsEmpty () 
		{
			char [] original = new char [0];
			char [] reversed = StringReverser.Reverse (original);
			Assert.That (reversed, Is.Empty);
		}

		[Test]
		public void Reverse_OnlyNullCharacter_ReturnsNullCharacter ()
		{
			char [] original = new [] { '\0' };
			char [] reversed = StringReverser.Reverse (original);
			Assert.That (reversed, Is.EqualTo(original));
		}

		[Test]
		public void Reverse_DifferentCharacters_ReversesCorrectly ()
		{
			char [] original = new [] { 'a', 'b', 'c', '\0' };
			char [] reversed = StringReverser.Reverse (original);
			Assert.That (reversed, Is.EquivalentTo (new [] { '\0', 'c', 'b', 'a' }));
		}

		[Test]
		public void Reverse_Palindrome_ReversesCorrectly ()
		{
			char [] original = new [] { 'a', 'b', 'c', 'b', 'a', '\0' };
			char [] reversed = StringReverser.Reverse (original);
			Assert.That (reversed, Is.EquivalentTo (new [] { '\0', 'a', 'b', 'c', 'b', 'a' }));
		}
	}
}