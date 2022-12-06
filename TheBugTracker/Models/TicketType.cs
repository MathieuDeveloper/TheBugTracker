using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class TicketType
    {
        public int Id { get; set; }

        //CF :  [DisplayName("Type Name")]
        [Display(Name="Type Name")]
        public string Name { get; set; }
    }
}
