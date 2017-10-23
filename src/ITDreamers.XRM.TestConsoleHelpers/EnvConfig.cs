using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDreamers.XRM.TestConsoleHelpers
{
    public class EnvConfig
    {
        protected IDictionary _envVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);

        public EnvConfig()
        {

        }

        public EnvConfig(string variablesGroupKey)
        {
            VariablesGroupKey = variablesGroupKey;
        }

        public string VariablesGroupKey { get; set; }
        public string D365Url => _envVariables[$"{VariablesGroupKey}_D365_URL"].ToString();
        public string D365Lgn => _envVariables[$"{VariablesGroupKey}_D365_LGN"].ToString();
        public string D365Pswd => _envVariables[$"{VariablesGroupKey}_D365_PSWD"].ToString();

        public string CrmConnectionString => $"Url={D365Url};Username={D365Lgn};Password={D365Pswd};AuthType=Office365;";
    }
}
