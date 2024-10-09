using System.ComponentModel.DataAnnotations;

namespace Praktyki2024.stronainternetowa.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [StringLength(100, ErrorMessage = "Imię nie może być dłuższe niż 100 znaków.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Proszę podać poprawny adres e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wiadomość nie może być pusta.")]
        [StringLength(1000, ErrorMessage = "Wiadomość nie może być dłuższa niż 1000 znaków.")]
        public string Message { get; set; }
    }
}
