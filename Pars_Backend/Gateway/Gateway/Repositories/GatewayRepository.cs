using Gateway.Context;
using Gateway.Dtos;
using Gateway.Services;

namespace Gateway.Repositories
{
    public class GatewayRepository : IGatewayRepository
    {
        private readonly GatewayDbContext context;

        public GatewayRepository(GatewayDbContext context)
        {
            this.context = context;
        }

        public void Post()
        {
            GatewayDto gatewayDto = new GatewayDto();
            gatewayDto.Timestamp = DateTime.Now;
            gatewayDto.Role = "teacher";
            gatewayDto.Page = "";
            gatewayDto.ResponseTime = 0.2f;
            gatewayDto.ErrorCode = 404;
            gatewayDto.ErrorDescription = "Not found";
            context.GatewayDb.Add(gatewayDto);
            context.SaveChanges();
        }
    }
}
