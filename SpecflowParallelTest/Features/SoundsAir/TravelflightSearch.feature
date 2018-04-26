Feature: TravelflightSearch
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Travelflightsearch
	Given I connect to SA SoundsAir website
	#And   Select radio button for Round trip
	And   choose from City
	And   Choose travelling city
	And   choose travelling date
	And   choose returning date
	And   number of Adults travelling
	And   number of childrens travelling
	And   number of Infants travelling
	And   select search to find flights
