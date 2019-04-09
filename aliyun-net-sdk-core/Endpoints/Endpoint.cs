namespace Aliyun.Acs.Core.Endpoints
{
    public class Endpoint
    {
        private string product;
        private string regionId;
        private string domain;

        public Endpoint(string product, string regionId, string domain)
        {
            this.product = product;
            this.regionId = regionId;
            this.domain = domain;
        }

        public string GetDomain()
        {
            return this.domain;
        }
    }
}
