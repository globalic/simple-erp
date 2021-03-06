﻿using Integration.Contracts.Commands;
using System;

namespace ERP.SPA.Application.Commands
{
	public class StornirajStavku : IStornirajStavku
	{
		public Guid CommandId { get; }
		public long? Version { get; }
		public string UserId { get; }
		public Guid IdNaloga { get; }
		public Guid IdStavke { get; }

		public StornirajStavku(Guid commandId, long? version, string userId, Guid idNaloga, Guid idStavke)
		{
			this.CommandId = commandId;
			this.Version = version;
			this.UserId = userId;
			this.IdNaloga = idNaloga;
			this.IdStavke = idStavke;
		}
	}
}
