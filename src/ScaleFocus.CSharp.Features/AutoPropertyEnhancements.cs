using System.Configuration;

namespace ScaleFocus.CSharp.Features
{
    class AutoPropertyEnhancements
    {
        // Initializers
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Doe";

        // Getter Only
        public string Greeting { get; } = "Hello!";

        // More Complex
        public string Config { get; } = ConfigurationManager.AppSettings?["connectionString"] ?? "<none>";


        public AutoPropertyEnhancements(string greeting)
        {
            // The backing field of getter-only auto-property is declared as read-only. 
            // It can be initialized by auto-property initializer or in constructor. 
            // In both cases value is assigned directly to backing field.
            if (greeting != null)
            {
                Greeting = greeting;
            }
        }
    }
}
