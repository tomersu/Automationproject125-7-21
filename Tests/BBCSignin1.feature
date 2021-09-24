Feature: BBCSignin1
	As a user
	I want to signin for BBC
	So that I am able to view my activities

@BBCSignin1
Scenario: Log in functionality
	Given I navigate to BBC
	When I click Signin
	And I login to BBC
	Then I am logged in successfully