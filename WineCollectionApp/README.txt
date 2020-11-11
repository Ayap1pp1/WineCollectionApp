How to set up WineCollectionApp.

1. Create a database in MSSMS (preferably named WineCollection)

2. Create a user to connect to the database in:
 	[Winecollection] > Security > Users
	- Preferably name the user: "TEST" with Password: "123456"

3. (In case you didn't name the database [WineCollection] or the user according to previous recommendations)
Update the connectionstring in DatabaseContext.cs with the Database name, username, and password you just created 

4. Run script 1 and script 2 in file "DATABASE SCRIPTS.txt"

5 (Optional) Run Script 3 and Script 4 in file "DATABASE SCRIPTS.txt" to create initial dummy data.
	