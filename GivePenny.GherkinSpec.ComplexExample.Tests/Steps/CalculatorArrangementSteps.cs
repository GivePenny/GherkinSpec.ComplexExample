using GivePenny.GherkinSpec.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GivePenny.GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class CalculatorArrangementSteps
    {
        private readonly Context context;

        public CalculatorArrangementSteps(Context context)
        {
            this.context = context;
        }

        [Given(@"I have (\d+) apples")]
        public void GivenIHaveSomeApples(int number)
        {
            context.Calculator.Store(number);
        }

        // Real world would have more methods here to build a collection of re-usable setup steps
    }
}
