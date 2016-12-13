Feature: QuickSearch
	In order to find information about Gateways and persons
	As a VBN Admin user
	I want to be able to search for Gateways by serial number

@search
Scenario: Find a Gateway from complete Gateway serial number
	Given the search page is displayed
	When I enter a complete Gateway serial number in the search field
	Then the list contains only that Gateway information

@search
Scenario: Find a Gateway from start of Gateway serial number
	Given the search page is displayed
	When I enter the start of a Gateway serial number in the search field
	Then the list includes that Gateway information

@search
Scenario: Find a Gateway from end of Gateway serial number
	Given the search page is displayed
	When I enter the end of a Gateway serial number in the search field
	Then the list includes that Gateway information

@search
Scenario: Find a Gateway from middle part of Gateway serial number
	Given the search page is displayed
	When I enter the end of a Gateway serial number in the search field
	Then the list includes that Gateway information

@search
Scenario: Search for non-existant Gateway
	Given the search page is displayed
	When I enter text that does not match any Gateway
	Then the list is empty


