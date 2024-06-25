using Microsoft.Extensions.DependencyInjection;
using LiteDB;
using Landmark.Services;
using Landmark.VeiwModels;

namespace Landmark
{
    public static class Dependency
    {
        private static readonly ServiceProvider _provider;

        static Dependency()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<StartPageViewModel>();
            services.AddTransient<TestListPageViewModel>();
            services.AddTransient<CreateTestPageViewModel>();
            services.AddTransient<TestPageViewModel>();
            services.AddTransient<TestDialogWindowViewModel>();
            services.AddTransient<StatisticsPageViewModel>();

            services.AddSingleton<PageNavigationService>();
            services.AddSingleton<DialogService>();
            services.AddSingleton<CustomFileService>();
            services.AddSingleton<TestService>();
            services.AddSingleton(new LiteDatabase(@"MyData.db"));
            services.AddTransient<Repository>();
            services.AddSingleton<TestState>();

            _provider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => _provider.GetRequiredService<T>();
    }
}
