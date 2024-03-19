using DataProvider.Abstractions;
using DataProvider.Engine;

namespace AcademyWebApi.Extensions
{
    public static class ConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyGroup(this IServiceCollection services)
        {
            services.AddSingleton<IStudentRepository, StudentRepository>();
            services.AddSingleton<ICourseRepository, CourseRepository>();
            services.AddSingleton<ITeacherRepository, ITeacherRepository>();

            return services;
        }
    }
}
