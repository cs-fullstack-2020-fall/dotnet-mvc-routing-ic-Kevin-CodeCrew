using System.Collections.Generic;

namespace Models
{
    public class User
    {
        public int id {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}

        public User() {} // default no arg constructor

        // Main constructor
        public User(int id, string fName, string lName)
        {
            this.id = id;
            this.FirstName = fName;
            this.LastName = lName;
        }

        // Method to generate some test data
        public List<User> sampleData()
        {
            List<User> userList = new List<User>();
            userList.Add(new User(1,"Kevin", "Yancy"));
            userList.Add(new User(10,"Nell", "Yancy"));
            userList.Add(new User(24,"John", "Yancy"));
            return userList;
        }
    }
}