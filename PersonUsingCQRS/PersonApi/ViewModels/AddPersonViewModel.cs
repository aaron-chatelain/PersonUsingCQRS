using PersonUsingCQRS.Models;
using System.ComponentModel;

namespace PersonUsingCQRS.Controllers.Api.ViewModels
{
    public class AddPersonViewModel
    {
        [DefaultValue("")]
        public string? GivenName { get; set; } = "";
        
        [DefaultValue("")]
        public string? Surname { get; set; } = "";
        public Gender Gender { get; set; } = Gender.None;
       
        [Description("YYYY-MM-DDThh:mm:ssTZD (2007-04-05T12:30:22-02:00)")]
        public DateTime? BirthDate { get; set; }

        [DefaultValue("")]
        public string? BirthLocation { get; set; }

        [Description("YYYY-MM-DDThh:mm:ssTZD (2007-04-05T12:30:22-02:00)")]
        public DateTime? DeathDate { get; set; }

        [DefaultValue("")]
        public string? DeathLocation { get; set; }
    }
}
