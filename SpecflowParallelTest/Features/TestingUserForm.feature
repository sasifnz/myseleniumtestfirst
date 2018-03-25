Feature: TestingUserForm
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Test menu option on user form
	Given I navigate to application
	And I enter username
	Then I enter password
	Then I click login button
	Then I should see user logged in to the application
	Then I should see menu option 'LOGOUT'
	And  I should see menu option 'AUTOMATION TOOLS'
	And I should see menu option 'USER FORM'
	And I should see menu option 'DRAG AND DROP'
	And I should see the text 'Execute Automation Selenium Test Site'
	And I should see the text header 'This is a demo website, which act as a mock site for trying out different automation tools'