using System.ComponentModel.DataAnnotations;

namespace Gateway.Dtos
{
    public class GatewayDto
    {
        [Key]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Role { get; set; }
        public string Page { get; set; }
        public float ResponseTime { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
    }
}
