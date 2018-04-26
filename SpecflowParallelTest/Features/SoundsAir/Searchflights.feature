Feature: Searchflights
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search Flights on Sounds Air
	Given I connect to Sounds Air website
	Then Search Flights for Round trip
	And  select Departing location
	And  select Travelling to city
	And  Select Departing date 
	And  Select Return date
	And  In Return date the previous days from departing days should be disabled
	And  Select number of Adult
	And  select number of child and number of Infants
	And  click Search for flights