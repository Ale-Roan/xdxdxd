using System.ComponentModel.DataAnnotations;

namespace Examen_Unidad_2.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(70, ErrorMessage = "Max length in {0} is {1} caracters.")]
        [MinLength(5, ErrorMessage = "Min Length in {0} is 5 caracters.")]
        public string Name { get; set; }

        public List<Work>? Works { get; set; }
    }
}
