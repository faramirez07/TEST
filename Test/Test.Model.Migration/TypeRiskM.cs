using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Model.Migration
{
    [Table("TypeRiskM")]
    public class TypeRiskM
    {
        [Key]
        public int IdRisk { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
