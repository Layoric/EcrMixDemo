using System;
using ServiceStack;
using EcrMixDemo.ServiceModel;

namespace EcrMixDemo.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
