using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Model.Migration
{
    [Table("ClientM")]
    public class ClientM
    {
        [Key]
        public int IdClient { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public bool Active { get; set; }
        public string UserCreate { get; set; }
        public DateTime DateCreate { get; set; }

    }
}
