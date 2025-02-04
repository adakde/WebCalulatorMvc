using System.ComponentModel.DataAnnotations;

namespace WebCalulatorMvc.Models
{
    public class CalculationHistory
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Expression { get; set; }
        public string Result { get; set; }
        public DateTime? Date { get; set; }
    }
}
