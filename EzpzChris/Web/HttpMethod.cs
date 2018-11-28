namespace EzpzChris.Web
{
    using System.ComponentModel;

    enum HttpMethod
    {
        [Description("CONNECT")]Connect,
        [Description("DELETE")]Delete,
        [Description("GET")]Get,
        [Description("HEAD")]Head,
        [Description("POST")]Post,
        [Description("PUT")]Put,
        [Description("TRACE")]Trace
    }
}
