using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev2_MVC.Models
{
    public class Base
    {
        public string NameSurname { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public DateTime ContractDeadline { get; set; }
        public decimal Height { get; set; }
        public int SportsgearNo { get; set; }
        public string Duty { get; set; }
        public string MatchPosition { get; set; }
    }
}