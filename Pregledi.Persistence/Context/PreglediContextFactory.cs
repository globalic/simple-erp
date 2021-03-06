﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace Pregledi.Persistence.Context
{
	public class PreglediContextFactory : IDesignTimeDbContextFactory<PreglediContext>
	{
		public PreglediContext CreateDbContext(string[] args)
		{
			IConfigurationRoot config = new ConfigurationBuilder()
			   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
			   .AddJsonFile("appsettings.Migrations.json", optional: false)
			   .Build();

			var optionsBuilder = new DbContextOptionsBuilder<PreglediContext>();
			optionsBuilder.UseMySql(config["ConnectionString"], x => x.ServerVersion(Version.Parse(config["MYSQL_VERSION"]), ServerType.MySql));

			return new PreglediContext(optionsBuilder.Options);
		}
	}
}
