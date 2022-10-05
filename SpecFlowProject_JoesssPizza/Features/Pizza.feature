Feature: Pizza
In order to test search functionality on 
JoessPizza Website
As a developer
I want to ensure functionality is working end to end
@FirstCase
Scenario: After Login user should be navigated to the Pizza Page
Given I have navigated to Joesss Pizza website
And I pressed Login with login keyword
When I press the Login button
Then I should be navigate to Pizza page

@SecondCase
Scenario: After Register user should be navigated to the Pizza Page
Given I have navigated to Joesss Pizza website
And I pressed Register with Register keyword
When I press the Register button
Then I should be navigate to Pizza page

@ThirdCase
Scenario: Check how many Navbarlinks
Given Verify Menu Item Count

@FourthCase
Scenario: Add to Cart 
Given I have navigated to Pizza Page
When I press add to cart
Then Cart Page Opens

@FifthCase
Scenario: Placing an order of multiple pizzas
Given I have navigated to Pizza Page
When I press add to cart
Then Cart Page Opens
When I click Continue Shopping
Then I add another pizza to cart
When Cart page comes up click on Checkout
Then Order is confirmed

@SixthCase
Scenario: Cancel/Delete a pizza
Given I have navigated to Pizza Page
When I press add to cart
Then Cart Page Opens
When I click on delete
Then Pizza should be removed from cart