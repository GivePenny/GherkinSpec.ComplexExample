using GivePenny.GherkinSpec.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorResultSteps
    {
        private readonly Context context;

        public CalculatorResultSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"the result should be (\d+)")]
        public async Task ThenTheResultShouldBe(int expectedResult)
        {
            // Real world might be making an API call here, or performing a database read. Could be waiting for a message to be received.
            await Task.Delay(
                TimeSpan.FromSeconds(0.5));

            Assert.AreEqual(
                expectedResult,
                context.Calculator.Result);
        }

        // Real world might have more assertion steps here, perhaps checking for complex numbers, fractions, etc.
    }
}
