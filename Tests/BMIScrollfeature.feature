Feature: BMIScrollfeature
	AS a user
	I want to scroll down to the end of the page
	So that I can see all footers list

@BMIFootersScroll
Scenario: Scroll down to BMI Footer
	Given I navigate to BMI group website
	When I scroll down to the footer	
	Then I can see the footer list