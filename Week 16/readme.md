## Week 16 Lab

### The Three Things I Learned in my ASP .NET Web Programming Class
1. I learned what "Scaffolding" is - a quick set-up skeleton for a particular feature. Specifically, we scaffolded CRUD pages and the database itself through the data model.
2. I learned that ASP .NET prefers to have a "hidden" plain C# file underneath its .cshtml counterpart. This was a little different than what I was used to with React.
3. I learned that programming in ASP .NET isn't that much different from programming in JavaScript. The concepts transfer from one to the other and I was able to quickly pick up on a ton of things due to my experience with JavaScript libraries and frameworks. Learn Once, Apply Everywhere.

### Three Features to Improve the App
1. Add a "Returns" page - where customers can go to return their product
2. Add a "Vendor" page for CUSTOMERS to sell their product
3. Add a "Vendor" page for COMPANIES to sell their product

There would be a difference between a customer selling something and a company/organization selling something. They'd have to go through different processes and their would be a lot more vetting for the company.

### The "Return Page" Feature
I coded a simple page for returning products. It's a form that the customer fills out - including information about themselves and the product they'd like to return.

Changes in the code surrounded by comments in the following files.
- _Layout.cshtml
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Views\Shared\_Layout.cshtml
- HomeController.cs
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Controllers\HomeController.cs
- Returns.cshtml
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Views\Home\Returns.cshtml
- ReturnModel.cs
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Models\ReturnModel.cs

### The Four Style Updates
1. Changed the max width for the product images on the 'ListProducts' page to 200px by 250px
2. Changed the order so that the product image on the 'Detail' page is at the bottom. Also changed max width for the product image to 320px by 400px
3. Changed the color of the h1 on both the product list page and detail page
4. Centered the entire Events Page

All changes can be found in the following files.
- custom.css
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\wwwroot\css\custom.css
- ListProducts.cshtml
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Views\Product\ListProducts.cshtml
- Detail.cshtml
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Views\Product\Detail.cshtml
- Events.cshtml
    - D:\School Stuff\IT2030\IT2030_Fall2023_RashedAwadallah\Week 16\RashedApparel\Views\Home\Events.cshtml 
