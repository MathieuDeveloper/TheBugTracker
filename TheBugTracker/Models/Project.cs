using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }


        [DisplayName("Company")]
        public int ConmpanyId { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Description")]
        public string Description { get; set; }


        [DataType(DataType.Date)]
        [DisplayName("Start")]
        public DateTimeOffset StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("End")]
        public DateTimeOffset EndDate { get; set; }

        //Foreign key
        [DisplayName("Project Priority")]
        public int ProjectPriorityId { get; set; }

        //image
        [NotMapped]
        [DataType(DataType.Upload)]
        public IFormFile FormFile { get; set; }

        [DisplayName("File Name")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }

        [DisplayName("File Extension")]
        public string FileContentType { get; set; }

        [DisplayName("Archived")]
        public bool Archived { get; set; }


        //Navigation properties, pluriel ou singulier ?

        public virtual Company Company { get; set; }
        public virtual ProjectPriority ProjectPriority { get; set; }
        public  virtual Member Members { get; set; }
        public virtual Ticket Tickets { get; set; }

    }
}
