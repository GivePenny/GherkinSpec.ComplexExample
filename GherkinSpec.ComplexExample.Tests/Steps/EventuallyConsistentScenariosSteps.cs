using GherkinSpec.TestModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GherkinSpec.ComplexExample.Tests.Steps
{
    [Steps]
    public class EventuallyConsistentScenariosSteps
    {
        private int givenCalls;
        private int whenCalls;

        [Given("data has been set up")]
        public void GivenDataHasBeenSetUp()
            => givenCalls++;

        [When("an action is performed")]
        public void WhenAnActionIsPerformed()
            => whenCalls++;

        [Then("the data setup step should only ever be called once")]
        public void ThenTheDataSetupStepShouldOnlyEverBeCalledOnce()
            => Assert.AreEqual(1, givenCalls);

        [Then("the action performed step should be called three times")]
        public void ThenTheActionPerformedStepShouldBeCalledThreeTimes()
            => Assert.AreEqual(3, whenCalls);

        [Then("the action performed step should be called (\\d) times")]
        public void ThenTheActionPerformedStepShouldBeCalledCountTimes(int count)
            => Assert.AreEqual(count, whenCalls);
    }
}
