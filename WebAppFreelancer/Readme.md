# DO Freelancer-ASP.NET MVC
------------------------
Public releases, this website project has not reached the alpha version yet.

Initially, this was my University project at Vilnius University. Most of the projects done in the University goes by forgotten and dropped out. I have decided
to continue working on this one and improving my knowledge in some specific fields during the development process.
Since there's a lot of things that can be tweaked and changed, I want to update the scripts and the documentation before releasing.
This website project won't be put up to the market or sold. As of right now, you are able to download the project with fair use freely. UI design remade thoroughly learning from Winkel bootstrap examples.

In this project, I am using MVC(Model-Controller View) architecture design patterns also I am working with .Net Visual Studio IDE.
An Freelancer hosted on localhost and written with the following frameworks (all of those frameworks can be found in use in the project itself):
If by any chance you are working with this right now, you are free to learn the following from this:
    * Migrations 
    * Entity Framework
    * Unity Container
    * Bootstrap(version 4.5)
    * jquery
    * Plain javascript
    * Ajax

    The project uses Web Layer architecture:
    -  Presentation layer
    -  Business layer
    -  DataAccess layer

During the creation of this project, I used the 7 model and identity user authorization. and I used the 8 controller for each model and they have prestavlenie.ideniti user registration he has
a separate class user and allowed me to share the role of each user. Each role is provided with a layout page and a separate function for example: only an admin can add a user and a country.
the user is divided into two roles, the first one who wants to find a job and the second is he has a project and he wants to hire an employee.
    
    The project controllers:
    - AccountController
    - CategoriesController
    - HomeController
    - MainController
    - ManageController
    - ProjectController
    - RoleController
    - ServicesController

    The project models:
    - AccountViewModels
    - Category
    - Contact
    - IdentityModels
    - ManageViewModels
    - ProjectModels
    - RoleViewModels
    - ServiceModels
    -WebAppFreelancerContext