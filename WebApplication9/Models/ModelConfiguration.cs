using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication9.Models
{
    public class ModelConfiguration : IModelConfiguration
    {
        public void Apply(ODataModelBuilder builder, ApiVersion apiVersion, string routePrefix)
        {
            builder.EntitySet<Animal>("Animals");
        }
    }
}
