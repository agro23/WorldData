# World Data

#### By Andy Grossberg & Jasun Feddema

## Description
A program using MySQL to load data about the world.

## Rules

World Data
Create an app that allows users to browse through information on countries. Most of the projects developers work on already have an existing database, so today we will practice querying a pre-existing database. Download this zip file and open it to unzip it. Next, use phpMyAdmin to import the .sql file (refer to the Exporting MySQL Databases in phpMyAdmin as a guide).

Create classes that model the `city`, and `country` table. You can choose whether to model `countrylanguage` and you do not have to model every column for `city` and `country`. Drop columns that do not interest you.
Add a view with all of the countries listed.
Allow users to filter results by any column (i.e. continent, region, surface area, independence year, population, etc.)(Hint: Create another method similar to `GetAll()` with a similar SQL query. The difference is that this query should use `WHERE`)
Add a view that lists all the cities. Allow users to choose whether to order the cities by population in ascending or descending order.
Further Exploration
If you get this far, great job! If you have extra time:

add a splash page that features a different random country each time the page is loaded.
try making each country/city name be a link to a view that displays that country's details.

## Specifications

* Load a database

* Connect to database

* Create City and Country Views

* Refactor code as needed.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/agro23/WorldData.git'.
* Run the command 'dotnet restore' to download the necessary packages.
* Run the command 'dotnet build' to build to build the app.
* Run the command 'dotnet run' to run the server on localhost.
* Use your preferred web browser to navigate to localhost:5000

## Support and contact details

* Contact the authors at andy.grossberg@gmail.com or jasun.feddema@gmail.com

## Technologies Used

* C#
* Asp .NET Core 1.1 MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Andy Grossberg & Jasun Feddema

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
