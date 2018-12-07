using GivePenny.GherkinSpec.TestModel;
using System;
using System.Threading.Tasks;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorStorageSteps
    {
        private readonly Context context;

        public CalculatorStorageSteps(Context context)
        {
            this.context = context;
        }

        [Given(@"I have (\d+) apples")]
        public async Task GivenIHaveSomeApples(int number)
        {
            // Real world might be making an API call here, or performing a database call or disk write, to set up initial state for the test.
            await Task.Delay(
                TimeSpan.FromSeconds(0.5));

            context.Calculator.Store(number);
        }

        // Real world would have more methods here to build a collection of re-usable setup steps
    }
}
