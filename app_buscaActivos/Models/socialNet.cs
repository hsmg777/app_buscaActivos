namespace app_buscaActivos.Models
{
    public class socialNet
    {
        public class Rootobject
        {
            public string status { get; set; }
            public string request_id { get; set; }
            public Data data { get; set; }
        }

        public class Data
        {
            public string[] facebook { get; set; }
            public string[] instagram { get; set; }
            public string[] twitter { get; set; }
            public string[] linkedin { get; set; }
            public string[] github { get; set; }
            public string[] youtube { get; set; }
            public string[] pinterest { get; set; }
            public string[] tiktok { get; set; }
            public string[] snapchat { get; set; }
        }
    }
}
