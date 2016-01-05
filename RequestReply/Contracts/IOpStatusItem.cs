using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandS.RequestReply.Contracts
{
	public interface IOpStatusItem
	{
		string PropertyName { get; }

		string FriendlyName { get; }

		string StatusCode { get; }
		string Message { get; }

		void LogOpStatusItem();
	}
}
