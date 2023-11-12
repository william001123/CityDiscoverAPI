﻿using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CityDiscoverAPI.Filtros
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AcepteLenguajeHeader : Attribute, IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            CustomAttribute attribute = context.RequiereAttribute<AcepteLenguajeHeader>();

            if (!attribute.ContainsAttribute)
                return;

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "Token",
                In = ParameterLocation.Header,
                Required = false,
                Schema = new OpenApiSchema { Type = "string" }
            });
        }
    }
}
