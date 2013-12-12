using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo7_2.Models
{
    public class MultipleQ
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Ans { get; set; }
        public Boolean SelectedAns1 { get; set; }
        public Boolean SelectedAns2 { get; set; }
        public Boolean SelectedAns3 { get; set; }
        public Boolean SelectedAns4 { get; set; }
    }
}
