using Newtonsoft.Json;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;

namespace WebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class XmlToJsonService : System.Web.Services.WebService
    {

        [WebMethod]
        public string XmlToJson(string xml)
        {
            try
            {
                XDocument xDoc = XDocument.Parse(xml);

                foreach (XElement xElem in xDoc.Descendants())
                {
                    xElem.RemoveAttributes();
                }

                string json = JsonConvert.SerializeXNode(xDoc, Newtonsoft.Json.Formatting.Indented);

                return json;
            }
            catch (XmlException)
            { }

            return "Bad Xml format";
        }
    }
}
