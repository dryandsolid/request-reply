﻿using System.Collections.Generic;
using DandS.RequestReply.Contracts;

namespace DandS.RequestReply
{
	public class Reply<R> : IReply<R>, ITraceable
	{
		public virtual bool IsSuccessful
		{
			get
			{
				return Errors.Count == 0;
			}
		}
		public virtual bool HasWarnings
		{
			get
			{
				return Warnings.Count > 0;
			}
		}

		public virtual bool HasInfoItems
		{
			get
			{
				return InfoItems.Count > 0;
			}
		}

		public string SessionChainId { get; }
		public string RequestChainId { get; }

		public List<IOpStatusItem> InfoItems { get; private set; }
		public List<IOpStatusItem> Warnings { get; private set; }
		public List<IOpStatusItem> Errors { get; private set; }
		public R ReplyData { get; set; }

		public Reply()
		{
			InitLists();
		}

		public Reply(R replyData)
		{
			InitLists();
			this.ReplyData = replyData;
		}

		public void AddOpStatusItem(List<IOpStatusItem> list, IOpStatusItem item)
		{
			list.Add(item);
		}

		public void AddOpStatusItems(List<IOpStatusItem> list, List<IOpStatusItem> items)
		{
			list.AddRange(items);
		}

		private void InitLists()
		{
			InfoItems = new List<IOpStatusItem>();
			Warnings = new List<IOpStatusItem>();
			Errors = new List<IOpStatusItem>();
		}
	}
}
