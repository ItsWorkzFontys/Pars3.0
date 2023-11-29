using Gateway.Repositories;

namespace Gateway.Services
{
    public class GatewayService
    {
        private readonly IGatewayRepository repository;

        public GatewayService(IGatewayRepository repository) 
        {
            this.repository = repository;
        }

        public void Post()
        {

        }
    }
}
