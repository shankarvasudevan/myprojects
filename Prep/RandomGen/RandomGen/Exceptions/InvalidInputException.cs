using System;
using System.Runtime.Serialization;

namespace RandomGen
{
	[Serializable]
	public class InvalidInputException : Exception
	{
		public InvalidInputException()
		{
			// Add any type-specific logic, and supply the default message.
		}

		public InvalidInputException(string message) : base(message) 
        {
			// Add any type-specific logic.
		}

		public InvalidInputException(string message, Exception innerException) : base (message, innerException)
        {
			// Add any type-specific logic for inner exceptions.
		}

		protected InvalidInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
			// Implement type-specific serialization constructor logic.
		}
	}
}
