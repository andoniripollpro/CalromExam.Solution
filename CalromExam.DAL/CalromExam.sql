USE Master;
GO
DROP Database CalromExam;
GO
CREATE DATABASE CalromExam;
GO
USE CalromExam;
GO
CREATE TABLE MembershipData (MemberId INTEGER IDENTITY (1,1) CONSTRAINT pkMemberId PRIMARY KEY, MemberName NVarChar (50));
CREATE TABLE FlightData (FlightDataId INTEGER IDENTITY (1,1) CONSTRAINT pkFlightDataId PRIMARY KEY, Destination NVarChar (50), FlightStatus NVarChar(50), ArrivalDate DATETIME, FlownMiles INTEGER);
INSERT INTO MembershipData (MemberName) VALUES ('Mr Don Hall');
INSERT INTO MembershipData (MemberName) VALUES ('Mr Jon Morris');
INSERT INTO MembershipData (MemberName) VALUES ('Ms TiAnna Jones');
INSERT INTO FlightData (Destination, FlightStatus, ArrivalDate, FlownMiles) VALUES ('Seattle', 'Flight Delayed 1 hour', CONVERT(DATE, '25/8/00'), '20000');
INSERT INTO FlightData (Destination, FlightStatus, ArrivalDate, FlownMiles) VALUES ('London', 'Flight on time', CONVERT(DATE, '12/9/00'), '15000');
INSERT INTO FlightData (Destination, FlightStatus, ArrivalDate, FlownMiles) VALUES ('Sydney', 'Flight Gate Closing', CONVERT(DATE, '5/11/00'), '30000');
INSERT INTO FlightData (Destination, FlightStatus, ArrivalDate, FlownMiles) VALUES ('Tokyo', 'Delayed Fog', CONVERT(DATE, '25/5/00'), '25000');
INSERT INTO FlightData (Destination, FlightStatus, ArrivalDate, FlownMiles) VALUES ('Minneapolis', 'Flight on time', CONVERT(DATE, '1/5/00'), '1000');
INSERT INTO FlightData (Destination, FlightStatus, ArrivalDate, FlownMiles) VALUES ('Memphis', 'Flight Gate Closing', CONVERT(DATE, '5/1/00'), '1000');