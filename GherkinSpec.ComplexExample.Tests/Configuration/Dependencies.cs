﻿using GherkinSpec.ComplexExample.Tests.Steps;
using GherkinSpec.TestModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GherkinSpec.ComplexExample.Tests.Configuration
{
    [Steps]
    public static class Dependencies
    {
        [BeforeRun]
        public static void Setup(TestRunContext testRunContext)
        {
            var services = new ServiceCollection();
            testRunContext.ServiceProvider = services
                .AddSettings()
                .AddScoped<Context>()
                .AddScoped<CalculatorStorageSteps>()
                .AddScoped<CalculatorOperationSteps>()
                .AddScoped<CalculatorResultSteps>()
                .BuildServiceProvider();
        }

        [AfterRun]
        public static void Teardown(TestRunContext testRunContext)
        {
            var typedProvider = (ServiceProvider)testRunContext.ServiceProvider;

            typedProvider.Dispose();
        }

        private static IServiceCollection AddSettings(this IServiceCollection services)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .AddJsonFile("Configuration/appsettings.json", optional: false);

            var configuration = configurationBuilder.Build();
            var settings = configuration.Get<Settings>();

            return services.AddSingleton(settings);
        }
    }
}
