using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T1_GERAL_CASAS.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "El Titulo es obligatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El Tema es obligatorio")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "La Editorial es obligatoria")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El Año de publicacion es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año de publicacion debe estar entre 1900 a 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El numero de paginas es obligatorio")]
        [Range(100, 1000, ErrorMessage = "El numero de paginas debe estar entre 100 a 1000")]
        public int Paginas { get; set; }


        [Required(ErrorMessage = "El numero de copias es obligatorio")]
        [Range(1, 20, ErrorMessage = "El numero de copias debe estar entre 1 a 20")]
        public int Copias { get; set; }


        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion { get; set; }


        [Required(ErrorMessage = "La Categoria es obligatoria")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "El Material es obligatoria")]
        public string Material { get; set; }    
          

    }
}
