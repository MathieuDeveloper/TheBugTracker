using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using System.Security.Policy;

namespace TheBugTracker.Models
{
    public class TicketAttachment
    {
        //primary key
        public int Id { get; set; }

        //foreign key
        [DisplayName("Ticket")]
        public int TicketId { get; set; }

        [DisplayName("File Date")]
        public DateTimeOffset Created { get; set; }


        //foreign key  UserId is design by microsoft Identity as a string, it is user table
        [DisplayName("Team Member")]
        public string UserId { get; set; }

        [DisplayName("File Extension")]
        public string Description { get; set; }


        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [DisplayName("File Name")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        [DisplayName("File Extension")]
        public string FileContentType { get; set; }


        //Navigation properties, based on UserId or TicketId
        public virtual Ticket Ticket { get; set; }
        public virtual BTUser User { get; set; }
    }
}
