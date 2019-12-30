using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iShopOdataWebApi
{
    public class PseudoModel
    {
        public List<DataModel> dataModels { get; set; }
    }
    public class DataModel
    {
        [JsonProperty("_id")]
        public Id Id { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("description")]
        public string[] Description { get; set; }

        [JsonProperty("metadata")]
        public Metadatum[] Metadata { get; set; }

        [JsonProperty("binding")]
        public string Binding { get; set; }

        [JsonProperty("brand", NullValueHandling = NullValueHandling.Ignore)]
        public string Brand { get; set; }

        [JsonProperty("catalognumberlist", NullValueHandling = NullValueHandling.Ignore)]
        public Catalognumberlist Catalognumberlist { get; set; }

        [JsonProperty("ean", NullValueHandling = NullValueHandling.Ignore)]
        public string Ean { get; set; }

        [JsonProperty("esrbagerating", NullValueHandling = NullValueHandling.Ignore)]
        public string Esrbagerating { get; set; }

        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Feature { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Format { get; set; }

        [JsonProperty("genre", NullValueHandling = NullValueHandling.Ignore)]
        public string Genre { get; set; }

        [JsonProperty("hardwareplatform", NullValueHandling = NullValueHandling.Ignore)]
        public string Hardwareplatform { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public long? Price { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("manufacturer", NullValueHandling = NullValueHandling.Ignore)]
        public string Manufacturer { get; set; }

        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        [JsonProperty("mpn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mpn { get; set; }

        [JsonProperty("numberofitems", NullValueHandling = NullValueHandling.Ignore)]
        public long? Numberofitems { get; set; }

        [JsonProperty("operatingsystem", NullValueHandling = NullValueHandling.Ignore)]
        public string Operatingsystem { get; set; }

        [JsonProperty("packagequantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Packagequantity { get; set; }

        [JsonProperty("partnumber", NullValueHandling = NullValueHandling.Ignore)]
        public string Partnumber { get; set; }

        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Platform { get; set; }

        [JsonProperty("productgroup")]
        public string Productgroup { get; set; }

        [JsonProperty("producttypename")]
        public string Producttypename { get; set; }

        [JsonProperty("publisher", NullValueHandling = NullValueHandling.Ignore)]
        public string Publisher { get; set; }

        [JsonProperty("releasedate", NullValueHandling = NullValueHandling.Ignore)]
        public Date Releasedate { get; set; }

        [JsonProperty("studio", NullValueHandling = NullValueHandling.Ignore)]
        public string Studio { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; }

        [JsonProperty("upclist", NullValueHandling = NullValueHandling.Ignore)]
        public Upclist Upclist { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("salesrank")]
        public long Salesrank { get; set; }

        [JsonProperty("department", NullValueHandling = NullValueHandling.Ignore)]
        public string Department { get; set; }

        [JsonProperty("edition", NullValueHandling = NullValueHandling.Ignore)]
        public string Edition { get; set; }

        [JsonProperty("isautographed", NullValueHandling = NullValueHandling.Ignore)]
        public long? Isautographed { get; set; }

        [JsonProperty("ismemorabilia", NullValueHandling = NullValueHandling.Ignore)]
        public long? Ismemorabilia { get; set; }

        [JsonProperty("iseligiblefortradein", NullValueHandling = NullValueHandling.Ignore)]

        public long? Iseligiblefortradein { get; set; }

        [JsonProperty("color", NullValueHandling = NullValueHandling.Ignore)]
        public string Color { get; set; }

        [JsonProperty("isadultproduct", NullValueHandling = NullValueHandling.Ignore)]

        public long? Isadultproduct { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Sku { get; set; }

        [JsonProperty("ceroagerating", NullValueHandling = NullValueHandling.Ignore)]
        public string Ceroagerating { get; set; }

        [JsonProperty("regioncode", NullValueHandling = NullValueHandling.Ignore)]

        public long? Regioncode { get; set; }

        [JsonProperty("publicationdate", NullValueHandling = NullValueHandling.Ignore)]
        public Date Publicationdate { get; set; }

        [JsonProperty("legaldisclaimer", NullValueHandling = NullValueHandling.Ignore)]
        public string Legaldisclaimer { get; set; }

        [JsonProperty("numberofdiscs", NullValueHandling = NullValueHandling.Ignore)]

        public long? Numberofdiscs { get; set; }

        [JsonProperty("warranty", NullValueHandling = NullValueHandling.Ignore)]
        public string Warranty { get; set; }

        [JsonProperty("aspectratio", NullValueHandling = NullValueHandling.Ignore)]
        public string Aspectratio { get; set; }

        [JsonProperty("hazardousmaterialtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Hazardousmaterialtype { get; set; }

        [JsonProperty("mediatype", NullValueHandling = NullValueHandling.Ignore)]
        public string Mediatype { get; set; }

        [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Author { get; set; }

        [JsonProperty("eisbn", NullValueHandling = NullValueHandling.Ignore)]
        public string Eisbn { get; set; }

        [JsonProperty("numberofpages", NullValueHandling = NullValueHandling.Ignore)]
        public long? Numberofpages { get; set; }

        [JsonProperty("isbn", NullValueHandling = NullValueHandling.Ignore)]
        public string Isbn { get; set; }
    }

    public partial class Catalognumberlist
    {
        [JsonProperty("CatalogNumberListElement")]
        public string[] CatalogNumberListElement { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("$oid")]
        public string Oid { get; set; }
    }

    public partial class Images
    {
        [JsonProperty("small")]
        public Large Small { get; set; }

        [JsonProperty("medium")]
        public Large Medium { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }
    }

    public partial class Large
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]

        public long Width { get; set; }

        [JsonProperty("height")]

        public long Height { get; set; }
    }

    public partial class Metadatum
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public dynamic Value { get; set; }
    }

    public partial class ValueClass
    {
        [JsonProperty("CatalogNumberListElement", NullValueHandling = NullValueHandling.Ignore)]
        public string[] CatalogNumberListElement { get; set; }

        [JsonProperty("$date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        [JsonProperty("UPCListElement", NullValueHandling = NullValueHandling.Ignore)]
        public string[] UpcListElement { get; set; }
    }

    public partial class Date
    {
        [JsonProperty("$date")]
        public string DateDate { get; set; }
    }

    public partial class Upclist
    {
        [JsonProperty("UPCListElement")]
        public string[] UpcListElement { get; set; }
    }
}
