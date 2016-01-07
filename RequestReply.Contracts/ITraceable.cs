using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandS.RequestReply.Contracts
{
	public interface ITraceable
	{
		string SessionChainId { get; }
		string RequestChainId { get; }
	}
}
