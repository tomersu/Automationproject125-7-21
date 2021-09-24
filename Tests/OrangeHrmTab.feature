Feature: OrangeHrmTab
	As a user
    I want to click on Forgot password
    So that I can see on clicking youtube icon youtube opens on next tab
	@OrangeHrmTabchange
	Scenario: To check Tab change
	
	Given I navigate to the OrangeHrmdemo homepage
	And I click on forgot password
	When I Click on youtube icon
	Then it opens a new tab for youtube
	And I come back to my Previous homepage tab.