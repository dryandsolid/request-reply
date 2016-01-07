using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandS.RequestReply.Contracts
{
	public interface IReply<R> : ITraceable
	{
		bool IsSuccessful { get; }
		bool HasWarnings { get; }
		bool HasInfoItems { get; }
		List<IOpStatusItem> InfoItems { get; }
		List<IOpStatusItem> Warnings { get; }
		List<IOpStatusItem> Errors { get; }
		R ReplyData { get; set; }

		void AddIinfoItem(IOpStatusItem item);
		void AddWarningItem(IOpStatusItem item);
		void AddErrorItem(IOpStatusItem item);
	}
}
