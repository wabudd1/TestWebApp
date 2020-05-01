# Notes on Coding Tasks by Marco Costa 5/1/2020
I just wanted to document the process I went through while working on this small coding assignment. I tried to
keep all functions and handling of data as close to what you started. I am very flexible and open to different 
achitectures or styles. So if you are looking for a MVVC pattern as opposed to MVC, I can always be flexible and am
ALWAYS looking for suggestions or criticisms on style and best practices.

I was not 100% sure about how you wanted the mock db to be handled and how permanent you wanted it to be. So please let
me know if you want the data manipulated in a different way and I can attempt to do that. Also, for the sake of getting
things up and running on time, some code is not complete. For example, completely validating input and error handling.

Here are the coding challenge steps I finished:
* Create a View Model 
    * This is a pretty straightforward View to the database. I did not include the "Id" property in the table 
    as normally that would create some security issues.
* Create a submission form to add a new user
    * This part gave me the most trouble as I do not have a ton of experience with partial postbacks. Also, 
    I realize that the way I am handling HTML generation for updating the DOM, but it was the best way I 
    could think of in the time I had. I would love to hear a best practice solution for this.
* Implement a method that returns a Fibonnacci sequence oout to 50 iterations and log output to NLog.
    * This was really straightforward. The log file is in the logs folder with filename: 2020-05-01.log

## I just wanted to say thank you for this opportunity. I enjoyed speaking with you and look forward to the possibility of working together!

# Instructions
* These instructions don't assume you know everything, so skip steps under the Prep section if you feel it appropriate
* Google is your friend, but if you get stuck, feel free to ask questions
* If you do get completely stuck on something, skip it and submit what you *are* able to do

## Prep
* Download and install [Visual Studio 2019 Community](https://visualstudio.microsoft.com/vs/) if you do not already have it
* During installation, select **git for Windows** if you do not already have git installed
* Clone this repository on your local machine, then create a new branch

Windows Powershell:
```powershell
cd %homepath%\Documents # or wherever you feel like putting it
git clone https://github.com/wabudd1/TestWebApp.git
cd TestWebApp
git checkout -b MyBranchName # name the branch whatever you feel like
```

## Coding tasks
* Create a View Model and Display all `User`s and their properties in a `<table>` on a View 
* Create a submission form to add a new user.  The after successful submission, the page
  should display all existing users plus the newly created user
  * Use jQuery to make this an AJAX request that updates the DOM when it returns
* Implement a method that returns a Fibonacci sequence out to 50 iterations, then display
  it on a page using bootstrap layout components
  * Log the complete output of your fibonacci method to NLog at Debug level

## Submission
When you're ready to submit your work, please make sure to save everything in Visual Studio (`Ctrl + Shift + S`).

```powershell
git add -A # to add all changes
git commit -m "my commit message" # write something cool in your commit message
git push -u origin MyBranchName # or whatever you named it
```

Afterwards, go to [Pull Requests](https://github.com/wabudd1/TestWebApp/pulls)
Create a new pull request selecting `master` as the base and `MyBranchName` (or whatever you named it) as the compare.
Click create again, write a comment if you're into that sort of thing, then hit Create Pull Request one final time.