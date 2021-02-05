using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP1.Entities
{
    [Table("author_table")]
    public class Author
    {
        private long id;
        private string firstname;
        private string lastname;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("author_id")]
        public long Id { get => id; set => id = value; }

        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
    }
}
