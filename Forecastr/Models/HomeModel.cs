using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forecastr.Models
{
    public class HomeModel
    {
        public HomeModel(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}