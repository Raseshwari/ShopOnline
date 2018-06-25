using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Services
{
    public interface IWelcome
    {
        string WelcomeMessage();
    }

    public class Welcome : IWelcome
    {
        private IConfiguration _configuration;

        public Welcome(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string WelcomeMessage()
        {

            return _configuration["WelcomeMsg"];
        }
    }

}
