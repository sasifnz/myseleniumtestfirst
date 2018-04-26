Feature: SubMenuOption
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Test sub Menu Options
Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then click on Automation Tools and display sub menu option
	Then check the dropdown contains Selenium and BDD
	