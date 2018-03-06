using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModels; 

namespace ManagerDesk.ViewModels
{
    public class ConfigViewModel
    {
        public HttpPostedFileBase Image { get; set; }

        public Config Config { get; set; }
    }
}