
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace AplikasiPembayaranSPP
{
    internal class Helper
    {
        internal static SqlConnection getConnected()
        {
            return new SqlConnection("Data Source=WIN-8OCI4IO48IN;Initial Catalog=DB_UKK_PEMBAYARAN_SPP;Integrated Security=True;");
        }

        internal static List<string> getMonths()
        {
            List<string> months = new List<string>
            {
                "Januari",
                "Februari",
                "Maret",
                "April",
                "Mei",
                "Juni",
                "Juli",
                "Agustus",
                "September",
                "Oktober",
                "November",
                "Desember",
            };
            return months;
        }

        //internal static String hashPass(String plaintext)
        //{
        //    using (var algorithm = SHA256.Create())
        //    {
        //        var bytes = Encoding.UTF8.GetBytes(plaintext);
        //        var hash = algorithm.ComputeHash(bytes);

        //        StringBuilder pass = new StringBuilder();
        //        for (int i = 0; i < hash.Length; i++)
        //        {
        //            pass.Append(hash[i].ToString("X2"));
        //        }
        //        return pass.ToString();
        //    }
        //}
    }
}