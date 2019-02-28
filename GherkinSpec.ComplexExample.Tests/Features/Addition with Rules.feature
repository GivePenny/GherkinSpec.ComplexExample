﻿Feature: Addition with Rules
	In order to demonstrate Rules
	As a software engineer
	I want to write some pointlessly verbose tests

Rule: Starting with 5 apples should always add up correctly

	Background:
		Given I have 5 apples

	Scenario: Add six more apples
		When I add 6 more
		Then the result should be 11

	Scenario: Add seven more apples
		When I add 7 more
		Then the result should be 12

Rule: Starting with 4 apples should always add up correctly

	Background:
		Given I have 4 apples

	Example: Add six more apples but using the Example keyword instead of Scenario
		When I add 6 more
		Then the result should be 10

	Example: Add seven more apples
		When I add 7 more
		Then the result should be 11
