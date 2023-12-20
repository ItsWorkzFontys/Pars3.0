using System;
using Pars_ConfigurationServices.Data;
using Pars_ConfigurationServices.Models;

namespace Pars_ConfigurationServices.Services
{
	public class ConfigurationService
	{
        private readonly ApplicationDbContext _context;

        public ConfigurationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SchoolConfiguration GetSchoolConfiguration(int schoolId)
        {
            var school = _context.SchoolConfigurations.FirstOrDefault(c => c.schoolId == schoolId);

            if (school != null)
            {
                var schoolData = new SchoolConfiguration
                {
                    id = school.id,
                    schoolId = school.schoolId,
                    numberOfStudents = school.numberOfStudents,
                    absenceColor = school.absenceColor,
                    presenceColor = school.presenceColor,
                    lateColor = school.lateColor
                };

                return schoolData;
            }
            return null;
        }

        public void CreateSchoolConfiguration(SchoolConfiguration schoolConfiguration, int userId)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                throw new Exception("You can't create new school configuration");
            }

            if (schoolConfiguration != null)
            {
                var schoolData = new SchoolConfiguration
                {
                    schoolId = schoolConfiguration.schoolId,
                    numberOfStudents = schoolConfiguration.numberOfStudents,
                    absenceColor = schoolConfiguration.absenceColor,
                    presenceColor = schoolConfiguration.presenceColor,
                    lateColor = schoolConfiguration.lateColor
                };

                _context.Add(schoolData);
                _context.SaveChanges();
            }
        }

        public void DeleteSchoolConfiguration(int userId, int schoolId)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                throw new Exception("You can't delete school configuration");
            }

            var school = _context.SchoolConfigurations.FirstOrDefault(c => c.schoolId == schoolId);

            if (school != null)
            {
                _context.Remove(school);
                _context.SaveChanges();
            }
        }

        public bool UpdateNumberOfStudents(int schoolId, int userId, int newNumOfStudents)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                return false;
            }

            var targetSchool = _context.SchoolConfigurations.FirstOrDefault(s => s.schoolId == schoolId);

            if (targetSchool == null)
            {
                return false;
            }

            targetSchool.numberOfStudents = newNumOfStudents;
            _context.SaveChanges();
            return true;
        }

        public bool UpdateAbsenceColor(int schoolId, int userId, string newAbsenceColor)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                return false;
            }

            var targetSchool = _context.SchoolConfigurations.FirstOrDefault(s => s.schoolId == schoolId);

            if (targetSchool == null)
            {
                return false;
            }

            targetSchool.absenceColor = newAbsenceColor;
            _context.SaveChanges();
            return true;
        }

        public bool UpdatePresenceColor(int schoolId, int userId, string newPresenceColor)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                return false;
            }

            var targetSchool = _context.SchoolConfigurations.FirstOrDefault(s => s.schoolId == schoolId);

            if (targetSchool == null)
            {
                return false;
            }

            targetSchool.presenceColor = newPresenceColor;
            _context.SaveChanges();
            return true;
        }

        public bool UpdateLateColor(int schoolId, int userId, string newLateColor)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                return false;
            }

            var targetSchool = _context.SchoolConfigurations.FirstOrDefault(s => s.schoolId == schoolId);

            if (targetSchool == null)
            {
                return false;
            }

            targetSchool.lateColor = newLateColor;
            _context.SaveChanges();
            return true;
        }

        public bool UpdateSchoolConfiguration(int schoolId, SchoolConfiguration newConfiguration, int userId)
        {
            var isAdmin = _context.AdminPermissions.Any(ap => ap.userId == userId && ap.isAdmin);
            if (!isAdmin)
            {
                return false;
            }

            var existingConfiguration = _context.SchoolConfigurations
                .FirstOrDefault(c => c.schoolId == schoolId);

            if (existingConfiguration == null)
            {
                return false;
            }

            existingConfiguration.numberOfStudents = newConfiguration.numberOfStudents;
            existingConfiguration.presenceColor = newConfiguration.presenceColor;
            existingConfiguration.absenceColor = newConfiguration.absenceColor;
            existingConfiguration.lateColor = newConfiguration.lateColor;

            _context.SaveChanges();
            return true;
        }
    }
}

