# Washington DC Hotel Travel Agency

## Description
Our project will allow users to book a room in a hotel in the Washington D.C. area. It will record data about each transaction and stay, store the information in a data warehouse, and provide the travel agency with all of the data in an easy to use format.

## Operations
1. Import Washington DC hotel information through SQL Server Integration Services prior to launching the database.
2. Have user choose a hotel and duration of stay.
3. Record information in a Booking Information Data Warehouse.
	* Booking Details Fact Table
		* Hotel Dimension
			* Name
			* Location
			* Total Number of Rooms
		* Date Dimension
			* Month
			* Day
			* Year
			* Season
		* Customer Dimension
			* Age
			* Home Address
			* Other Demographic Info
		* Cost Dimension
			* Cost Per Night
		* TransactionMethod Dimension
			* Online
			* Over Phone
			* On site
		* Room Type Dimension
			* 2 Queen Size Beds
			* 1 King Size Bed
			* Suite
4. Compile Data Warehouse into Data Cube using SQL Server Data Tools in Visual Studio.
5. Import data cube into SQL Server Analysis Service.
6. Generate reports and easy to understand visuals using SQL Server Reporting Service.

## Tech Stack
Microsoft Business Intelligence (MSBI)
* Microsoft SQL Server
* SQL Server Integration Service (SSIS)
* SQL Server Analysis Service (SSAS)
* SQL Server Reporting Service (SSRS)


## Team 4
Ayanes Arapioannou

Dakota Wells

Robert Palmer

Spencer Barck
