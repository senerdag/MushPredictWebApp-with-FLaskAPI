using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MushPredict.Data.Context;
using MushPredict.Data.Repositories.Abstractions;
using MushPredict.Data.Repositories.Concretes;
using MushPredict.Data.UnitOfWorks;
using MushPredict.Service.Services.Abstractions;
using MushPredict.Service.Services.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MushPredict.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<ISpeciesService,SpeciesService>();

            return services;
        }
    }
}
