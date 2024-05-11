namespace app_buscaActivos.Models
{
    public class Subdominios
    {
        public string scan_date { get; set; }
        public Subdomain[] subdomains { get; set; }
    }

    public class Subdomain
    {
        public string subdomain { get; set; }
        public string ip { get; set; }
        public bool cloudflare { get; set; }
    }
}
