using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Application.ViewModels
{
    public class UsuarioUsuarioImagemViewModel
    {
        public UsuarioUsuarioImagemViewModel()
        {
            Idf_Usuario = Guid.NewGuid();
            //Idf_Imagem = Guid.NewGuid();
        }

        #region UsuarioViewModel

        [Key]
        public Guid Idf_Usuario { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        [MaxLength(150, ErrorMessage = "Máximo {1} caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {1} caracteres.")]
        [DisplayName("Nome")]
        public string Nme_Usuario { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        [MaxLength(11, ErrorMessage = "Máximo {1} caracteres.")]
        [DisplayName("CPF")]
        public string Num_Cpf { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        [MaxLength(150, ErrorMessage = "Máximo {1} caracteres.")]
        [DisplayName("E-mail")]
        public string Eml_Usuario { get; set; }

        [ScaffoldColumn(false)]
        public bool Flg_Inativo { get; set; }

        [Required(ErrorMessage = "Campo {0} obrigatório.")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Des_Senha { get; set; }

        [Required(ErrorMessage = "{0} obritarória.")]
        [DisplayName("Confirmação de Senha")]
        [DataType(DataType.Password)]
        [Compare("Des_Senha", ErrorMessage = "As senhas não coincidem.")]
        public string Des_Senha_Confirm { get; set; }

        [DisplayName("Senha Hash")]
        public string Des_Senha_Hash { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        //[DisplayFormat(ApplyFormatInEditMode = true)]
        [DataType(DataType.Date, ErrorMessage = "Formato inválido.")]
        [DisplayName("Data de Nascimento")]
        public DateTime Dta_Nascimento { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public DateTime Dta_Cadastro { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? Dta_Alteracao { get; set; }

        #endregion

        #region UsuarioImagemViewModel

        //[Key]
        //public Guid Idf_Imagem { get; set; }

        [DisplayName("Imagem")]
        public string Imagem { get; set; } 
        
        #endregion
    }
}
