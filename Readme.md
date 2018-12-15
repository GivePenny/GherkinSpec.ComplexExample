# GherkinSpec.ComplexExample

## Overview

A more complicated example of tests written in Gherkin using the GivePenny GherkinSpec test adapter.  See the [GherkinSpec repository](https://github.com/GivePenny/GherkinSpec) for more information.

This example is intended to demonstrate possible features, as such it may not always show the simplest means to achieve a goal.

## Features demonstrated

* Scenarios and Scenario Outlines
* BeforeRun and AfterRun hooks
* Dependency Injection using .NET Core's standard Microsoft.Extensions.DependencyInjection extension.
* Async/await steps causing tests to run in parallel
* Configuration example using .NET Core's standard appsettings.json files.

## Notes

* It's outside the scope of this example to show adding other configuration providers such as the MIcrosoft.Extensions.Configuration.EnvironmentVariables package.  GherkinSpec is not coupled to any one configuration mechanism (or framework for that matter).
* When adding appsettings.json files, remember to set the "Copy to Output Directory" property in Visual Studio's Properties pane to "Copy if newer" otherwise the settings won't be available when the tests execute.