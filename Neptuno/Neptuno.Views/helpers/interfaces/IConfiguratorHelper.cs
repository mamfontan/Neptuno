using Neptuno.Views.domain;

namespace Neptuno.Views.helpers
{
    public interface IConfiguratorHelper
    {
        LANGUAGE Language { get; set; }

        string DbHost { get; set; }

        string DbPort { get; set; }

        string DbName { get; set; }

        string DbUser { get; set; }

        string DbPassword { get; set; }

        void SaveConfiguration();
    }
}
