Feature: TravelDestination
	As a QA Software Engineer
	I tested of looking for travel destination

Scenario: LookingForATravelDestination
	* I navigate to the Expedia website
	* I look for a flight and accommodation from 'Brussels' to 'New York'
	* I choose dates in three months as '01/16/2020' and '01/26/2020'
	* I choose travelers as one adult and one child is '3' years old
	* I click Search button
	* The result page contains travel option for the chosen destination
