/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

DELETE FROM [Game]
DELETE FROM [People]

BEGIN

SET IDENTITY_INSERT Game ON

INSERT INTO People([PersonId], [Name], [Email]) VALUES
(1, 'Dillan', 'spaced92@gmail.com'),
(2, 'BusinessDillan', 'dillanwcarroll@gmail.com'),
(3, 'MadeupDillan', 'madeupDillan@gmail.com'),
(4, 'SexyDillan', 'callme@gmail.com'),
(5, 'WistfulDillan', 'regretful@gmail.com'),
(6, 'BoredDillan', 'meh@gmail.com');

INSERT INTO Game([GameID], [Name], [Email], [DateTime], [Venue], [Total]) VALUES
(9, 'SexyDillan', 'callme@gmail.com', '2019/11/11 12:33:44.999', 'nowhereland', 0),
(8, 'BusinessDillan', 'dillanwcarroll@gmail.com', '2012/12/12 09:22:33.999', 'nowhereman', 0),
(7, 'WistfulDillan', 'regretful@gmail.com', '2009/01/01 05:11:22.999', 'holyshitnowheremanisabrewery' , 0);

--SET IDENTITY_INSERT Game OFF
 
END;