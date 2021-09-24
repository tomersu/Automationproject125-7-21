Feature: BBCheaderLinks
	As a user
	I want to click on header links
	So that I can view the relevant pages

@headers
Scenario Outline: Navigate to header links
	Given I navigate to BBC	
	When I click <header> Links
	Then I view <header> link pages

	Examples: 
	| header  |
	| Home    |
	| News    |
	| Sport   |
	| Weather |