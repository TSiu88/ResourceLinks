# _[Resource Links](https://github.com/TSiu88/ResourceLinks)_

#### _Brief desc of Project, 03.24.2020_

#### By _**Tiffany Siu and Andriy Veremyeyev**_

<!-- [![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive) -->
<!-- [![Project Status: Active – The project has reached a stable, usable state and is being actively developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active) -->
[![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip)
![LastCommit](https://img.shields.io/github/last-commit/tsiu88/ResourceLinks)
![Languages](https://img.shields.io/github/languages/top/tsiu88/ResourceLinks)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Notable Features](#notable-features)
4. [Specifications](#specifications)
5. [User Stories](#user-stories)
6. [Screenshots](#screenshots)
7. [Known Bugs](#known-bugs)
8. [Support and Contact Details](#support-and-contact-details)
9. [License](#license)
---
## Description

#### 3/24/20 Work from Home Summary
- University Registrar
  - Add password authorization
- Resource Links
  - Design project to be applicable for recent events
  - Able to apply project to any other resource link sharing
- Career Services Presentation on CVs/Cover Letters/Resumes
- Struggles:
  - Many-to-many relationships creating multiple relationship with checkboxes
  - Checkboxes being enabled and interactable with HTML helpers and passing it into the controller

#### Notes
Be able to add and share resources that are important for the current situation of the Coronavirus Outbreak or any other situation where sharing a large amount of resource links.  This application will consolidate links to be viewable in one place and organized by category.

Class Category, Class link, Class tag
- categorylink, linktag
- links have multiple categories
- links have multiple tags
- categories and tags not connected

Login authorization
- log in to be able to edit, add, delete links
- without login can view pages but not edit

Class Category
- id
- title

Class Tag
- id
- name

Class link
-id
-resource name
-link URL
-description (optional)


Hardcode

Class Category
- Volunteering
- Education
- Entertainment
- General
- Health
- Food
- Unemployment

Class Tag
- Local
- National
- Time sensitive
- Limited time
- Global
- Statistics?
- Data/Research?

Extra Methods
- Search
- Sort

Possibility to create link with several categoies and tags.

_README under construction_
<!-- _Detailed desc w/ purpose/usage, what does, motivation to create, why exists, other info for users/developers to have_ -->

## Setup/Installation Requirements

_This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10 from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)._ 

_This program also makes use of SQL databases. We recommend using MySQL Workbench to build your databases. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for installing MySQL WorkBench and MySQL Community Server on Mac (using links [Mac1](https://dev.mysql.com/downloads/file/?id=484914) and [Mac2](https://dev.mysql.com/downloads/file/?id=484391)) or [Windows 10](https://dev.mysql.com/downloads/file/?id=484919)._

### Requirements to Run
* _.NET Core_
* _ASP.NET Core MVC_
* _MySQL Workbench_
* _MySQL Community Server_
* _Entity Framework_
* _Command Prompt_
* _Web Browser_

### Instructions

*This application may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Download and install MySQL Workbench and Community Server for Mac or Windows by following the instructions [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
3. Click clone the [repository](https://github.com/TSiu88/ResourceLinks.git) from my [GitHub page](https://github.com/TSiu88) to copy the repository link
4. Use a command line interface to type `git clone (repository-link-here)` to copy the project into the current folder and then move into the repository's directory that was just created with `cd (project-name-here)`
5. Start up a local server by opening MySQL Workbench and adding a `MySQL Connections` using the default IP address and Port (IP 127.0.0.1, Port 3306), username (root), and password from setup.
6. Run `dotnet restore` and `dotnet build` in command line interface of the repository's main project directory
7. Run `dotnet run` to start up the program in the command line interface
8. Type the URL listed under "Now listening on:" into a web browser to run

## Other Technologies Used
* _C#_
* _HTML_
* _CSS_
* _MSTest_
* _Razor_
* _Markdown_

## Notable Features
<!-- _features that make project stand out_ -->

## Specifications

<!-- * _List of features the program should do, from simplest to more complex, handling all possible cases.  Can do as text or put in table, with example input and output_
  * _Example Input: expected input_
  * _Example Output: expected output_
 -->

## User Stories

<!-- * As a scheduler, I want to be able to organize nurses vacation schedules without much paperwork so that I can be more efficient.
* As a scheduler, I want to see a list of requests with the overlapping dates and the nurses that sent in the requests organized by priority so I can see which staff member should have priority in getting the request approved. -->

<!-- * Give stories for people who will use this project and what they'd want it to do.  Can include customers/end users, programmers that maintain code, etc. Use "As a <job title/type of user/etc>, I want to...<what want program to achieve>... so that I can...<reason>.-->


## Screenshots

<!-- _Here is a snippet of what the input looks like:_

![Snippet of input fields](img/snippet1.png)

_Here is a preview of what the output looks like:_

![Snippet of output box](img/snippet2.png) -->

<!-- _{Show pictures using ![alt text](image.jpg), show what library does as concisely as possible but don't need to explain how project solves problem from `code`_ -->

## Known Bugs

_There are currently no known bugs in this program_

## Support and contact details

_If there are any question or concerns please contact us at our emails: [Tiffany Siu](mailto:tsiu88@gmail.com) and [Andriy Veremyeyev](mailto:belyybrat@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Andriy Veremyeyev_**
