To Add Table
- Create Model in DLL , Domain Folder
- Add DBSet to DBContext
- Run NPM (Nuget Packet Manager Console)
- Run Add-Migration
- Give it a name
- Run Update-Database

To Add API Endpoint
- Create Controller
- Create Method with Entity Type as response
- Add relavent Action Type eg HTTPGET
- Add Route in HTTPGET for Params eg HTTPGET("id") which maps to relavent param named id
- Add Relavent Service Method 
- Add Method to Relavent Interface
- Call Relavent Method from Controller
- Add Relavent Repository
- Add Interface for Injection or Extent Interface with relavent Method signiture
- Implement Code inside Respository making use of DBContext and Linq

To Add MVC Endpoint / Page / Flow
- Create Controller
- Create Method Inside controller with HTTPGET
- Create ViewModel for View Data
- Create Another Method to recieve Data from that View with Param of ViewModel and HTTPPOST
- Create Response Model
- Map ViewModel to relavent Response Model
- Create Handler To bind ViewModel and Response Model
- Create Mapping from Domain Model to Response Model
- Create Mapping from ViewModel to Domain Model
- Inject/ Create Relavent Serices
- implement Service Logic using Instantiated Client Class
- Implement Business Logic inside of Handler
- Implement View UI code inside of created View
