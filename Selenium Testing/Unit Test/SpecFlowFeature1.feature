
Feature: EventSearch
	In order to find an event to participate in
	As a potential event delegate
	I want to be able to search for an event

@mytag
Scenario: Event Search Criteria should be displayed
	Given I want to search for an event by region
	When I select to choose a region
	Then a list of possible regions is presented
	And the list should contain "All", "North", "South", and "London"
	And "All" should be the default value
