using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pars_ConfigurationServices.Data;
using Pars_ConfigurationServices.Models;

namespace Pars_ConfigurationServices.Controllers
{
    [Route("api/schoolsettings")]
    [ApiController]
    public class SchoolSettingsController : ControllerBase
    {
        private readonly SchoolSettingsDbContext _context;

        public SchoolSettingsController(SchoolSettingsDbContext context)
        {
            _context = context;
        }

        [HttpGet("{schoolId}")]
        public async Task<ActionResult<SchoolSettings>> GetSettings(int schoolId)
        {
            var settings = await _context.SchoolSettings.FindAsync(schoolId);

            if (settings == null)
            {
                return NotFound();
            }

            return settings;
        }

    }
}

