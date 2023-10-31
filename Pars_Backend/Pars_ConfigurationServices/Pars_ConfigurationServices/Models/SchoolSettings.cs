using System;
namespace Pars_ConfigurationServices.Models
{
	public class SchoolSettings
	{
        public int id { get; set; }
        public int schoolId { get; set; }
        public int maxUsers { get; set; }
        public string absenceColor { get; set; }
        public string presenceColor { get; set; }
        public string lateColor { get; set; }
    }
}

