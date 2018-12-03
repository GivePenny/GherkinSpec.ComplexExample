Feature: Add two numbers
	In order to count how many apples I've collected
	As an apple-hoarder
	I want to add two numbers together

Scenario: Add two numbers together
	Given I have 5 apples
	When I add 6 more
	Then the result should be 11

Scenario: Add two numbers together again
	Given I have 6 apples
	When I add 7 more
	Then the result should be 13
