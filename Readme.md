# Hire Personality

## Scope
Project is based on matching an individuals personality to a job that could fit their interests. This is the back half of the program, it holds the necessary framework to pass information regarding personalities, jobs, and authorization to and from a SQL database. 

## Initializing the Project 
Once cloned, a migration will need to be run to create the data tables. You can accomplish this by following these steps:
1. Find the package manager console in visual studio community
2. type 'add-migrations' without the '' and press enter.
3. type 'update-database' without the '' and press enter.
4. wait for the command to complete and your datatables should be functional.


## Architecture
This project uses N-Tier architecture to encapsulate structural concerns of the application into assemblies per concern.
Projects with the ".DataContract" suffix contain only DataContracts and Interfaces. The corresponding similarly named project implements the contract project.

#### Presentation Layer
Composes all layers together. You will need a Dependency Injection framework.
1) Project.API
    1) Contains HTTP logic and routing
    2) Maps API data contracts to and from business data contracts and calls business layer Managers 
  
2) Project.API.DataContract
    1) Contains request and response data contracts suffixed with "Request/Response"
  
3) Project.API.Tests

#### Business Layer
The largest and most volatile layer. Has no knowledge of the Presentation Layer, but depends on Resource and Utility Layers.
1) Project.Business.DataContract
    1) Contains Business objects suffixed with "DTO" (Domain Transfer Objects)
    2) Contains Interfaces for Managers & Engines to be suffixed with "Manager" or "Engine".
2) Project.Business
    1) Contains Business "Managers" and "Engines" that encapsulate core business use cases and their variants
        a) Managers can call Engines and Resource Access layer
        b) Engines can call Resource Access layer
        c) Managers shouldn't call other Managers
    2) Has no knowledge of API data contracts or logic (no reference to Entity Framework)
    3) Maps Business DTOs to RAOs
3) Project.Business.Tests

#### Resource Access Layer
Depends only on a connection to the SIS database and Entity Framework.
1) Project.Database.DataContract
    1) Contains Resource Access objects suffixed with "RAO" (Resource Access Objects)
    2) Contains Interfaces for Repositories.
2) Project.Database
    1) This layer should be kept highly encapsulated and has no knowledge of Business data contracts or logic. RAOs are passed in through Repository method calls(or other pattern as needed), but no contracts are known.
    2) This layer should map RAOs to entities. 
    3) This layer will contain entities that are mapped to the DB and are suffixed by with the word "Entity". For instance, UserEntity.
    4) This layer will contain Repositories for CRUD + List operations. For instance, NoteRepository would have a method called Create that would convert RAOs to Entities. Then, Add them to the DbContext and call SaveChanges().

3) Project.Database.Tests

