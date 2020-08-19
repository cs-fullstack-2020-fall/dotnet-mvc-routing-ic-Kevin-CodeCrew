using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Models;

namespace mvcroutingpractice.Controllers
{
    public class UserCRUD : Controller
    {
        // Helper method to generate a list of Users string
        private string getUserListString(List<User> userList)
        {
            string results = "";
            foreach (User user in userList)
            {
                // append result as a string
                results += ($"\nUser ID: {user.id}\nFirst Name: {user.FirstName}\nLast Name: {user.LastName}");
            }
            // Return the list from the strings
            return results;
        }

        // Helper method to generate a User string
        private string getUserString(User user)
        {
            return ($"\nUser ID: {user.id}\nFirst Name: {user.FirstName}\nLast Name: {user.LastName}");
        }

        // Get all Users Action
        public IActionResult Users()
        {
            User testUser = new User(); // kludgy dummy data
            List<User> userList = testUser.sampleData();
            return Content(getUserListString(userList));
        }            

        // Get a specific user Action
        public IActionResult User(int id)
        {
            User testUser = new User(); // kludgy dummy data
            List<User> userList = testUser.sampleData();
            int index = userList.FindIndex(user => user.id == id);
            if (index >= 0)
            {
                return Content(getUserString(userList[index]));
            }
            else
            {
                return Content($"User with ID of {id} was not found!");
            }            
        }     

        // Update a specific User
        [HttpPut]
        public IActionResult UpdateUser(int id, string fName, string lName)
        {
            User testUser = new User(); // kludgy dummy data
            List<User> userList = testUser.sampleData();
            int index = userList.FindIndex(user => user.id == id);
            if (index >= 0)
            {
                // Update the User name
                userList[index].FirstName = fName;
                userList[index].LastName = lName;
                return Content($"UPDATED USER:\n{getUserString(userList[index])}");
            }
            else
            {
                return Content($"UPDATE FAILED:\nUser with ID of {id} was not found!");
            }            
        }     

        // Create a new User
        [HttpPost]
        public IActionResult CreateUser(int id, string fName, string lName)
        {
            User newUser = new User(id, fName, lName);
            return Content($"CREATED USER:\n{getUserString(newUser)}");

        }

        [HttpDelete]
        public IActionResult DeleteUser(int id)
        {
            User testUser = new User(); // kludgy dummy data
            List<User> userList = testUser.sampleData();
            int index = userList.FindIndex(user => user.id == id);
            if (index >= 0)
            {
                return Content($"\nDELETED USER:\n{getUserString(userList[index])}");
            }
            else
            {
                return Content($"\nUser with ID of {id} was not found!");
            }            
        }            
    }
}