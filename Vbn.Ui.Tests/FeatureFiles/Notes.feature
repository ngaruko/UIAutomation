Feature: Notes
	In order to add coomenst
	As a user
	I want to open Notes tab

@mytag
Scenario: Add comments
	Given I have oopen notes tab
	And I type something
	When I press save change
	Then the notes should be saved
