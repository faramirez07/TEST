using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.ModelMigration
{
    [Table("PolicyClientM")]
   public class PolicyClientM
    {
        [Key]
        public int IdPolicyClient { get; set; }
        public int IdClient { get; set; }
        public int IdPolicy { get; set; }
        public int CoveragePercentage { get; set; }
        public bool Active { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
