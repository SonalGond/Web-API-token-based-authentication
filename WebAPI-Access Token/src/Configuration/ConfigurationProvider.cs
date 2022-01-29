using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebAPI_Access_Token.src.Configuration
{
    public interface IConfigurationProvider
    {
        Task<ConfigurationProvider> GetConfiguration();
    }

    public class ConfigurationProvider : IConfigurationProvider
    {
        //private readonly IParameterProvider _parameterProvider;
        //private readonly ILogger<ConfigurationProvider> _logger;

        public Task<ConfigurationProvider> GetConfiguration()
        {
            throw new NotImplementedException();
        }
    }
}