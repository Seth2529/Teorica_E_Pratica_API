using API.Models.Validation;
using System.ComponentModel.DataAnnotations;

namespace API.Models.Request
{
    public class AlunoViewModel
    {

        public string nome { get; set; }
        [RaValidation]
        public string ra { get; set; }

        public string email { get; set; }

        public string cpf { get; set; }

        public bool ativo { get; set; }

    }
}
