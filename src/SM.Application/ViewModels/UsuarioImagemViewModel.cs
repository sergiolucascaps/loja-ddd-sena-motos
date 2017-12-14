using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Required]
        [DisplayName("Imagem")]
        public string Imagem { get; set; } // Refatorar

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
