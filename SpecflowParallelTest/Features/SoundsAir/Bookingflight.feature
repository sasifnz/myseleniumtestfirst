Feature: Bookingflight
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Bookingflight
	Given I connect to SA SoundsAir website
	And   choose from City
	And   Choose travelling city
	And   choose travelling date
	And   choose returning date
	And   number of Adults travelling
	And   number of childrens travelling
	And   number of Infants travelling
	And   select search to find flights
	And   Select date
	And   Select departure flight
	And   Select Return flight
	And   selectproceedbutton
	And   Adult1 details
	And   Enter Adult2 detaiils
	And   Childrens details
	And   Infants details
	And   Enter Customer Details
	And   Select Continue
	And   Confrim and navigate to Payment page