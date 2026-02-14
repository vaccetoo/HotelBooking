namespace HotelBooking.Core.Exceptions
{
	/// <summary>
	/// Multiple validation errors - HTTP 400 Bad Request error
	/// </summary>
	public class ValidationException : BaseAppException
	{
		public IEnumerable<string> Errors { get; }

		public ValidationException(IEnumerable<string> errors) 
			: base("Validation failed!")
		{
			Errors = errors;
		}
	}
}
