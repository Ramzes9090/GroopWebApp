namespace GroopWebApp.ExtraCode
{
    public class ExtractUserName
    {
        public static string ExtractUsername(string emailAddress)
        {
            int atIndex = emailAddress.IndexOf('@');
            if (atIndex >= 0)
            {
                return emailAddress.Substring(0, atIndex);
            }
            else
            {
                return emailAddress;
            }
        }
    }
}
