using System;
using DandS.RequestReply.Contracts;

namespace DandS.RequestReply.Concretes
{
	public class OpStatusItem : IOpStatusItem
	{
		public string FriendlyName { get; private set; }

		public string Message { get; private set; }

		public string PropertyName { get; private set; }

		public string StatusCode { get; private set; }

		public virtual void LogOpStatusItem()
		{
			throw new NotImplementedException();
		}

		public OpStatusItem(string propertyName, string friendlyName, string statusCode, string message, bool logThis)
		{
			this.PropertyName	= propertyName;
			this.FriendlyName	= friendlyName;
			this.StatusCode		= statusCode;
			this.Message		= message;

			if (logThis)
			{
				LogOpStatusItem();
			}
		}
	}
}
