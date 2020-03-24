# _[Assignment Name](https://github.com/TSiu88/#)_

#### _Brief desc of Project, 03.16.2020_
<!-- ##### _Version 1.1 Updated 01.11.2020_ -->

#### By _**Tiffany Siu**_

<!-- [![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive) -->
<!-- [![Project Status: Active – The project has reached a stable, usable state and is being actively developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active) -->
<!-- [![Project Status: WIP – Initial development is in progress, but there has not yet been a stable, usable release suitable for the public.](https://www.repostatus.org/badges/latest/wip.svg)](https://www.repostatus.org/#wip) -->
<!-- ![LastCommit](https://img.shields.io/github/last-commit/tsiu88/wordcounter-csharp)
![Languages](https://img.shields.io/github/languages/top/tsiu88/wordcounter-csharp)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/) -->

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
7. [Test Case Example](#test-case-example)
8. [Known Bugs](#known-bugs)
9. [Support and Contact Details](#support-and-contact-details)
10. [License](#license)
---
## Description

_README under construction_
<!-- _Detailed desc w/ purpose/usage, what does, motivation to create, why exists, other info for users/developers to have_ -->

## Setup/Installation Requirements

<!-- _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10 from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)._ 

_This program also makes use of SQL databases. We recommend using MySQL Workbench to build your databases. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) for installing MySQL WorkBench and MySQL Community Server on Mac (using links [Mac1](https://dev.mysql.com/downloads/file/?id=484914) and [Mac2](https://dev.mysql.com/downloads/file/?id=484391)) or [Windows 10](https://dev.mysql.com/downloads/file/?id=484919)._ -->

### Requirements to Run
<!-- #### C#
* _.NET Core_
* _ASP.NET Core MVC_
* _MySQL Workbench_
* _MySQL Community Server_
* _Entity Framework_
* _Command Prompt_
* _Web Browser_ -->

<!-- #### Javascript
* _Web Browser_
* _Webpack_
* _Node.js_
* _NPM_
* _API KEY_ -->

### Instructions

<!-- *This application may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Download and install MySQL Workbench and Community Server for Mac or Windows by following the instructions [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
3. Click clone the [repository](https://github.com/TSiu88/HairSalon.git) from my [GitHub page](https://github.com/TSiu88) to copy the repository link
4. Use a command line interface to type `git clone (repository-link-here)` to copy the project into the current folder and then move into the repository's directory that was just created with `cd (project-name-here)`
5. Start up a local server by opening MySQL Workbench and adding a `MySQL Connections` using the default IP address and Port (IP 127.0.0.1, Port 3306), username (root), and password from setup.
6. Construct the database by entering in the following lines under the `Query 1` section and then clicking execute:
  >
    CREATE DATABASE tiffany_siu;
    USE tiffany_siu;
    CREATE TABLE stylists (id serial PRIMARY KEY, name VARCHAR(255));
    CREATE TABLE clients (id serial PRIMARY KEY, description VARCHAR(255));
7. Run `dotnet restore` and `dotnet build` in command line interface of the repository's main project directory
8. Run `dotnet run` to start up the program in the command line interface
9. Type the URL listed under "Now listening on:" into a web browser to run -->

<!-- *This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/csharp-bakery.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore` and `dotnet build` in command line interface of the repository's directory
5. Run `dotnet run` to start up the program in the command line interface
6. Type the URL listed under "Now listening on:" into a web browser  -->

<!-- 1. Download and install Node.js from the [official website](https://nodejs.org/en/download/)
2. Clone the [repository](https://github.com/TSiu88/beep-boop.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line/Bash to move to the project directory with `cd project-directory`
4. Run `npm install` to get all dependencies. 
5. Run `npm run start` to start up the program -->

<!-- _This page may be viewed by cloning the [repository](https://github.com/TSiu88/beep-boop.git) from my [GitHub page](https://github.com/TSiu88) and opening the **index.html** file in any web browser._ -->

<!-- _Other things need to run like servers, databases, code, how to install and use program_ -->

## Other Technologies Used
<!-- #### C#
* _C#_
* _HTML_
* _CSS_
* _MSTest_
* _Razor_
* _Markdown_ -->

<!-- #### Javascript
* _HTML_
* _CSS_
* _Javascript_
* _JQuery 3.4.1_
* _Bootstrap 4.4.1_
* _ESLint_
* _Babel_
* _Jest_
* _Markdown_ -->

## Notable Features
<!-- _features that make project stand out_ -->

## Specifications

<!-- * _List of features the program should do, from simplest to more complex, handling all possible cases.  Can do as text or put in table, with example input and output_
  * _Example Input: expected input_
  * _Example Output: expected output_
* _Example: The program does nothing to non-alphabetical characters, since they do not contain consonants or vowels._
  * _Example Input: 3_
  * _Example Output: 3_
* _Example: The program adds "way" to single-letter words beginning with a vowel._
  * _Example Input: i_
  * _Example Output: iway_
* _The program adds "way" to multi-letter words beginning with a vowel._
  * _Example Input: open_
  * _Example Output: openway_
* _The program takes the single consonant from the beginning of the word and adds to the end with "ay"_
  * _Example Input: latin_
  * _Example Output: atinlay_
* _The program takes all consecutive consonants from the beginning of the word and adds them to the end with "ay"_
  * _Example Input: translator_
  * _Example Output: anslatortray_
* _The program takes beginning consonants and if it contains "q", also take the "u" after it and add them to the end with "ay"_
  * _Example Input: squeal_
  * _Example Output: ealsquay_
* _Etc._ -->

<!-- <details>
  <summary>Click to expand to view specifications</summary>

| Specification | Input | Output |
| :-------------     | :------------- | :------------- |
| **The program displays welcome message and menu with prices** | Application start | Welcome message and menu displayed |
| **The program displays special deals in readable format** | Application start | Special deals displayed ("Buy 2, get 1 free" "3 for $5") |
| **The program takes input of user that is not an integer, then assume 0 ordered** | Bread="aaa", Pastry="" | Bread=0, Pastry=0 |
| **The program takes number of loaves of bread and pastries and displays totals** | Bread=4, Pastry=4 | Bread=$20, Pastry=$8, Total=$28 |
| **If input qualifies for special deals, costs calculated using discounted price** | Bread=3, Pastry=3 | Bread=$10, Pastry=$5, Total=$15 |

</details> -->

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

## Test Case Example
<!-- _Tests are done through MSTest and are run from the command line prompt with `dotnet test` from the `ProjectName.Tests` directory. -->
<!-- _Tests are done through Jest and are run from the command line prompt with `npm test`._ -->

<!-- _Some example tests:_

![Snippet of an example test](img/tester1.png)

![Snippet of an example result](img/tester2.png) -->

<!-- _describe and show how to run tests with `code` examples}_ -->

## Known Bugs

_There are currently no known bugs in this program_

## Support and contact details

_If there are any question or concerns please contact me at my [email](mailto:tsiu88@gmail.com). Thank you._

<!-- _If there are any question or concerns please contact us at our emails: [Tiffany Siu](mailto:tsiu88@gmail.com) and [Name](mailto:#). Thank you._ -->

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu_**
