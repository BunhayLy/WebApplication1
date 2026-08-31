namespace WebApplication1.Models
{
    public class DeploymentCheckViewModel
    {
        public string? ApplicationName { get; set; }

        public string? Version { get; set; }

        public bool BuildPassed { get; set; }

        public bool TestsPassed { get; set; }

        public bool ConfigurationReady { get; set; }

        public bool IsReady =>
            BuildPassed &&
            TestsPassed &&
            ConfigurationReady;
    }
}
