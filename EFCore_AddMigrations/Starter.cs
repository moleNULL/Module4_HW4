﻿using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EFCore_AddMigrations
{
    internal class Starter
    {
        public static void Run()
        {
            var options = CreateDbOptions();

            using (var db = new ApplicationContext(options))
            {
                // ...
            }
        }

        // Generate options that will be used in every DbContext
        private static DbContextOptions<ApplicationContext> CreateDbOptions()
        {
            string jsonSettingsFile = "appsettings.json";

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile(jsonSettingsFile);

            var config = builder.Build();
            string? connectionString = config.GetConnectionString("DefaultConnection");

            if (connectionString is null)
            {
                throw new Exception("connectionString is null");
            }

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseSqlServer(connectionString).Options;

            return options;
        }
    }
}
