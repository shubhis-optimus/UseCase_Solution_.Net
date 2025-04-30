using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;




namespace POS.Application
{
    public static  class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            //services.AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<ConfigureServices>());
            //services.AddTransient<IRequestPostProcessor<,>, RequestPostProcessor<,>>();
            return services;
        }
    }
}
