using GivePenny.GherkinSpec.TestModel;
using System;
using System.Threading.Tasks;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorOperationSteps
    {
        private readonly Context context;

        public CalculatorOperationSteps(Context context)
        {
            this.context = context;
        }

        [When(@"I add (\d+) more")]
        [Given(@"I have added (\d+) more")]
        public async Task WhenIAddSomeMore(int number)
        {
            // Real world might be making an API call here, or performing a database call or disk write.
            await Task.Delay(
                TimeSpan.FromSeconds(0.5));

            context.Calculator.Add(number);
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
