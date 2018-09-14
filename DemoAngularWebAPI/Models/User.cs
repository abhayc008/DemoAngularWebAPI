using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAngularAPI.Models
{
    public class User :  BaseClass
    {
        public Int32 USER_ID { get; set; }
        public string USER_CODE { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string FULL_NAME { get { return FIRST_NAME +" "+ LAST_NAME; } }
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public string TOKEN { get; set; }
    }
}