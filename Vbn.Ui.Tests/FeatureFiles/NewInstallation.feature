Feature: NewInstallation
	In order to add a new new gateway
	As an admin user
	I want to be on the Install Page


Scenario:Gateway Serial Number Empty
	Given I an on the Install Page
	And I don't enter any serial number
	When I press Next
	Then the VBN should display a "No Gateway Serial Number" error message

Scenario:Wrong Gateway Serial Number 
	Given I an on the Install Page
	And I enter a wrong Gateway serial number
	When I press Next
	Then the VBN should display a "wrong Gateway Serial Number" error message

Scenario:Pendant Serial Number Empty
	Given I an on the Install Page
	And I enter a valid Gateway Number
	But I don't enter any pendant serial number
	When I press Next
	Then the VBN should display a "No Pendant Serial Number" error message

Scenario:Wrong Pendant Serial Number 
	Given I an on the Install Page
	And I enter a valid Gateway Number
	But I enter a wrong  pendant serial number
	When I press Next
	Then the VBN should display a "wrong Pendant Serial Number" error message


Scenario:Right Gateway and Pendant Serial Numbers 
	Given I an on the Install Page
	And I enter a valid Gateway Number
	And I enter a valid  pendant serial number
	When I press Next
	Then the Gateway should be added to the VBN

	
Scenario:Location auto-suggestion