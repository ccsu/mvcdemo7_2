using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo7_2.Models
{
    public class Table1
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "這是必填資訊")]
        public string TString { get; set; }
        public int TInt { get; set; }
        public DateTime TDateTime { get; set; }
        public Boolean TBool { get; set; }
        public int TIntList { get; set; }
    }

    public class DemoDBContext : DbContext
    {
        public DemoDBContext()
            : base("name=DemoDBConnection")
        {
        }

        public DbSet<Table1> Table1s { get; set; }
    }
}