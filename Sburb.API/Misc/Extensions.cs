using Sburb.API.Reflection;
using System;
using System.Reflection;

namespace Sburb.API.Misc
{
    public static class Extensions
    {
        /// <summary>
        /// Creates the endpoint type string from the given enum if possible.
        /// </summary>
        public static string BuildEndpoint(this Enum endpoint)
        {
            Type type = endpoint.GetType();
            string name = string.Empty;

            // Get the enum endpoint name.
            TypeInfo info = type.GetTypeInfo();
            EndpointNameAttribute enumName = info.GetCustomAttribute<EndpointNameAttribute>();

            if (enumName == null)
            {
                throw new InvalidOperationException($"{type.Name} does not have any EndpointNameAttribute.");
            }

            if (enumName.Name != null)
            {
                name += enumName;
            }

            // Get the endpoint value attribute.
            FieldInfo fields = type.GetField(endpoint.ToString());
            EndpointNameAttribute endpointName = fields.GetCustomAttribute<EndpointNameAttribute>();

            if (endpointName == null)
            {
                throw new InvalidOperationException($"{endpoint.ToString()} does not have any EndpointNameAttribute.");
            }

            if (endpointName.Name == null)
            {
                throw new InvalidOperationException($"{endpoint.ToString()} does not give any endpoint name in EndpointNameAttribute.");
            }

            name += endpointName.Name;
            return name;
        }
    }
}
