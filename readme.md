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