using GherkinSpec.ComplexExample.Tests.Configuration;
using GherkinSpec.TestModel;
using System;
using System.Threading.Tasks;

namespace GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorOperationSteps
    {
        private readonly Context context;
        private readonly Settings settings;

        public CalculatorOperationSteps(Context context, Settings settings)
        {
            this.context = context;
            this.settings = settings;
        }

        [When(@"I add (\d+) more")]
        [Given(@"I have added (\d+) more")]
        public async Task WhenIAddSomeMore(int number)
        {
            // Real world might be making an API call here, or performing a database call or disk write.
            await Task.Delay(
                TimeSpan.FromSeconds(0.5));

            context.Calculator.Add(number);

            // Can use strongly-typed setting values by accessing them like this
            var necessarySetting = settings.ExampleSetting;
        }

        [When(@"I subtract (\d+)")]
        [When(@"I subtract (\d+) more")]
        [Given(@"I have subtracted (\d+)")]
        public async Task WhenISubtract(int number)
        {
            // Real world might be making an API call here, or performing a database call or disk write.
            await Task.Delay(
                TimeSpan.FromSeconds(0.5));

            context.Calculator.Subtract(number);
        }

        // Real world would have more methods here to perform other actions
        // ... or might stay simple by having more action classes such as CalculatorSubtractionSteps, etc.
    }
}
