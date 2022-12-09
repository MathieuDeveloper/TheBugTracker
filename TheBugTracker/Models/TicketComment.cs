using System.ComponentModel;
using System.Net.Sockets;

namespace TheBugTracker.Models
{
    public class TicketComment
    {

        public int Id { get; set; }

        [DisplayName("Member Comment")]
        public string Comment { get; set; }

        [DisplayName("Date")]
        public DateTimeOffset Created { get; set; }

        //foreign key 
        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        //foreign key 
        // It is a string UserId is a BTUser défini comme string par microsoft
        [DisplayName("Team Member")]
        public string UserId { get; set; }

        //Navigation properties
        public virtual Ticket Ticket { get; set; }

        public virtual BTUser User { get; set; }


    }
}
