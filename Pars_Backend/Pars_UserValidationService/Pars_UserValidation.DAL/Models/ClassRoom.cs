using System.ComponentModel.DataAnnotations;


namespace Pars_UserValidation.DAL.Models
{
    public class ClassRoom
    {
        public Guid ClassRoomId { get; set; }
        public string ?ClassRoomName { get; set; }
        public List<Lesson> ?lessons { get; set; }
    }
}