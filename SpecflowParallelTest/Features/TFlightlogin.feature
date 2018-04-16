Feature: TFlightlogin
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: connect to sounds air website
	Given I connect to Sounds air website
	Then click login button
	Then click Sign Up Here
	Then navigate the user to singup window
	And Enter firstname & Enter lastname
	    |firstname | lastname|
	    |Asif      | SD |
	And Enter Emailaddress & Enter ContactNumber
	    | Emailaddress      | ContactNumber |
	    |asif.hyd@gmail.com | 0123456789 |
	And Enter UserName
	    |SD|
	And Enter Password & ConfirmPassword
	    |!@#$%1q | !@#$%1q |
	And Click Signup

	     
