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

        public string Tenant => _envVariables[$"{VariablesGroupKey}_Tenant"].ToString();

        public Guid ClientId => new Guid(_envVariables[$"{VariablesGroupKey}_ClientId"].ToString());

        public string SharePointUrl => _envVariables[$"{VariablesGroupKey}_SP_URL"].ToString();
        public string SharePointLgn => _envVariables[$"{VariablesGroupKey}_SP_LGN"].ToString();
        public string SharePointPswd => _envVariables[$"{VariablesGroupKey}_SP_PSWD"].ToString();

        public UserCredential SharePointCredentials => new UserCredential(SharePointLgn, SharePointPswd);

    }
}
