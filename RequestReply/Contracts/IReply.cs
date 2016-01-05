using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandS.RequestReply.Contracts
{
	public interface IReply<R>
	{
		bool IsSuccessful { get; }
		bool HasWarnings { get; }
		bool HasInfoItems { get; }
		string SessionChainId { get; }
		string RequestChainId { get; }
		List<IOpStatusItem> InfoItems { get; }
		List<IOpStatusItem> Warnings { get; }
		List<IOpStatusItem> Errors { get; }
		R ReplyData { get; set; }

		void AddIinfoItem(IOpStatusItem item);
		void AddWarningItem(IOpStatusItem item);
		void AddErrorItem(IOpStatusItem item);
	}
}
