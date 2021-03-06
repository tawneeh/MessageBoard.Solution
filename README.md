# _Message Board API_ 

#### _C# Practice Building an API For Epicodus_ 
#### _DATE 01.20.2021_

#### By _**Tawnee Harris**_

## Description

This application will act as a message board service that can be accessed via my API.

## Prompt

Create a message board service that can be accessed via your API. Users should be able to GET and POST messages for specific message boards. Note that you will have to create custom endpoints for some of these user stories.

* As a user, I want to be able to GET all messages related to a specific group.
* As a user, I want to be able to POST messages to a specific group.
* As a user, I want to be able to see a list of all groups.
* As a user, I want to input date parameters and retrieve only messages posted during that timeframe.
* As a user, I want to be able to PUT and DELETE messages, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)

## Setup/Installation Requirements

Software Requirements
* An internet browser of your choice; I prefer Chrome
* A code editor; I prefer VSCode
* .NET Core

Open by Downloading or Cloning
* Navigate to <>
* Download this repository to your computer by clicking the green Code button and 'Download Zip'
* Or clone the repository

AppSettings
* This project requires an AppSettings file. Create your `appsettings.json` file in the `ClientMessageBoard` project directory. 
* Format your `appsettings.json` file as follows including your unique password that was created at MySqlWorkbench installation:
```
{
  "ConnectionStrings":{
      "DefaultConnection": "Server=localhost;Port=3306;database=message_board;uid=root;pwd=<YourPassword>;"
  }
}
```
* Update the Server, Port, and User ID as needed.

Import Database using Entity Framework Core
* Navigate to MessageBoard.Solution/APIMessageBoard and type `dotnet ef database update` into the terminal to create your database tables.

Launch this Application
* Navigate to MessageBoard.Solution/ClientMessageBoard and type `dotnet restore` into the terminal
* Then, in the same project folder, type `dotnet build` into the terminal followed by `dotnet run`
* Peruse this application at your leisure
* (Is it necessary to also have the APIMessageBoard running at the same time? On a different Port, of course)

## Known Bugs

This application has no known bugs. 

## Support and contact details

Please feel free to reach out to me anytime at <tawneeh@icloud.com>

## Technologies Used

* C#
* Razor
* Entity Framework Core
* MySql
* MySql Workbench
* Identity

### License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 **_Tawnee Harris_**