Feature: OrangeHrmDropdown
	As a user
	I want to Login in HrmOrange
	So that I can search the selected job Title vacancy

@HrmOrangeDropdown
Scenario: Search the selected vacancy by using drop down
	Given I want to navigate to HrmOrange
	And I enter username and password
	And I click on Login button
	And I click on Pim tab
	And I select Full-Time Contract in Empolyment Status
	And  I select account assistant in job title
	When I click on Search button
	Then the result of Job Title and Employment Status should be verified