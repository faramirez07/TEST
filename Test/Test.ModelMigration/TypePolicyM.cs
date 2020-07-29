using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.ModelMigration
{
    [Table("TypePolicyM")]
    public class TypePolicyM
    {
        [Key]
        public int IdPolicy { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
