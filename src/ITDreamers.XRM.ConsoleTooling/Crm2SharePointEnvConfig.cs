using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace ITDreamers.XRM.TestConsoleHelpers
{
    public class Crm2SharePointEnvConfig : EnvConfig
    {
        public Crm2SharePointEnvConfig()
        {
        }

        public Crm2SharePointEnvConfig(string variablesGroupKey) : base(variablesGroupKey)
        {
        }

        //public AuthConfig SPAuthConfig => new AuthConfig(Tenant, SharePointServerUri, ClientId, SPUserCredentials);

        public string Tenant => _envVariables[$"{_variablesGroupKey}_Tenant"].ToString();

        public Guid ClientId => new Guid(_envVariables[$"{_variablesGroupKey}_ClientId"].ToString());

        public Uri SharePointServerUri => new Uri(_envVariables[$"{_variablesGroupKey}_SPServerUri"].ToString());

        public string SharePointUrl => _envVariables[$"{_variablesGroupKey}_D365_URL"].ToString();
        public string SharePointLgn => _envVariables[$"{_variablesGroupKey}_D365_LGN"].ToString();
        public string SharePointPswd => _envVariables[$"{_variablesGroupKey}_D365_PSWD"].ToString();

        public UserCredential SharePointCredentials => new UserCredential(SharePointLgn, SharePointPswd);

    }
}
