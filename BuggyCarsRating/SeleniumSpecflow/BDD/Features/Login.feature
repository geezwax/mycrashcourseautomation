Feature: Login

@login
Scenario: Successful login
	Given that user has valid login
	Then successful login

Scenario: Failed login
	Given that user has invalid login
	Then failed login

Scenario: Logout
	Given that user has valid login
	And that user has clicked Logout
	Then successful logout
