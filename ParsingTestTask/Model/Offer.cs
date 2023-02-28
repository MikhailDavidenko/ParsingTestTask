using System.Xml.Serialization;

namespace ParsingTestTask.Model
{
    [XmlRoot(ElementName = "offer")]
    public class Offer
    {
        public int Id { get; set; }
        [XmlElement(ElementName = "url")]
        public string? Url { get; set; }

        [XmlElement(ElementName = "price")]
        public int? Price { get; set; }

        [XmlElement(ElementName = "currencyId")]
        public string? CurrencyId { get; set; }

        [XmlElement(ElementName = "categoryId")]
        public string? CategoryId { get; set; }

        [XmlElement(ElementName = "picture")]
        public string? Picture { get; set; }

        [XmlElement(ElementName = "delivery")]
        public bool Delivery { get; set; }

        [XmlElement(ElementName = "artist")]
        public string? Artist { get; set; }

        [XmlElement(ElementName = "title")]
        public string? Title { get; set; }

        [XmlElement(ElementName = "year")]
        public int? Year { get; set; }

        [XmlElement(ElementName = "media")]
        public string? Media { get; set; }

        [XmlElement(ElementName = "description")]
        public string? Description { get; set; }

        public string? Category { get; set; } = "";

        public override string ToString()
        {
            return Url;
        }
    }
}
