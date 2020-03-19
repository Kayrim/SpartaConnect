#Contents
- [SpartaWebApp](#spartawebapp)
- [Daily Standup Log](#daily-standup-log)
  * [Standup 1](#standup-1)
  * [Standup 2](#standup-2)
    + [What we did yesterday:](#what-we-did-yesterday-)
    + [What we will do today:](#what-we-will-do-today-)
    + [Blockers:](#blockers-)
  * [Standup 3](#standup-3)
    + [What we did yesterday:](#what-we-did-yesterday-)
    + [What we will do today:](#what-we-will-do-today-)
    + [Blockers:](#blockers-)
- [Sprint Log](#sprint-log)
  * [Sprint 0](#sprint-0)
  * [Sprint 1 Planning](#sprint-1-planning)
  * [Sprint 1 Actual](#sprint-1-actual)
  * [Sprint 1 Review](#sprint-1-review)
  * [Sprint 1 Retrospective](#sprint-1-retrospective)
    + [What went well:](#what-went-well-)
    + [What we could've done better:](#what-we-could-ve-done-better-)
    + [Next sprint improvements:](#next-sprint-improvements-)
- [Getting Started](#getting-started)
    * [MVC startup instructions:](#MVC-startup-instructions)
    * [Prerequisites](#prerequisites)
- [Running the tests](#running-the-tests)
- [Deployment](#deployment)
- [Built With](#built-with)
- [Authors](#authors)
- [License](#license)

# SpartaWebApp

A sparta themed web application which contains pages for student user profiles and their corresponding trainers.
Comprised of data held in an ASP.NET API back-end with React used to build the user interface to interact with the data.

# Daily Standup Log
## Standup 1
Our first standup consisted of laying out our plan for the day, which was to create the database, as well as make the API so that we could read data off of the API rather than directly from the database

## Standup 2
### What we did yesterday
We created the database and API as a template, to prepare us for today.
### What we will do today
We will split into 2 teams, where one will work on a React front end and the other will work on an MVC front end (Razor).
Both teams have a similar plan, where we will both work on the layout of the page, add actual information rather than placeholder information to each bio and add a search bar and some filter buttons without functionality.
### Blockers
No blockers from yesterday

## Standup 3
### What we did yesterday
Yesterday was a sucessful day for both groups. Both teams completed the majority of the work planned to be completed by today, which indicated we are working at a good pace. Both teams have a layout (slightly differing from each other but mainly the same). Both teams have also managed to get a search bar, with partial functionality as well as being able to filter through streams showing only people of the chosen stream. In addition to this, we have real information per bio.
### What we will do today
Today we will finish off design, and get the front end reading off of the API, rather than the database. We will finish functionality of search bar and buttons, complete any extra information from requirements and attempt to finish up a potential finihsed product by the next stand up, leaving only a final polish.
### Blockers
Knowledge of css libraries are slowing progress, in both groups but not causing major issues, just prolonging the completion of the project

# Sprint Log
## Sprint 0
We started off sprint 0 with our initial planning, which consisted of requirement gathering, Database relationship planning using LucidChart and creating User Stories through epics and features that were to be included. We used a *Github Project board* to group our user stories according to the user requirement.

<img src="https://i.imgur.com/tPH5TcN.png" width="800" height="450"/>

We created our User Stories after we had spoken to our product owner who had let us know what product they were looking for, along with what sorts of features they wanted and how they wanted it laid out. With a provided wireframe it gave us a clear indicator on how they wanted it to look as well. Our project was to create a web page that contained a search function, a filter function, tiles per trainee that had a video profile as well as an image and bio for each trainee. After we discussed and made sure we had a clear idea of what was expected, we started writing user stories to create a backlog.

## Sprint 1 Planning
In our sprint planning, we split up into teams to help us attack this task correctly. For our first sprint we decided we would start basic and one team would make an MVC page that just has the layout, without the functionality as sprint 1. We also decided that we would have the other team create the same page using React, as we felt this would look cleaner for the overall product. 

## Sprint 1 Actual
We set ourselves a timeframe of 5pm (16/03/20) - 10am (17/03/20) to complete this sprint. We created the database, after writing out an SQL query to create our initial database. We then scaffolded our DB context to create our model classes, as well as add controllers to help us view, edit and delete data from the database. In addition to this, we edited the according files so that we could load an initial page when running a project, and pushed everything back up to Github as our first iteration. 

Team 1 would start the MVC page with correct layout but no functionality, and team 2 would do the same but in React. We used the requirements to guide us and create a product to show the product owner at the end of this sprint, to ensure we are heading in the right direction.

## Sprint 1 Review
On communication with the product owner, our feedback indicated we were on the right track. After showing the product owner 2 MVP's, with varying functionality and layout. The feedback for the MVC side was good functionality, however the layout provided was clunky and did not match his idea of 'card' layouts. The React side had a very clean layout, lacking the functionality in the search bar. In conclusion, the feedback helped us come to a decision that we would combine the functionality from the MVC search bar and the React front end to produce the ideal product. Overall, our sprint 1 was a success and we now have improvements which we can carry into sprint 2. 

## Sprint 1 Retrospective
### What went well:
Created a MVP to show the product owner.
### What we could've done better:
Follow the User Stories in a more methodical manner.
### Next sprint improvements:
User Stories 

# Getting Started

### MVC startup instructions:
1. Clone the project repo from branch: mvc2
2. Load up SpartaConnect_API.sln in VS
3. View ==> Sql server object explorer
4. Under chosen server (e.g localdb) right-click ==> New Query
5. In Solution Explorer right-click project 'SpartaConnectAPI' and open file location
6. Open 'SQLQUERY.sql' using preferred text editor
7. Copy Content and paste in 'New Query' in VS
8. Run query
9. In solution Explorer right-click ==> Solution'SpartaConnectAPI' ==> Properties
10. Startup project ==> Multiple startup projects ==> Under 'Action' column set both SpartaConnect_API and SpartaConnect_MVC to 'Start'
11. Apply and Close
12. Build Solution and Run

### React startup instructions

Clone the project from github and run the SQL query to create the SpartaDB.

### Prerequisites

Visual Studio 2017+

# Running the tests

Explain how to run the automated tests for this system

# Deployment

Web application will be deployed onto netlify.

# Built With

* [React](https://reactjs.org/) - The JavaScript library used.

# Authors

* **Stephen Callum** [Github](https://github.com/Stephen-Callum)
* **Karim Bakkali** [Github](https://github.com/Kayrim)
* **Jamie Benjamin** [Github](https://github.com/jamieb97)
* **James Kavanagh** [Github](https://github.com/jwKav)
* **Jordan Benbelaid** [Github](https://github.com/jordanbenbelaid)
* **Hassan Abdullahi** [Github](https://github.com/Hassan822)
* **Timothy Wong** [Github](https://github.com/tim8642)

# License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.
