# Onion Architecture Demo
### The **rascal** agreed architecture
The design pattern at rascal loosely follows Jeffrey Palermo's Onion Architecture. There is also a helpful video explanation on YouTube and a breakdown of the Infrastructure, Application and Domain layers seen on StackOverflow, which are recommended.

For a practical example, take a look at the open source architecture up on the rascal systems github at https://github.com/rascal-systems/OnionArchitectureDemo

### Explanation
#### Core Layer
This is a layer for helper classes, common code and other non-domain functionality. XML parser, CSV reader, file writing, etc.

#### Domain Layer
Responsible for the solution's Value Objects, Domain Models, and Domain Services. Also exposes interfaces for the Unit of Work pattern so that a Data Source may implement the interfaces higher up.

We have agreed to add logic to our domain models when it makes sense to do so rather than using the anaemic domain model. Services may be added into the domain layer, however these services should not look into other DLL's to do any logic, they should be contained within the domain models themselves. Anything that needs to look into another layer should be inside the domain services layer

#### Domain Services Layer
Domain services make it easier to provide separation of concerns between your domain entities themselves and the logic of how to interact with them, meaning that it is more clean when importing the domain layers DLL into an existing project.

In the rascal example at https://github.com/rascal-systems/OnionArchitectureDemo, the domain service layer only contains interfaces, this is because the domain services naturally transforms storage entities (such as EF models) into the domain entities, and that would likely be an infrastructure layer responsibility, that implements the interfaces outlined in the domain services layer.

DI makes it possible to quickly switch out domain service implementations IE: easily switching from a database to static data 

#### Application Services Layer
This layer provides behaviour that is specific to the application but is not a domain concern. In a URL shortener application, this layer would orchestrate receiving an incoming URL from the UI and passing it to the Domain layer for validation, as well as potentially saving the new domain object (if valid) before returning a success result to the UI.

Examples could also include: checking for cached data before serving a response to a user, sending push notifications to a phone, or checking whether a user's account is locked because of too many invalid login attempts. None of these are specifically tied to our business domain, but are required for our app.

The application services layer may be used for transforming domain models into application models (the M in MVC), however any view models should be made by the presentation layer itself. If a ViewModel contains multiple models, the factory used for generating a view model may call many application services.

#### Infrastructure Layer
Infrastructure refers to anything external to the application itself.

The web UI, the database, a web API the application consumes for up-to-date Issue prices, etc.



