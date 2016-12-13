Feature: Documentation
	In order to know how the PERS works
	As an end user
	I want to be read the user manual

@documentation
Scenario: Read user manual
	Given the side menu page is displayed
	When I click Documentation
	Then the user manual should be displayed
