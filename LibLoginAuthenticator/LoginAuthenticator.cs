namespace LibLoginAuthenticator
{
    public class LoginAuthenticator
    {
        public string Username { get; set; }
        public string Password { get; private set; }

        public LoginAuthenticator()
        {
            Username = null;
            Password = null;
        }

        public bool? Authenticate()
        {
            if (Username == null || Password == null)
                return null;

            if (Username == "john" && Password == "doe")
                return true;

            if (Username == "jane" && Password == "smith")
                return true;
            if (Username == "admin" && Password == "admin")
                return true;
            if (Username == "synvex" && Password == "perfect")
                return true;
            if (Username == "user" && Password == "password")
                return true;
            return false;
        }
        public void SetPassword(string password)
        {
            Password = password;
        }
    }

}
