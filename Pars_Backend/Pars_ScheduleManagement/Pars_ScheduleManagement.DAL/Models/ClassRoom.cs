using System.ComponentModel.DataAnnotations;


namespace Pars_ScheduleManagement.DAL.Models
{
    public class ClassRoom
    {
        public Guid ClassRoomId { get; set; }
        public string ?ClassRoomName { get; set; }
        public List<Lesson> ?Lessons { get; set; }
    }
}