# CodeFirstBasic

## Overview
This project showcases a basic implementation of the Code First approach using Entity Framework Core for Patika dev Homework. It includes:

Movies: Manage a collection of movies with details such as title, genre, and release year.

Games: Manage a collection of games with details such as name, platform, and rating.

The application is designed to demonstrate how to define entities, configure the database context, and perform CRUD operations using a Web API interface.

## Technologies Used
C#: Primary programming language.
.NET Core: Framework for building the web application.
Entity Framework Core: ORM for database interactions.
Microsoft SQL Server: Database provider (can be configured as needed).
Swagger/OpenAPI: For API documentation and testing.
## Entities
### Movie
Represents a movie with the following properties:

Id: Unique identifier for the movie.
Title: The title of the movie. (Required)
Genre: The genre of the movie. (Required, Max Length: 100)
ReleaseYear: The year the movie was released.

### Game
Represents a game with the following properties:

Id: Unique identifier for the game.
Name: The name of the game. (Required, Max Length: 100)
Platform: The platform on which the game is available (e.g., PC, Xbox, PlayStation). (Required, Max Length: 50)
Rating: The rating of the game. (Decimal with precision 8,2)

## Key Points:

DbContext Registration: Registers PatikaFirstDbContext with SQL Server as the database provider. Configures retry policies and query tracking behavior.
Controllers: Adds support for controllers in the application.
Swagger/OpenAPI: Configures Swagger for API documentation and testing in the development environment.
Middleware: Sets up HTTPS redirection, authorization, and endpoint mapping.
## Installation and Setup
.NET Core SDK: Ensure that you have .NET Core SDK installed. You can download it from here.
SQL Server: Ensure you have access to a SQL Server instance or use another supported database provider.
