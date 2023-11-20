using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
    internal static class InfrastructureExtensions
    {
        public static string GetJsonConnectionString(this DbContext context, string configFileName)
        {
            var config = new ConfigurationBuilder().AddJsonFile(configFileName, true, true).Build();
            return config["ConnectionStrings:Default"];
        }
    }
}
