using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pars_ConfigurationServices.Models
{
    [Table("AdminPermission")]
    public class AdminPermission
	{
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("userId")]
        public int userId { get; set; }

        [Column("isAdmin")]
        public bool isAdmin { get; set; }
    }
}

