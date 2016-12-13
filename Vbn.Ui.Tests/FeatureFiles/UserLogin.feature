Feature: UserLogin
	In order to control access to the VBN Admin Portal UI
	As a VBN  user
	I want to be able to login to the website


	
@login
Scenario: Login with the correct password
	Given I have browsed to the VBN Admin Portal
	And I have entered my user name
	When I enter a good password
	Then the VBN should display the Vigil Admin Portal

@login
Scenario: Attempt to login with wrong username
	Given I have browsed to the VBN Admin Portal
	And I have entered an invalid user name
	When I enter any password
	Then the VBN should reject the username

@login
Scenario: Attempt to login with wrong password
	Given I have browsed to the VBN Admin Portal
	And I have entered my user name
	When I enter a bad password
	Then the VBN should reject the password

	@login
Scenario: Login with the blank password
	Given I have browsed to the VBN Admin Portal
	And I have not entered any user name
	When I click login button
	Then the error message "User name required" is displayed


	@login
Scenario: Attempt to login with blank username
	Given I have browsed to the VBN Admin Portal
	And I have not entered any password
	When I click login button
	Then the error message "Password required" is displaye
