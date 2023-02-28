using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ParsingTestTask.Model;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using ParsingTestTask.Services;

namespace ParsingTestTask.Pages
{
    public class IndexModel : PageModel
    {
        DBService db;
        public Offer offer { get; set; } = new Offer();

        public IndexModel(DBService db)
        {
            this.db = db;
        }

        public void OnGet()
        {            
            if (!db.CheckOffer())
            {   //If offer is missing 
                //Get xml and add in db
                Offer? temp = new();
                temp = XmlParserService.ParseOffer("http://partner.market.yandex.ru/pages/help/YML.xml");

                db.AddOffer(temp);
            }

            offer = db.GetOffer();
        }
    }
}
