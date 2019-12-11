Feature: Navigation
	In order to interact with website
	As User
	I would like to use nav menu

@nav
Scenario Outline: Index page link
	Given I am on the '<pageName>' page
	When I click '<pageLink>' page link
	Then '<Page>' page should be open

	Examples:
	| pageName | pageLink | Page     |
	| About    | Home     | Home     |
	| Home     | About    | About    |
	| Home     | Messages | Messages |
