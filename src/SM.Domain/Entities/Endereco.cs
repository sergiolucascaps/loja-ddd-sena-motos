using System;

namespace SM.Domain.Entities
{
    public class Endereco
    {
        public Endereco()
        {
            Idf_Endereco = Guid.NewGuid();
        }
        public Guid     Idf_Endereco        { get; set; }
        public string   Nme_Endereco        { get; set; }
        public string   Des_Logradouro      { get; set; }
        public string   Des_Numero          { get; set; }
        public string   Des_Complemento     { get; set; }
        public string   Des_Bairro          { get; set; }
        public string   Num_Cep             { get; set; }
        public string   Des_Cidade          { get; set; }
        public string   Des_Estado          { get; set; }
        public DateTime Dta_Cadastro        { get; set; }
        public DateTime? Dta_Alteracao       { get; set; }
        public Guid     Idf_Contato         { get; set; }

        public virtual Contato Contato      { get; set; }
    }
}
