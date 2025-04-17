namespace ASC.Web.Configuration
{
    public class ApplicationSettings
    {
        public required string ApplicationTitle { get; set; }

        // Admin Information
        public required string AdminEmail { get; set; }
        public required string AdminName { get; set; }
        public required string AdminPassword { get; set; }

        // User Roles
        public required string Roles { get; set; }

        // Engineer Information
        public required string EngineerEmail { get; set; }
        public required string EngineerName { get; set; }
        public required string EngineerPassword { get; set; }

        // SMTP Configuration
        public required string SMTPServer { get; set; }
        public required int SMTPPort { get; set; }
        public required string SMTPAccount { get; set; }
        public required string SMTPPassword { get; set; }
    }
}
