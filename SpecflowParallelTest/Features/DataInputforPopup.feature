Feature: DataInputforPopup
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Data Input for popup
	Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then User clicks on the link
	Then  Pop-up window displayed
	And  Select Title
	And  Enter Initial
	And enter First Name
	And  enter MiddleName
	And Enter Last Name
	And select Gender
	And Select Country
	And close the popupwindow
