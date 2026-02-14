namespace HotelBooking.Core.Exceptions
{
	public abstract class BaseAppException : Exception
	{
		protected BaseAppException(string message)
			: base(message) 
		{
		}
	}
}
