using Microsoft.AspNetCore.Identity;
using ParsingTestTask.Model;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace ParsingTestTask.Services
{
    public class XmlParserService
    {
        static public Offer ParseOffer(string xmlUrl)
        {
            //for windows1251
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //get xml and list of offers
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xmlUrl);
            XmlNodeList? offers = xDoc.GetElementsByTagName("offer");

            Offer? desOffer = new();
            foreach (XmlElement offer in offers)
            {
                if (offer.GetAttribute("id").ToString() == "12344")
                {

                    XmlSerializer serializer =
                    new XmlSerializer(typeof(Offer));

                    desOffer = new();
                    using (StringReader reader = new StringReader(offer.OuterXml))
                    {
                        desOffer = (Offer)serializer.Deserialize(reader);
                    }
                    desOffer.Category = xDoc.SelectSingleNode($"yml_catalog/shop/categories/category[@id='{desOffer.CategoryId}']").InnerText;
                    break;
                }
            }
            return desOffer;
        }
    }
}
