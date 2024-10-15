# Travel and Accommodation Booking Platform

## Table of Contents

- [Projects Structure](#projects-structure)
- [Technology Stack](#technology-stack)
- [Getting Started](#getting-started)
- [API Usage Examples](#api-usage-examples)
- [Testing](#testing)

## Projects Structure
- **TravelAccommodationBooking.Api**: Presentation Layer, providing endpoints and functionality for the platform.
- **TravelAccommodationBooking.Db**: Data access Layer for managing database interactions. This includes the use of Entity Framework Core (EF Core) for working on Object-Relational Mapping (ORM).
- **TravelAccommodationBooking**: Business Logic Layer, handles core business logic.
- **TravelAccommodationBooking.Tests**: Contains unit tests to ensure the reliability and correctness of the platform.

## Frameworks
* xUnit - for testing

## Technology Stack

- **.NET 6**: Target framework for building web APIs.
- **Entity Framework Core**: ORM for data access.
- **AutoMapper**: Object mapping solution.
- **BCrypt**: Cryptography provider for hashing passwords.
- **FluentValidation**: Framework for building strong validation rules.
- **JWT Bearer Authentication**: Implementation for secure user authentication.
- **Serilog**: Logging mechanism.
- **Swashbuckle**: Swagger tool for API documentation.


## Getting Started
### Dependencies(Prerequisites)
- [.NET](https://dotnet.microsoft.com/download)

### Setup and Running

1. Clone the repository:
    ```bash
    git clone `[Repository URL](https://github.com/Reema-Khaseeb/Travel-Accommodation-Booking.git)
    ```

2. Navigate to the project's root directory:
    ```bash
    cd TravelAccommodationBooking
    ```

3. Restore dependencies and build the project:
    ```bash
    dotnet restore
    dotnet build
    ```

4. Launch the API project:<br>
    ```bash
    dotnet run --project TravelAccommodationBooking.API
    ```


## API Usage Examples
Detailed examples of API usage are provided in the Swagger UI once the application is running:<br>
```bash
http://localhost:7119/swagger
```

## Testing
To run the unit tests, use the following command: <br>
```bash
dotnet test TravelAccommodationBooking.Tests
```
