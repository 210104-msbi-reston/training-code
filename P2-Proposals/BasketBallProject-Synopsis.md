# Basketball Predictions and Analysis

## Description
Our project aims to find meaningful statistics on NBA regular season historical data (about 16 years amount of data) such as average points a team makes per game or how many shots they make on average. Using this data, our project can make a number of predictions such as a team's chance of winning against another team, who might win the MVP award, etc. All values will be obtained by SSIS through Microsoft Excel, flat files, and/or web services to be stored onto MS SQL Server 2016. This data will then be analyzed using SSAS. Finally, the data is processed using SSRS into easy-to-digest information.

## Automation
1. Filter data from downloaded [.CSV files](https://www.kaggle.com/nathanlauga/nba-games?select=players.csv)
2. Data processing: 
   * Find relationships between .CSV files
   * Remove null rows and exception handling to log it to a table
   * Transform data and mapping columns to a centralized database
3. Search and data scrap specific NBA player's overall statistics based on player name
4. Search and data scrap each NBA player's overall statistics in a single team based on team name
5. Search and data scrap specific NBA player's statistics in a specific year or a range of years
6. Search and data scrap specific NBA player's statistics in a specific game
7. Search and data scrap specific game statistics based on 
8. Predict the chance of winning when comparing two NBA teams
9. Predict the overall seasonal outcomes
10. Predict the potential MVP in the whole league

## Tech Stack
* Microsoft SQL Server 2016
* SSIS
* SSAS
* SSRS

## Team
* Stephen Pagdilao - Team Lead
* Chase Hovel
* Sammy Baez
* Virgilio Ilagan
 
