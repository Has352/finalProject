using System.ComponentModel.DataAnnotations;

namespace asp.net_Project.Models
{
    public class StepsModel
    {
        public int stepsNum { get; set; }

        [Key]
        public DateTime dates { get; set; }
    }
}
