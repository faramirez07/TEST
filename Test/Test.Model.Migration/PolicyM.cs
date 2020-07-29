using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Test.Model.Migration
{
    [Table("PolicyM")]
    public class PolicyM
    {
        [Key]
        public int IdPolicy { get; set; }
        public string TypePolicy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string TypeRisk { get; set; }

        public bool Active { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }

    }
}
