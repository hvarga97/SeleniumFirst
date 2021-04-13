# SeleniumFirst
Beginner's testing project with Selenium in C#

**Documentation  **
  
For Selenium with C#, I have used a tutorial from Execute Automation.   
  
**The first video** was about the difference between Selenium with Java and Selenium with C#.   

**The second video** was a quick guide on how to implement Selenium into the C# project, I have used the method which included right-clicking the references in Solution Explorer and selecting NuGet Packages. There I just selected Selenium web driver and Chrome web driver to install and implement into my project.  

**The third video** was writing a simple program. Firstly, I created the reference for the browser, then I navigated to the google page and I found the element that I want to interact with. The element I interact with was the search bar which was called q and I wrote the code to enter “executeautomation” into the search bar. Finally, I closed the driver.  

**The fourth video** was about NUnit. First, I had to add NUnit Test Adaptor by selecting Tools in the menu and clicking on extensions and updates. Then once again I had to add a reference for NUnit by opening NuGet Packages and installing NUnit. After that, I separated the code into initialization, execution test and cleanup. The initialization had the driver navigation to google website, the execution test was finding the element and typing into google search “executionautomation” and the cleanup section was just closing a driver. After that to run the test, I had to mark parts of code for the test to know which part to test with [test], the part that was needed for the test (Initialization) with [SetUp] and the part with closing driver (CleanUp) with [TearDown]. Then testing the solution was automatic, and to see the output I wrote Console.WriteLine in every part to know what is going on. I have also added another test called NextTest to see how it works despite the first test, and the conclusion is that the tests can be tested separately.  

**The fifth video** is about custom methods for controls. I have created a separate class file called Selenium Set Methods. The purpose of the file is to write methods and just call the function when we need to enter text, click a button or select a dropbox. All three of those activities was defined just by Id and Name. For the method to enter a text I needed to know the driver, also the element of interest, the value which would be set and the element type or the attribute that I selected. The click and select a dropdown method were made similarly. In the main program, I have just called the methods that I’ve written in the class file and entered the values that will be changed. The website I used to test all the common actions like entering text, clicking a button and selecting something from the dropdown list, is a demo site from executeautomation.com. 

**The sixth video** was about getting the value from the text boxes, dropdown menu and checkboxes. I created a new class file called SeleniumGetMethod in which I defined the way to get the text from the text box and the way to get the value from the selected item in the drop-down list.  

**The seventh video** was about making the methods more useable. I created a PropertiesCollection class that holds the driver instance so every time I have to call I driver when using a method, I don’t need to pass the driver instance. Similarly, I have created an Enum for types of elements so when calling a method, I don’t need to worry if the type of the element is written correctly.  

**The eighth video** was about the Page Object Model or POM. I created another class which is a collection of web elements that I am interacting with, that class is crated because if a web element is changed on the web site, I don’t have to change every line of code that is using that particular web element, rather I change one line of code in EAPageObject class. 

**The ninth video** was about page navigation. I created a class that is just for the login page, and when the program fills the text boxes and hits login the program navigates to another site that is another class. In EAPageObject I just created a simple method that will fill the user form... In this video I encountered the first problem, the guy in the video said that there is no difference between button click and button submit, but I found that if I used button click the driver couldn't read element name from the website, and when I changed to submit everything worked. 

**The tenth video** is about customizing the get and set methods class to reduce code and make it more functional. 

**The eleventh video** is about extended methods. Using “this” when passing the IWebElement in getting and get methods I made an extended method that can be used in classes like LoginPageObject of EAPageObject without passing the IWebElement. 

**The twelfth video** is about reading data from an excel table. I created a class called ExcelLib and this class contained all the necessary methods to open an excel sheet, to read the data etc. The biggest problem here was that class IExcelDataReader was updated and removed the option IsFirstRowAsColumnName. Because of that change, I found the solution in forums and changed the code with AsDataSet, which worked the same way. The other problem I accounted for was in reading the cell information in the excel sheet. The problem was that when using for loop and passing through columns the maximum count of columns was 5, but the indexing started at 0, so when the program wasted to read the cell in the fifth column an error popped that the fifth column could not be found. The problem was fixed with the condition in for loop.  
 

The overall thought after working with Selenium in C# is that the implementation was easy, and working with it was not that hard. The only problems I accounted was the problems because of version change for Selenium as well as VisualStudio. Others were logic-based and I haven't spent a lot of time figuring them out.
