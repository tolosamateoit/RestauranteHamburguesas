## English
This is the English version of the README. Para ver la version en español: [En español](README.es.MD)

# **__RestauranteHamburguesas (WORKING ON IT)__**


Summary

This is a project where the user can order a hamburger for delivery, specifying their personal data, ingredients, and delivery address. The aim is to develop the project so that the application can be used by a real business, applying clean code techniques, and with the possibility of adding features according to the restaurant's needs. The project has been created using ASP.NET 7 MVC, ENTITY FRAMEWORK, SQL SERVER.

Features:

The distance is validated and the location is displayed using the Google MAPS API.
If all the data is valid, the customer is informed of their approximate waiting time and cost.
The order is saved using Entity Framework in a database.

Validation is performed on the fields. The marked location is the location of the fictitious restaurant.
The order cannot be confirmed until all the fields are completed correctly. And it does not allow 
empty fields.


![image](https://user-images.githubusercontent.com/68035536/231653950-ee40ef89-07fb-404e-bdb5-6cb4b5ff6314.png)


When the address is valid, it is marked on the map, and the writing is locked, which can be enabled again with the Modify button.

![image](https://user-images.githubusercontent.com/68035536/231652468-998b5c32-6427-47f8-b470-706d573f6c74.png)


Error cases:

Case 1: Invalid or not found address:

![image](https://user-images.githubusercontent.com/68035536/231652765-6f9fe032-4954-4c7e-bdd4-8ddad5b60eb3.png)

Response: The address must be written again.

Case 2: Delivery address is outside the delivery range (10km radius from the restaurant)

![image](https://user-images.githubusercontent.com/68035536/231653773-043f98f0-71c4-4c8d-bb01-76e2d4c5364e.png)


Response: The address must be written again.

**Success case:**
All fields were validated correctly.
The delivery distance is less than 10km and the location exists.
The distance price is calculated as a fixed price of 100 + 0.01 per meter.

![image](https://user-images.githubusercontent.com/68035536/231654113-78c13393-86fc-4e06-a371-f5441a52eb49.png)

Response: The order can be confirmed.


![image](https://user-images.githubusercontent.com/68035536/231655324-9d4244be-0c83-464f-a3d6-dd8bfe33ffec.png)




Finally, it is saved in the database.

![image](https://user-images.githubusercontent.com/68035536/231655562-a1f9c531-2f70-4610-a387-43ee85151142.png)











WORKING ON:

Calculating the price of the order based on ingredients and delivery.
Calculating the estimated time of delivery based on ingredients and delivery.
Sorting the list of orders as required.

FUTURE FUNCTIONALITIES:
Implementing an "online payment".
