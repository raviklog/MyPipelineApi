namespace MyApi
{
    public class LoginService
    {
        public void Authenticate()
        {
            try
            {
                int x = 5 / 0; // deliberate error
            }
            catch (Exception)
            {
                // Empty catch block - Sonar will flag this
            }
        }
    }
}
