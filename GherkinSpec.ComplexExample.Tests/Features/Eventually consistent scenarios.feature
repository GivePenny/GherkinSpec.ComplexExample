Feature: Eventually consistent scenarios

@eventuallyConsistent
Scenario: Eventually consistent scenario
	Given data has been set up
	When an action is performed
	Then the data setup step should only ever be called once
	And the action performed step should be called three times

@eventuallyConsistent
Scenario Outline: Eventually consistent scenario outline
	Given data has been set up
	When an action is performed
	Then the data setup step should only ever be called once
	And the action performed step should be called <count> times
Examples:
    | count |
    | 1     |
    | 2     |
    | 3     |
