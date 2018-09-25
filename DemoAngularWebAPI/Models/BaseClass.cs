using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAngularWebAPI.Models
{
    public class BaseClass
    {
        public string CREATED_BY { get; set; }
        public DateTime CREATED_DATE { get; set; }
        public string MODIFIED_BY { get; set; }
        public DateTime MODIFIED_DATE { get; set; }
        public bool IS_ACTIVE { get; set; }
    }
}