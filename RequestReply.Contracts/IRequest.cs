﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandS.RequestReply.Contracts
{
	public interface IRequest<R> : ITraceable
	{
		R RequestData { get; set; }
	}
}
