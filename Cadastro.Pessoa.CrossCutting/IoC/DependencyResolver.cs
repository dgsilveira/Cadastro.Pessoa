
using Microsoft.Extensions.DependencyInjection;

namespace Cadastro.Pessoa.CrossCutting.IoC
{
    public static class DependencyResolver
    {
        public static void AddDependencyResolver(this IServiceCollection services)
        {
            RegisterApplications(services);
            RegisterRepositories(services);
        }

        private static void RegisterApplications(IServiceCollection services)
        {
        }

        private static void RegisterRepositories(IServiceCollection services)
        {
        }
    }
}
