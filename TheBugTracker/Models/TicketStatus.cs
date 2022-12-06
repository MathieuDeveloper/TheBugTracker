using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TheBugTracker.Models
{
    public class TicketStatus
    {
        public int Id { get; set; }

        //CF :  [DisplayName("Status Name")]
        [Display(Name = "Status Name")]
        public string Name { get; set; }
    }
}
