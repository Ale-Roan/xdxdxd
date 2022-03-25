using System.ComponentModel.DataAnnotations;

namespace Examen_Unidad_2.Entities
{
    public class Work
    {
        public int Id { get; set; }

        

        public User? User { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public string Tittle { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public int Caterory { get; set; }
        
        public string Content { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Status { get; set; }
        

    }
}
