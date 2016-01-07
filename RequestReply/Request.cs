using DandS.RequestReply.Contracts;

namespace DandS.RequestReply
{
	public class Request<R> : IRequest<R>, ITraceable
	{
		public string SessionChainId { get; private set; }
		public string RequestChainId { get; private set; }
		public R RequestData { get; set; }

		public Request(string sessionChainId, string requestChainId)
		{
			this.SessionChainId		= sessionChainId;
			this.RequestChainId		= requestChainId;
		}
	}
}
