using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AplikasiPembayaranSPP
{
    internal class LoggedInUser
    {
        public static string IDPetugas = "2";
        public static string NamaPetugas = "hamzah";
        public static string Username = "hamzah";
        public static string Level = "admin";

        public static void DestroySession()
        {
            IDPetugas = string.Empty;
            NamaPetugas = string.Empty;
            Username = string.Empty;
            Level = string.Empty;
        }
    }
}