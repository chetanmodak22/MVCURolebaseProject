using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class MenuAndUserMLst
    {
        public DataTable dtMenus { get; set; }
        public DataTable dtUserM { get; set; }

        public List<UserMaster> UM = new List<UserMaster>();
    }
}