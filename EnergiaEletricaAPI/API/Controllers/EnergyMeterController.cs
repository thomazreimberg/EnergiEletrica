using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnergiaEletricaAPI.Models;
using RestSharp;

namespace EnergiaEletricaAPI.API.Controllers
{
    public class EnergyMeterController
    {
        public List<ClientModel> ModelConverter ()
        {
            RestClient client = new RestClient("https://devmonk-energymeter.herokuapp.com");
            RestRequest request = new RestRequest("EnergyMeter");

            IRestResponse<List<ClientModel>> resp = client.Get<List<ClientModel>>(request);

            List<ClientModel> list = new List<ClientModel>();
            foreach (ClientModel clientModel in resp.Data)
            {
               list.Add(clientModel);
            }

            return list;
        }
    }
}
