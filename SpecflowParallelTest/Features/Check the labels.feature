﻿Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Test labels on User Form
	Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then check the label Title is displayed