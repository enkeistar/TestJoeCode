Feature: HyveeSearch
	In order to find coffee products
	As a HyVee shopper
	I want to be shown a list of coffee products sold at HyVee

@mytag
Scenario: Search for coffee
	Given I want to find coffee products sold by HyVee
	When I type in "coffee" to the search bar
	And click search
	Then various coffee products will be presented to me
