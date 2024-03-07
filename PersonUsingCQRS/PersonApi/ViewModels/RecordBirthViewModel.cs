using PersonUsingCQRS.Models;
using System.ComponentModel;

namespace PersonUsingCQRS.Controllers.Api.ViewModels
{
    public class RecordBirthViewModel
    {
        [DefaultValue("")]
        public Guid Id { get; set; }

        [Description("YYYY-MM-DDThh:mm:ssTZD (2007-04-05T12:30:22-02:00)")]
        public DateTime? BirthDate { get; set; }

        [DefaultValue("")]
        public string? BirthLocation { get; set; }
    }
}
