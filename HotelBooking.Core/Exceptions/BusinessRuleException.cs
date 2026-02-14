namespace HotelBooking.Core.Exceptions
{
	/// <summary>
	/// Broken business rules - HTTP 400 Bad Request error
	/// </summary>
	public class BusinessRuleException : BaseAppException
	{
		public BusinessRuleException(string message) 
			: base(message)
		{
		}
	}
}
