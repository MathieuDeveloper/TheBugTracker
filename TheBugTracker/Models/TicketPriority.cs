using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class TicketPriority
    {
        public int Id { get; set; }

        //CF :  [DisplayName("Priority Name")]
        [Display(Name= "Priority Name")]
        public string Name { get; set; }
    }
}
