* Nugets
    * Microsoft.EntityFrameworkCore.Sqlite.Core
    * Microsoft.EntityFrameworkCore.Tools
* DB
  * 
* DB migrations
    * PM> add-migration addProfilesTableToDb
    * PM> Update-Database

    * PM> add-migration addAlignerTableToDb -context AlignerDbContext
    * PM> Update-Database -context AlignerDbContext