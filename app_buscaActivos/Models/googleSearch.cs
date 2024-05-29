namespace app_buscaActivos.Models
{
    public class googleSearch
    {

        public class Rootobject
        {
            public Searchparameters searchParameters { get; set; }
            public Knowledgegraph knowledgeGraph { get; set; }
            public Organic[] organic { get; set; }
            public Peoplealsoask[] peopleAlsoAsk { get; set; }
            public Relatedsearch[] relatedSearches { get; set; }
        }

        public class Searchparameters
        {
            public string q { get; set; }
            public string gl { get; set; }
            public string hl { get; set; }
            public bool autocorrect { get; set; }
            public int page { get; set; }
            public string type { get; set; }
        }

        public class Knowledgegraph
        {
            public string title { get; set; }
            public string type { get; set; }
            public string website { get; set; }
            public string imageUrl { get; set; }
            public string description { get; set; }
            public string descriptionSource { get; set; }
            public string descriptionLink { get; set; }
            public Attributes attributes { get; set; }
        }

        public class Attributes
        {
            public string Headquarters { get; set; }
            public string CEO { get; set; }
            public string Founded { get; set; }
            public string Sales { get; set; }
            public string Products { get; set; }
            public string Founders { get; set; }
            public string Subsidiaries { get; set; }
        }

        public class Organic
        {
            public string title { get; set; }
            public string link { get; set; }
            public string snippet { get; set; }
            public Sitelink[] sitelinks { get; set; }
            public int position { get; set; }
            public Attributes1 attributes { get; set; }
            public string date { get; set; }
        }

        public class Attributes1
        {
            public string Products { get; set; }
            public string Founders { get; set; }
            public string Founded { get; set; }
            public string Industry { get; set; }
            public string RelatedPeople { get; set; }
            public string Date { get; set; }
            public string AreasOfInvolvement { get; set; }
        }

        public class Sitelink
        {
            public string title { get; set; }
            public string link { get; set; }
        }

        public class Peoplealsoask
        {
            public string question { get; set; }
            public string snippet { get; set; }
            public string title { get; set; }
            public string link { get; set; }
        }

        public class Relatedsearch
        {
            public string query { get; set; }
        }

    }
}
