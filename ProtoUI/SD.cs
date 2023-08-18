using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoUI
{
    internal class SD
    {
        public static string TIN { get; } = "999005581";
        public static string BranchID { get;} = "00";
        public static string DeviceSeiralNo { get;} = "mertechrwarvsdctest";
        public static string LastRequestDate { get; set; } = DateTime.Now.ToString("yyyyMMddhhmmss");


        public static string RegistrantName { get;  } = "Admin";
        public static string RegistrantID { get; } = "Admin";
        public static string ModifierName { get; } = "Admin";
        public static string ModifierID { get;  } = "Admin";
    }
}
