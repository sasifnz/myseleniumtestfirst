Feature: Login
	Check if login functionality works


@mytag
Scenario: Login user as Administrator
	Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then I should see user logged in to the application


	Scenario: Negative test login user as non-admin user
	     Given I navigate to website
		 And I enter username
		 Then I enter password
		 Then I click login button
		# Then I should see validation message

		      
 

