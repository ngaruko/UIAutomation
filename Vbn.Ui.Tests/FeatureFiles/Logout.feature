Feature: Logout
	In order to log out
	As a user
	I want to click the logout button


Scenario: Log out
	Given I am logged in
	And I click on my profile
	When I press logout
	Then I should be logged out
