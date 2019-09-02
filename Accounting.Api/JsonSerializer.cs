using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Accounting.Api
{
    public static class JsonSerializer
    {
        private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            ContractResolver = new JsonContractResolver(),
            NullValueHandling = NullValueHandling.Include,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static string SerializeObject(object o)
        {
            return JsonConvert.SerializeObject(o, Formatting.Indented, Settings);
        }

        public class JsonContractResolver : CamelCasePropertyNamesContractResolver
        {
        }
    }
}
