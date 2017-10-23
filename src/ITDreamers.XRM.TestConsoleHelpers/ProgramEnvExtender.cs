using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITDreamers.XRM.TestConsoleHelpers
{
    public class ProgramEnvExtender
    {
        public static void ExportEnvConfig()
        {
        }

        public static void ImportEnvConfig()
        {
        }

        public static T GetEnvConfig<T>(string[] args) where T : EnvConfig, new()
        {
            var variablesGroupKey = args[0];
            return new T { VariablesGroupKey = variablesGroupKey };
        }
    }
}
