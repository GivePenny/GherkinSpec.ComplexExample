using GivePenny.GherkinSpec.ComplexExample.Tests.Steps;
using GivePenny.GherkinSpec.TestModel;
using Microsoft.Extensions.DependencyInjection;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Configuration
{
    [Steps]
    public static class Dependencies
    {
        [BeforeRun]
        public static void Setup(TestRunContext testRunContext)
        {
            var services = new ServiceCollection();

            testRunContext.ServiceProvider = services
                .AddScoped<Context>()
                .AddScoped<CalculatorArrangementSteps>()
                .AddScoped<CalculatorActionSteps>()
                .AddScoped<CalculatorAssertionSteps>()
                .BuildServiceProvider();
        }

        [AfterRun]
        public static void Teardown(TestRunContext testRunContext)
        {
            var typedProvider = (ServiceProvider)testRunContext.ServiceProvider;

            typedProvider.Dispose();
        }
    }
}
