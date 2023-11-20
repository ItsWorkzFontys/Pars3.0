using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pars_ConfigurationServices.Models
{
    [Table("SchoolConfigurations")]
    public class SchoolConfiguration
	{
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("schoolId")]
        public int schoolId { get; set; }

        [Column("numberOfStudents")]
        public int numberOfStudents { get; set; }

        [Column("absenceColor")]
        public string absenceColor { get; set; }

        [Column("lateColor")]
        public string lateColor { get; set; }

        [Column("presenceColor")]
        public string presenceColor { get; set; }
    }
}

