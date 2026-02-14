namespace HotelBooking.Core.Exceptions
{
	/// <summary>
	/// Resources that do not exist - HTTP 404 Not Found error
	/// </summary>
	public class NotFoundException : BaseAppException
	{
		public NotFoundException(string entityName, object id) 
			: base($"{entityName} with ID '{id}' was not found!")
		{
		}
	}
}
