
# Hotel API

A simple REST API built with ASP.NET Core to serve hotel-related data. This API provides endpoints for retrieving a list of hotels or details about a specific hotel by ID.

---

## Features
- Fetch a list of all hotels.
- Retrieve details of a specific hotel by ID.
- Handles errors gracefully (e.g., missing hotels, invalid IDs, or server errors).
- Designed to be extendable for future features (e.g., adding a database).

---

## Requirements
- .NET SDK (6.0 or later)
- JetBrains Rider (or any other IDE supporting .NET development)
- `hotels.json` file located in the `Data` folder of the project.

---

## Running the Application Locally

### 1. Clone the Repository
### 2. Open the Project
Open the project in **JetBrains Rider**.

### 3. Configure the Launch Settings
Ensure you have the `.NET Launch Settings Profile` selected:
- `sunway-travel-dev-test: http` or `https` (depending on your preference).

### 4. Run the Application
Run the project using Rider's **Run** button.  
The application will start and bind to the specified ports.

---

## API Endpoints

### 1. `GET /api/hotels`
**Description**: Fetches a list of all hotels.

### 2. `GET /api/hotels/{id}`
**Description**: Fetches details of a single hotel by its ID.
