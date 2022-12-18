using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBugTracker.Models
{
    public class Project
    {
        //primary key
        public int Id { get; set; }


        [DisplayName("Company")]
        public int? ConmpanyId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Description")]
        public string Description { get; set; }



        [DisplayName("Start")]
        public DateTimeOffset StartDate { get; set; }


        [DisplayName("End")]
        public DateTimeOffset EndDate { get; set; }

        //Foreign key
        [DisplayName("Project Priority")]
        public int ProjectPriorityId { get; set; }

        //image
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile ImageFormFile { get; set; }

        [DisplayName("File Name")]
        public string ImageFileName { get; set; }
        public byte[] ImageFileData { get; set; }

        [DisplayName("File Extension")]
        public string ImageContentType { get; set; }

        [DisplayName("Archived")]
        public bool Archived { get; set; }


        //Navigation properties

        public virtual Company Company { get; set; }
        public virtual ProjectPriority ProjectPriority { get; set; }
        public virtual ICollection<BTUser> Members { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

        //Mathieu:
        //public virtual ICollection<BTUser> Members { get; set; } = new HashSet<BTUser>();
        //public virtual ICollection<Ticket> Tickets { get; set; } = new HashSet<Ticket>();




    }
}
