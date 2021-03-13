namespace Project
{
    /* Student Id: 92060016
    * Name: Dan Hayworth
    * Date: 15-03-2021
    */

    //create a class model for staff users
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Users(int id, string username, string password, string email)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }
    }
}
