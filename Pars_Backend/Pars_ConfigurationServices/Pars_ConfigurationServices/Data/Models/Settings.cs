using System;
namespace Pars_ConfigurationServices.Data.Models
{
	public class Settings
	{
		public int id { get; set; }
		public string name { get; set; }
		public List<Options> options { get; set; }
	}
}

