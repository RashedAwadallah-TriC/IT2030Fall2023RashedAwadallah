## Week 4 Lab - Debugging

##### Summary
###### Tasked with fixing all the errors in the .zip project file given to us, I went and did exactly that. I utilized the Error List window to trace and fix the various syntax errors throughout the project. Once I was finally able to get the server up and running, I fixed able to fix the logic error that gave the wrong tip amounts.
### 
##### Errors
- ###### TipCalculator.cs - no semicolon after ‘return tip’ - added the semicolon
- ###### HomeController.cs - 'HomeController.Index()' did not return a value - added ‘return View();’
- ###### HomeController.cs - typo; ViewBag was spelled Viewbag - capitalized the ‘b’;
- ###### Index.cshtml - typo; ‘ViewBag.Fifteem’ instead of ViewBag.Fifteen - corrected the spelling
- ###### TipCalculator.cs - MealCost.Value was being divided by the tip percent, instead of multiplied - made tip = MealCost.Value * percent;
- ###### site.css - typo; width property was spelled widht - corrected the typo


