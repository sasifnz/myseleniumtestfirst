Feature: SearchFlightbyEnteringvalues
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search Flights on Sounds Air by Entering Values
	Given I connect to SA SoundsAir website
	And   Select radio button for Round trip
	And   choose from City
	And   Choose travelling city
	And   choose travelling date
	And   choose returning date
	And  Enter number of Adult
	And  Enter number of child and number of Infants
	And  click Search for flights
	And   select search to find flights

	