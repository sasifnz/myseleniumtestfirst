Feature: AlertWindow
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Alertwindow
Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	And I click Generate button
	Then open the alert window
	Then Dismiss the alert window
