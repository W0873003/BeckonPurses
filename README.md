# BeckonPurses

# Beckon Purses - Web Application

## Project Overview
Beckon Purses is a web application designed to showcase and manage a collection of purses with various attributes such as material, size, shape, color, texture, closure type, and price. This project is developed as part of the CYB 206 Web Application Security course by Team THETA.

## Team Members
- *Austin Albaloo*
- *Christina Joseph*
- *Milin Vaniyawala*

## Technology Stack
- *Development Environment:* Visual Studio Community 2022 (Version 17.12.0)
- *Framework:* .NET 8.0.404
- *Database:* Entity Framework with multiple DbContexts (Authentication and Product Management)
- *Version Control:* Git & GitHub

## Features Implemented
- MVC Architecture with Controllers, Views, and Models
- Basic Web Pages and Navigation
- Dynamic Purse Catalog with CRUD Operations (Scaffolding used for page creation)
- Database Integration with Entity Framework and Migrations
- Layout Customization (Navbar, Footer, and Titles Updated)
- Initial Seed Data for Testing

## Installation & Setup
```bash
# Clone the Repository
git clone https://github.com/MilinVaniyawala/BeckonPurses.git
cd 
# Run the Application
dotnet run

# Database Setup & Migration
Add-Migration "InitialCreate" -Context BeckonPursesContext
Update-Database -Context BeckonPursesContext