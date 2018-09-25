using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAngularWebAPI.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string NAME { get; set; }
    }

    public class State
    {
        public int ID { get; set; }
        public int COUNTRY_ID { get; set; }
        public string NAME { get; set; }
    }

    public class City
    {
        public int ID { get; set; }
        public int STATE_ID { get; set; }
        public string NAME { get; set; }
    }
}