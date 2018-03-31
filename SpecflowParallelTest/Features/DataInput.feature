Feature: DataInput
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: DatInput
		Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then select title
	And enter Initial
	And enter First Name
	And enter Middle Name
	And select Gender
	And select Language
	And click Save button