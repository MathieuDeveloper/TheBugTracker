using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TheBugTracker.Models
{
    public class ProjectPriority
    {
        //Primary key
        public int Id { get; set; }

        //CF :  [DisplayName("Priority Name")]
        [Display(Name = "Priority Name")]
        public string Name { get; set; }
    }
}
