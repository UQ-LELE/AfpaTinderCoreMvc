using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AfpaTinderCoreMvc.Data
{
    public class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            string path = Directory.GetCurrentDirectory();

            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsetting.json");

            var config = builder.Build();

            var connectionString = config.GetConnectionString("AfpaTinderBDD");

            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
