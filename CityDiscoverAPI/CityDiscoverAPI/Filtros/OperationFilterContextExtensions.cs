using Microsoft.AspNetCore.Mvc.Filters;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CityDiscoverAPI.Filtros
{
    public static class OperationFilterContextExtensions
    {
        public static CustomAttribute RequiereAttribute<T>(this OperationFilterContext context)
        {
            IEnumerable<IFilterMetadata> globalAttributes = context
                .ApiDescription
                .ActionDescriptor
                .FilterDescriptors
                .Select(p => p.Filter);

            object[] controllerAttributes = context
                .MethodInfo?
                .DeclaringType?
                .GetCustomAttributes(true) ?? Array.Empty<Object>();

            object[] methodAttributes = context
                .MethodInfo?
                .GetCustomAttributes(true) ?? Array.Empty<Object>();

            List<T> containsAttribute = globalAttributes
                .Union(controllerAttributes)
                .Union(methodAttributes)
                .OfType<T>()
                .ToList();

            return containsAttribute.Count == 0
               ? new CustomAttribute(false, false)
               : new CustomAttribute(true, false);

        }
    }
}
