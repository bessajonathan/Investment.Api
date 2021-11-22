using Investment.Core.Interfaces;
using Investment.Core.Providers.Bc.Response;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Investment.Core.Providers.Bc
{
    public class BcProvider:IBcProvider
    {
        private readonly ILogger<BcProvider> _logger;

        public BcProvider(ILogger<BcProvider> logger)
        {
            _logger = logger;
        }
        public async Task<BcResponse> GetDeposit()
        {
            var client = new RestClient("https://bcUrl.gov.com.br/sbp/events");

            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "key=323423asdas}");
            request.AddParameter("application/json; charset=utf-8", null, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;

            try
            {
                var bcResponse = await client.ExecuteAsync(request);

                if (bcResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<BcResponse>(bcResponse.Content);
                }

            }
            catch(Exception ex)
            {
                _logger.LogError("Errodeintegração com o Banco central", ex);
                return null;
            }

            return null;
        }
    }
}
