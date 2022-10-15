# TaxCalculator

Console Application on E-commerce:
 
Design Patterns:
Singleton: While signing up we are Creating a single instance of user. If the user does not exist, we create a new user.
Say for example if the user is not registered to the application by using singleton, we are creating the user
 
Factory Method: It is used to select the product category.
Like Electronics, Groceries, cosmetics etc.…
 
Flyweight Model:  For similar products with few changes in unique properties we are using this method.
(Let’s say color of the product will differ and rest all the properties will be same).
 
Strategy Method: This method is used to calculate prices based on the discounts of the products.
Say we have a discount range from 1-30 percent, so based on the range user should select the preferred choice to select those discounted products.
 
Decorator Method: It is used to calculate taxes for the products.
(Like local or international Product).
Say if user selected the local product its tax is 5% on the net cost if he selected international product its price vll be doubled (10% on the net cost).
 
// similarly : if product is brand new its tax is 10% on the net price. If he selected refurbished product its tax is 5% on the net price.
 
 
Data Structures:
 
ArrayList: Used for storing the users
 
Dictionary: used for storing the products from factory method
 
HashMap: can be used in flyweight model design pattern or in
 
Sorted set: This Data structure is used in displaying the products in asc order based on price.
 
Stack: used in the cart to display the items ( last
 
 
Application example:
 
Enter the username: NEW USER
 
From application we vll write a message saying this user is not registered to this E-commerce App. So we are creating a new user.
 
This vll implement the Singleton(Design Pattern-1) and for storing user we use Arraylist (data structure-1).
 
From application user vll get a bunch of unique products category like Electronics, Groceries, Home Appliances, Cosmetics etc.
 
Say if user selects Electronics, then the VAT is 15% on the net price,
If user selects cosmetics, then the VAT is 20% on the net price,
If user selects Groceries, then the VAT is 5% on the net price,
If user selects Home Appliances, then the VAT is 10% on the net price.
 
Here we are implementing Factory method (Design Pattern-2) for the above feature.
 
https://www.javatpoint.c om/factory-method-design-pattern
 
once the category is selected then user can be able to view the products on the selected category.
 
Now user is asked to select the item/product based on the discount range.
 
Say we have a range 1-30, so based on the selected range the products vll be shown to user.
 
For this we are trying to implement Strategy method (Design Pattern-3)
 
Here we are displaying the items/products in ascending order based on the Quantity.
 
For this we are implementing sorted set (Data Structure-2)
 
Now user vll select a particular item/product, here we are asking the user if he wants the local manufactured product or International/branded manufactured product.

Based on his selection we are charging the transport charges on the product.
 
Say if the product is locally manufactured then its transport charges in 5% on the net price/manufactured price.
 
If it is an international product then its transport charges is 10% / double on the net price/manufactured price.
 
Here we are trying to implement Decorator pattern (Design pattern 4)
 
Now if user selected a item/product then we provide options on the color (example) rest all properties are same/not much changes (like size, shape, manufacturer, warranty, durability)
 
For this we want to implement Flyweight Model (Design Pattern-5)
