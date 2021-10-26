using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DoctorClinica.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Paciente
    {

        [DisplayName("Cadastro de Paciente")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [DisplayName("Nome Completo")]
        [MinLength(5, ErrorMessage = "Preencha nome completo")]
        [MaxLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [DisplayName("CPF")]
        [MinLength(11, ErrorMessage = "Dado incorreto")]
        public int CPF { get; set; }

        [DisplayName("Endereço")]
        public string Endereço { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Profissao")]
        public string Profissao { get; set; }

        [DisplayName("Telefone")]
        public int Telefone { get; set; }

        [Required(ErrorMessage = "Data obrigatoria")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
    }
    
}

