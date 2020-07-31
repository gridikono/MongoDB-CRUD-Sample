using Microsoft.Extensions.DependencyInjection;
using MongoDBSampleCRUD.Services.Concrete;
using MongoDBSampleCRUD.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBSampleCRUD.Services.DI
{
    public class ServiceRegistry
    {
        public void ConfigureServiceRegistries(IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
        }
    }
}
