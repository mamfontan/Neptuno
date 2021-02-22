namespace Neptuno.Views.domain
{
    public enum LANGUAGE { SPANISH = 0, ENGLISH = 1, FRENCH = 2 }

    public class Configuration
    {
        public LANGUAGE Language { get; set; }

        public string DbHost { get; set; }

        public string DbPort { get; set; }

        public string DbName { get; set; }

        public string DbUser { get; set; }

        public string DbPassword { get; set; }
    }
}
