using GivePenny.GherkinSpec.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorActionSteps
    {
        private readonly Context context;

        public CalculatorActionSteps(Context context)
        {
            this.context = context;
        }

        [When(@"I add (\d+) more")]
        public void WhenIAddSomeMore(int number)
        {
            context.Calculator.Add(number);
        }

        // Real world would have more methods here to perform other actions
        // ... or might stay simple by having more action classes such as CalculatorSubtractionSteps, etc.
    }
}
