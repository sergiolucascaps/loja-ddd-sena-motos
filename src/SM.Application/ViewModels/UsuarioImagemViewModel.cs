using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SM.Application.ViewModels
{
    public class UsuarioImagemViewModel
    {
        public UsuarioImagemViewModel()
        {
            Idf_Imagem = Guid.NewGuid();
        }

        [Key]
        public Guid Idf_Imagem { get; set; }
        
        [DisplayName("Imagem")]
        public string Imagem { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime Dta_Cadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? Dta_Alteracao { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public Guid Idf_Usuario { get; set; }
    }
}
