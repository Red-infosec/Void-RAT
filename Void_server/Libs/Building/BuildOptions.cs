using Void_server.Controls;

namespace Void_server.Libs
{
    public class BuildOptions
    {
        public bool isSucceded { get; set; }

        public string Password { get; set; }

        public StyledCheckBox[] additionalSettings { get; set; }

        public string[] AssemblyInformation { get; set; }

        public string OutputPath { get; set; }

        public string serverIP { get; set; }

        public string port { get; set; }
    }
}