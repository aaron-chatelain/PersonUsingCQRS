
# PersonUsingCQRS

ASP.NET Core Web API implementing the CQRS pattern for a Person object
Target Framework: .Net 8.0. 

## How to run the project

Run the project either in VSCode or Visual Studio. Queries and Commands can be executred from the Swagger UI.

* Dates for BirthDate and DeathDate use ISO 8601
* Gender has two valid values ( 1 = Male, 2 = Female)

## Assumptions

* RecordBirth assumes the person already exists

## Challenges

* New guid generation is difficult without proper architecture and a good design. 
* Guids are hard to read and should not be necessary for a user to interact with. Better person identifiers are needed
* Project has many outstanding items like proper exception handling when the id provided to GetPerson doesn't exist

## Future improvements if given more time

* Add Exception Handling including RecordBirth and GetPerson if id provided does not exist 
* Better design and infrustructure for guid generation and a meaningful person identifiers
* Implement Domain Model
* Improve logging 
* Versioning for Person
* Unit Testing for command/query handlers
