Feature: APItests
	Crud operations and empty end point for TypiCode

@todo
Scenario: I should be able to create a post 
	Given I have an endpoint to create post
    When I send request to create a post with(<Id>, <Title>,<Body>,<UserId>)
	Then the response status is 200 OK and the response body should contain the Id
@todo
Scenario: I should be able to update a post 
	Given I have an existing post
	When I send request to replace a post
	Then the response status is 200 or 204 OK and the post should be updated successfully
@todo
Scenario: I should be able to get a post 
	Given I have an existing post
	When I send request to get a post
    Then the response status is 200 OK and the response body should contain the Id
@todo
Scenario: I should be able to delete a post 
	Given I have an existing post
	When I send request to delete a post
	Then the response status is 204 No Content
@todo
Scenario: I should be able to get no result 
	Given I have a post that does not exist
	When I send request to get IdontExist
	Then the response status is 404 Not found


	Examples: 
	| Id  | Title | Body | UserId |
	| 101 | Foo   | bar  | 1      |





	