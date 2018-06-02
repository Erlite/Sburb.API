using Sburb.API.Reflection;

namespace Sburb.API.Models
{
    public class RequestType
    {
        [EndpointName("utils.")]
        public enum Utils
        {
            [EndpointName("current_time")]
            Current_Time,
        }
    }
}
