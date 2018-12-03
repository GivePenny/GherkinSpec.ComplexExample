using GivePenny.GherkinSpec.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorAssertionSteps
    {
        private readonly Context context;

        public CalculatorAssertionSteps(Context context)
        {
            this.context = context;
        }

        [Then(@"the result should be (\d+)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(
                expectedResult,
                context.Calculator.Result);
        }

        // Real world might have more assertion steps here, perhaps checking for complex numbers, fractions, etc.
    }
}
