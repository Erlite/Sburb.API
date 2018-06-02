using System;

namespace Sburb.API.Reflection
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class EndpointNameAttribute : Attribute
    {
        private string _endpointName;

        public EndpointNameAttribute(string endpointName)
        {
            _endpointName = endpointName;
        }

        public EndpointNameAttribute()
        {
            _endpointName = null;
        }

        public string Name { get { return _endpointName; } }
    }
}
