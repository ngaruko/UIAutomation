Feature: Diagnostics
	In order to see the diagnostics
	As a logged in user
	I want to be go to Diagnoctics page

	Background: Given I am on the Diagnoctics page

@humanexecuted
Scenario: View Gateway Details

	#check details

@humanexecuted
Scenario: View Graphs
	When  I click View Graphs
	Then I should go to graphs page

Scenario: View Last 12 Hours
	When I click Last 12 Hours	
	Then the last 12 hours should be displayed

Scenario: View Last 24 Hours
	When I click Last 24 Hours	
	Then the last 24 hours should be displayed

Scenario: View Last Week
	When I click Last week
	Then last week should be displaced

Scenario: View Last Month
	When I click Last month
	Then last month should be displaced

