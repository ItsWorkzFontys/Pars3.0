using Gateway.Context;
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

        }
    }
}
