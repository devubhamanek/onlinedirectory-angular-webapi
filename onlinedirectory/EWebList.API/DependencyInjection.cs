using EWebList.Business.Abstract;
using EWebList.Business.Concrete;
using EWebList.Common;
using EWebList.DataRepository.Abstract;
using EWebList.DataRepository.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace EWebList.API
{
    public static class DependencyInjection
    {
        public static void AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserMasterRepository, UserMasterRepository>();
        }
    }
}