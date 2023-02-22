
using System;
using System.Data.SqlClient;

namespace AplikasiPembayaranSPP
{
    internal class Helper
    {
        internal static SqlConnection getConnected()
        {
            return new SqlConnection("Data Source=WIN-8OCI4IO48IN;Initial Catalog=DB_UKK_PEMBAYARAN_SPP;Integrated Security=True;");
        }
    }
}