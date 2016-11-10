Feature: HyveeSearch
	In order to find coffee products
	As a person that's new to using Selenium
	I want to find different Hy-Vee internal sites

@mytag
Scenario: Display list of Hy-Vee internal sites
	Given I want to find different Hy-Vee sites
	When I click on the sites button on the Hy-Vee main page
	Then four different sites will be displayed to me
