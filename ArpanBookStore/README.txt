Date November 3 2023 
Recreated the project.
README 
Author name : Arpan Arpan
Student ID: 0820839

Hi there I am working again using mvc on new application . This time I am building the BookStore website and this is the Assignment 2.
Since there is alot of new things to see , I have the Areas folder Data folder already built in, Niether like the assignment 1 where i created it by my self.

PART 1
The first step he told to do is to edit the startup.cs file. As he mentioned we commented the Identity user in the services.
Now lets runs it if its working or not .............. Its working nothing to be worry about.

I did a interesting step here which I tried in the class also, I tried to register the on my application by email and password.
And when i click submit it pops up with an exception. I was worried but it was nothing just said to update the database. I hit the button apply migrations and it worked. 

PART 2

Lets move forward and try debugging.

I added a breakpoint only on privacy view and tested it while clicking it on the browser. It stops the browser and after i clicked it proceeded the action.

PART 3:

I am working on the Part 3 the Bootstrap.css.
I selected my theme from the bootswatch and downloaded the file bootstrap.css sof the theme.
I changed the nav classes text dark and the footer properties as given in the instructions.Later I change the loginPartial file also I removed the text dark from the nav links.

I did'nt like the bootstrap.css i chose , so i changed it and apply it again... So the one I applied now i liked it..... I'll keep this one ..

According to the provided links I added the given scripted links in my layout.cshtml file.
I added the css links and js links in it.
 In my this steo I added the dropdown menu in the layout page. As given in the instructions i added the cod in the layout.cshtml and it test it out.
 Yes its working......................................

 Now I added a dropdoen list in the layout.cshtml file
 I cahnged the name from dropdown to the Content Management.
 I created the ArpansBooks.DataAccess, ArpansBooks.Models and ArpansBooks.Utility class library as given in the instructions .

 I pasted the data folder in dataaccess and deleted the original one.

 I installed the entity frameworks that were required to install with version 5.0.17.
 The Microsoft.entityframework.relational and the entityframework.sqlserver.
 Next it said to delete the migrations folder and install the indentity.EntityFramework Core with the version 5.0.2 in the project. I followed the step as per instructions.........

 In my next I cjhanged the namespace according to the project and deleted the class1.cs files from every project.
 Next I moved the Models folder into the models project and deleted the original one.

 I renamed the models folder with the ViewModels file and changed the namespace of ErrorViewModel.cs to models.ViewModels as per given instructions.

Modified the dbcontext of the  startup.cs file and fixed all the list of errors thank god .................... I am able to do that... I am so proud of myself..

Finally i solved the errors.

In my utility projects i added the class with the name SD.cs file and modified the properties of the file. Later I added the reference of the utility project with the main project 
and added the dataaccess project refrence to the utility and models project. 
In my next step I added the area under the Area folder with the name customer, It runs the scaffolding and after that i changed the routes in the startup.cs file as given.
 As per instructions i moved the homecontroller.cs file into the controller file of the areas under customer folder.
 Then i deleted the Models and Data.

 Then i moved the home page under the view folder of areas and updated the homecontroller.cs file namespace.

 Then i moved the home page under the view folder of areas and updated the homecontroller.cs file namespace.
 Later I copied the viewStart.cshtml file and viewImports.cshtml file into the views
 After that I runned the application and it worked.

  after that i have added a new folder in Areas name as a Admin and added Views file in it 
 After this step i have deleted the Data And Models and in last step i have deleted my controllers folder and my assignment is completed niow ...... 

 ASSIGNMENT PART 2( Working on the second part of the assignment)

 I changed database name and saved it in the appsetting.json.
 I added the new migration in the project .dataAccess: add-migration AddDefaultIdentityMigration 
 Since the migrations are created lets update them. I updated it reviewd the tables in the update.

 I created the category.cs class under model project and added the table in it. After that i run the migration command to the PM and it showa ERROR.....
 Then i saw that my project was wrong...
 And here is migration (20232203224754)

 I updated the my code and reRun the migration command and found that my dbcontext was empty the I saw that in my code I put DBSet which was DbSet.....
 After changing it i again dlt the cs file and re run the migration command And It worked ............

 I created the Repository folder and added the new folder under it with the IRepository name. In my Irepository i added the class IRepository....
 I added the given code in the IRepository.cs file
 
 Created the rpository.cs file and added the gievn code in it...

 I added the CategoryRepository and ICategoryRepository in the DataAccess project .
 After that i added the required code and fixes the errors.

 I did the remaining modifications in the CategoryRepository file  where i passed the values of id and name .
  Added new interface ISP_Call.cs in the Irepository folder and got errors.... I installed the Dapper and my project is good to go....
  Later I added the given code according to the instructions...
  
  Added new class SP_Call.cs file in the Repository and added the code to link the class and the interface.

  I added new interface and class of name IUnitOfWork and UnitOfWork and added the given code in the file.
  Added new MVC Controller under the Areas/Admin/Controllers and modified it with the given code in the instructions .

  Now i created a Category folders under Areas/Views folder . In the category folder i created a view folder and added index.cshtml file and modify my code

  i modify my layout page by adding category and dropdwon menu...then test it .... its good...

  I added the given code in the Index.cshtml to add the icons of edit and delete in the project...
  But later the step told me to delete that part ( Litterally this made me so angry .......)
  and add the javascript into the Category.js file under the wwroot provided by the proffessor...
  And linked the file with thw index of the category ... Run the App and it worked.

  I added the IAction method in the CategoryController.cs file and later i am updating the code to reflect the edit and deleted the categories.
  Added the Upder.cshtml file in the category....

  I created two Razor view files for the buttons whvih was _CreateAndBackToListButton and _EditAndBackToListButton and added the required code in it.....

  My application was not working so i found out that I haven't done thw partial view ... 
  So i deleted the upsert and cshtml files and do it again.

  Solved the errors of my project and its working now....

  I added the required code remove the savhchanges() in the catogoryController.cs file later i updated the path in the javascript file ....
  After that i run my application and it worked...

  DataTables warning: table id=tblData - Ajax error. For more information about this error, please see http://datatables.net/tn/7

  Working on the Database error , The ajax error

  I worked over my code and found out that my databse was not working properly. I rewrite my code and update the database. And now my Application is working.

  ASSIGNMENT 2- PART III (november 17, 2023) 

  SECTION 1

  I added the CoverType.cs class in the models project and gave it the id and name.

  I added the CoverTypeRepository class  and IcoverTypeRepository interface to the repository.
  I added the migration via PM console "add-migration AddCoverTypeToDB ".

  I updated the code in the CoverType repositories... it.
  And updated the database it worked....

  I added the CoverType to the UnitOfWork and IUnitOfWork

November 20, 2023

I added the CoverType to the Navbar in the Layout.html.
I added the new controller name CoverType.controller under the Controllers folder.