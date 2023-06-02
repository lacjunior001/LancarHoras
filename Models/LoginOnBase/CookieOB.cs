namespace LancarHoras.Models.LoginOnBase
{
    public class CookieOB
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Path { get; set; }
        public string Domain { get; set; }

        public CookieOB()
        {
        }

        public CookieOB(System.Net.Cookie cookie)
        {
            this.Name = cookie.Name;
            this.Value = cookie.Value;
            this.Path = cookie.Path;
            this.Domain = cookie.Domain;
        }
    }
}