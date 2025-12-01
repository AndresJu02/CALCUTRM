using System;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CALCUTRM.SERVICE
{
    public class TrmService
    {
        public async Task<decimal> GetTRMAsync()
        {
            string url = "https://www.superfinanciera.gov.co/SuperfinancieraWebServiceTRM/TCRMServicesWebService/TCRMServicesWebService";

            string soap = $@"<?xml version=""1.0"" encoding=""utf-8""?>
            <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/""
                              xmlns:ws=""http://action.trm.services.generic.action.superfinanciera.nexura.sc.com.co/"">
                <soapenv:Header/>
                <soapenv:Body>
                    <ws:queryTCRM>
                        <tcrmQueryAssociatedDate>{DateTime.Now:yyyy-MM-dd}</tcrmQueryAssociatedDate>
                    </ws:queryTCRM>
                </soapenv:Body>
            </soapenv:Envelope>";

            using (var client = new HttpClient())
            {
                var content = new StringContent(soap, Encoding.UTF8, "text/xml");
                content.Headers.Add("SOAPAction", "");

                var response = await client.PostAsync(url, content);
                string result = await response.Content.ReadAsStringAsync();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(result);

                XmlNode valueNode = xml.SelectSingleNode("//*[local-name()='value']");

                if (valueNode == null)
                    throw new Exception("No se encontró el nodo <value> en la respuesta SOAP.\n" + result);

                return decimal.Parse(valueNode.InnerText, CultureInfo.InvariantCulture);
            }
        }
    }
}
