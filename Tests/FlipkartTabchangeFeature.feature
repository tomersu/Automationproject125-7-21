Feature: FlipkartTabchangeFeature
	As a user
	I want to check the search item is clickable
	So that always new tabs gets open on item click

@FlipkartTab
Scenario: Checking the search item clickable
	Given I navigate to Flipkart homepage
	And I type item saree
	When 1st item gets clicked
	Then the result should be shown in next tab