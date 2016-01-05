using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandS.RequestReply.Contracts
{
	public interface IRequest<R>
	{
		string SessionChainId { get; }
		string RequestChainId { get; }
		R RequestData { get; set; }
	}
}
