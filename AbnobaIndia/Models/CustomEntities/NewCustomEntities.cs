using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AbnobaIndia.Models
{
    public class NewCustomEntities
    {
    }
    public partial class AdminLoginMaster: BaseEntity
    {
        public int Loginstatus { get; set; }


    }
    public class BaseEntity
    {
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
    }
}