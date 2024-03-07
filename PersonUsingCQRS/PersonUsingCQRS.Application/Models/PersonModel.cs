using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PersonUsingCQRS.Models
{
    public enum Gender
    {
        None,
        Male,
        Female,
    }
    public class PersonModel
    {
        public Guid Id { get; set; }

        [DefaultValue("")]
        public string? GivenName { get; set; }
        
        [DefaultValue("")]
        public string? Surname { get; set; }

        [DefaultValue(Gender.None)]
        public Gender Gender { get; set; }
        
        [Description("YYYY-MM-DDThh:mm:ssTZD (2007-04-05T12:30:22-02:00)")]
        public DateTime BirthDate { get; set; }

        public string BirthLocation { get; set; }

        [Description("YYYY-MM-DDThh:mm:ssTZD (2007-04-05T12:30:22-02:00)")]
        public DateTime? DeathDate { get; set; }

        public string? DeathLocation { get; set; }

    }
}
