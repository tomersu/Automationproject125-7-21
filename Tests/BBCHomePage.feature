Feature: BBCHomePage
	As a user
	I want to view the BBC home page
	So that I can see the latest news

@BBCHomePage
Scenario: Verify BBC home page
	Given I navigate to BBC home page	
	When I click on Home menu
	Then I see home page loads