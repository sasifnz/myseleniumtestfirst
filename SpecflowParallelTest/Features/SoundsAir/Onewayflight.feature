Feature: Onewayflight
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Onewayflight
	Given I connect to SA SoundsAir website
	And   Select radiobutton oneway
	And   choose from City
	And   Choose travelling city
	And   choose travelling date
	And   number of Adults travelling
	And   select search to find flights
	
