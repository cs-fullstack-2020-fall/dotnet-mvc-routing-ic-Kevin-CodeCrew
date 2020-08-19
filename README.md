# Routing In class practice

## Create a simulated CRUD web service

* Start by creating a .NET MVC application `dotnet new mvc -o mvcroutingpractice`
* Create a new Controller called `UserCRUD`
* Create a `User` class with the properties `id`, `FirstName` and `Lastname`
* In the `User` class create a `sampleData` method that adds 3 instances of `User`, adds them to a List, and returns the list
Create action methods specified below

### Read
- Action name `Users`
- HTTP Method `GET`
- Action parameters: none
- Returns the list of sample data users formated using string templates to the browser

### Read (specific user)
- Action name `User`
- HTTP Method `GET`
- Action Parameters: user id
- Return the user from the sample data list with the matching id formatted with string templates OR `User [WHATEVERID] was not found!`

### Update
- Action name `UserUpdate`
- HTTP Method `PUT` with form encoded parameters in body of message
- Action Parameters: user id
- Return the updated user from the list with the matching id formatted with string templates OR `User [WHATEVERID] was not found!` 

### Create
- Action name `UserCreate`
- HTTP Method `POST` with form encoded parameters in body of message
- Action Parameters: none
- Return the the newly created user from the list with the matching id formatted with string templates

### Delete
- Action name `UserDelete`
- HTTP Method `DELETE`
- Action Parameters: user id
- Return the message `User [WHATEVERID] deleted` OR `User [WHATEVERID] was not found!` 

## Create Postman test cases for all actions and add to your repo!

