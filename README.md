# IT-Workz Project
This project is a collaboration between Fontys ICT, IT-Workz and Breens network to create a new version of the PARS application. PARS is a student registration system used by Dutch highschools. The reason for wanting a new version of PARS is that they overdeveloped the current version specifically for one of their clients. 
They now want a version of PARS that is usable for different highschools with the ability to configure settings per school. The PARS application should meet the set requirements and is fully available to the end user as a cloud application. For this, a good architecture must be set up, which is well secured.
The application should have 2 roles available, the first one being a teacher role. The teacher should be able to keep track of students attendance with the PARS application. The second role being an administrator. The administrator should be able to configure the school's settings to fit their needs.

## Table Of contents
* IT-Workz Project
* Evaluation and future
* Back-end 
* How to use the project	
* UserValidation Service
* Configuration Service
* UserManagement Service
* ScheduleManagement Service
* API Gateway
* Installation of the project	
* Front-end		
* Installation of the project
* Useful Sources
* Dependencies
* Documentation	

# Evaluation and future
At the moment of writing, the backend does not function the way it was intended.
The UserManagement and ScheduleManagement services are not yet functional. One of the reasons being that information needed for these services haven't been deliverd to the project group.
PARS needs all backend services to function, since it wasn't possible to make all of them work, PARS isn't fucntional.
The Microsoft Authentication is working properly and is implemented in the frontend.
The UserValidation Service can be used to validate if students are either present, late, late with a reason or absent in specific classes with their respective teachers.
The Configuration Service can be used to setup basic school settings like colors of the presence/absence indicators and the class schedule.
The API Gateway can be used for frontend -> backend communication.
Since not all backend services are up and running, it isn't possible to make them function in the frontend either.
In the future, the Usermanagement and ScheduleManagement services should get fixed so that their functionality can be used in the frontend to create a working version of PARS.

# Back-end

## How to use the project
Because this project makes use of the microservice architecture the project is split into several components/services.
These different microservices consist of 3 projects:
- The DAL, or data access layer is responsible for handling data persistence and database interactions. It provides an abstraction layer between the application and the underlying data storage system. The DAL project communicates with the database to perform CRUD (Create, Read, Update, Delete) operations and ensures data integrity and consistency.
- API.Core, this project serves as the core functionality and business logic layer of the microservice. It encapsulates the essential business rules and operations of the application. It defines the models, services and interfaces that represent the core functionalities of the microservice. The API.Core project does not directly handle the HTTP requests but provides a foundation for the API layer to build upon.
- API, the API project is responsible for exposing the microservice's functionalities to clients through HTTP-based APIs. It acts as a communication interface between the clients and the core logic of the microservice. This layer handles incoming HTTP requests, parses the request parameters and routes them to the appropriate API.Core service or method. 

### UserValidation Service
The UserValidation Services handles the attendance of students in classes. This is used by teachers in the frontend to keep track of attendance of students in their classes.

### Configuration Service
The Configuration Service handles the configurations of the PARS application for schools. This is used by administrators to setup the preferences for their school.

### UserManagement Service
The UserManagement Service is responsible for getting student data from the ODS2 Database. This student data will be used to keep track of all students in a school.

### ScheduleManagement Service
The ScheduleManagement Service is responsible for getting the schedules of teachers and students from the Xedule software system.

### API Gateway
The API Gateway is used as a way for the frontend to communicate with the different backend services. This way the frontend doesn't have to talk to each backend service specifically.


## Installation of the project
To fully use this project, all services need to be running. 
This can be done either through your IDE for development or through the docker-compose file.
To start working with this project:
- Clone the repository to your device
- Make sure you are on the Main branch.
- Open the repository with your IDE of choice.
- Start by routing into the correct repository.
```console
cd ..\Shared\Docker\
```
- Proceed to launch the containers using the images on the LOUPE container registry
```console
docker-compose up -d
```
- Note that the -d is optional and will run the containers in detached mode. [More Info](https://docs.docker.com/language/golang/run-containers/#:~:text=Run%20in%20detached%20mode&text=Docker%20can%20run%20your%20container,you%20to%20the%20terminal%20prompt.)

# Front-end
The frontend is written in React using Typescript. The frontend can be used by end users to validate student absence, to configure schedules and to authenticate/authorize users.
To start working with this project:
- Install node.js Latest Stable version [link](https://nodejs.org/en)
- Clone the repository to your device.
- Make sure you are on the Main branch.
- Open the repository with your IDE of choice.
- Start by routing to the Pars_Frontend folder.
- Start by installing necessary packages.
```console
npm install
```
- Run the application 
```console
npm start
```

## Useful Sources
[What are microservices?](https://microservices.io/)  
[Backlog with open issues](https://github.com/orgs/ItsWorkzFontys/projects/1)


## Dependencies
All used dependencies within the different microservices.
| Service              | Package                                           | Version                          |
|----------------------|---------------------------------------------------|----------------------------------|
| ConfigurationService | **API**                                           |                                  |
|                      | Microsoft.EntityFrameworkCore                     | 7.0.13                           |
|                      | Microsoft.EntityFrameworkCore.Design              | 7.0.0                            |
|                      | Swashbuckle.AspNetCore                            | 6.5.0                            |
|                      | Pomelo.EntityFrameworkCore.MySql                  | 7.0.0                            |
| UserValidationService | **API**                                          |                                  |
|                      | Microsoft.EntityFrameworkCore                     | 7.0.11                           |
|                      | Microsoft.EntityFrameworkCore.Design              | 7.0.11                           |
|                      | Microsoft.AspNetCore.OpenApi                      | 7.0.5                            |
|                      | Microsoft.VisualStudio.Azure.Containers.Tools.Targets | 1.17.2                       |
|                      | RabbitMQ.Client                                   | 6.5.0                            |
|                      | Swashbuckle.AspNetCore                            | 6.4.0                            |
|                      |                                                   |                                  |
|                      | **Core**                                          |                                  |
|                      |                                                   |                                  |
|                      | **DAL**                                           |                                  |
|                      | Microsoft.EntityFrameworkCore                     | 7.0.11                           |
|                      | Microsoft.EntityFrameworkCore.Design              | 7.0.11                           |
|                      | Microsoft.EntityFrameworkCore.SqlServer           | 7.0.11                           |
|                      | Microsoft.Extensions.Configuration                | 7.0.0                            |
|                      | Microsoft.EntityFrameworkCore.Tools               | 7.0.11                           |
|                      | Microsoft.Extensions.Configuration.Json           | 7.0.0                            |
| API.Gateway          |                                                   |                                  |
|                      | Microsoft.EntityFrameworkCore                     | 7.0.14                           |
|                      | Microsoft.EntityFrameworkCore                     | 7.0.14                           |
|                      | Microsoft.Extensions.Configuration                | 8.0.0                            |
|                      | Ocelot                                            | 20.0.0                           |
|                      | Swashbuckle.AspNetCore                            | 6.2.3                            |

# Documentation
All documentation can be found [here](https://github.com/ItsWorkzFontys/Pars3.0/tree/main/Documentation)
