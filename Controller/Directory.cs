namespace Controller
{
    public class Directory
    {
        public static string Administrators = System.IO.Path.GetFullPath("./") + "Config/Administrators.xml";
        public static string Clients = System.IO.Path.GetFullPath("./") + "Config/Clients.xml";
        public static string Reservations = System.IO.Path.GetFullPath("./") + "Config/Reservations.xml";
    }
}