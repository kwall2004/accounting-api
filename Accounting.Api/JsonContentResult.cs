using Microsoft.AspNetCore.Mvc;

namespace Accounting.Api
{
    public class JsonContentResult : ContentResult
    {
        public JsonContentResult()
        {
            ContentType = "application/json";
        }
    }
}
