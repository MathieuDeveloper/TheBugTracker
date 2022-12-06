using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheBugTracker.Models
{
    public class TicketHistory
    {
        //primary key
        public int Id { get; set; }

        //foreign key        
        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        
        [DisplayName("Updated Itemicket")]
        public string Property { get; set; }

        
        [DisplayName("Previous")]
        public string OldValue { get; set; }

        
        [DisplayName("Current")]
        public string NewValue { get; set; }


        [DisplayName("Date Modified")]
        public DateTimeOffset Created { get; set; }


        [DisplayName("Description of Change")]
        public string Description { get; set; }


        //foreign key 
        // It is a string UserId is a BTUser défini comme string par microsoft
        [DisplayName("Team Member")]
        public string UserId { get; set; }

        //Navigation properties
        public virtual Ticket Ticket { get; set; }

        public virtual BTUser User { get; set; }

    }
}
