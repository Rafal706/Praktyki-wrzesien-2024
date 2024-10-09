using System.ComponentModel.DataAnnotations;

namespace Praktyki2024.stronainternetowa.Models
{
    public class OpinionFormModel
    {
        [Required(ErrorMessage = "Imię jest wymagane.")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Adres e-mail jest wymagany.")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adres e-mail.")]
        [Display(Name = "Adres E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ocena jest wymagana.")]
        [Range(1, 5, ErrorMessage = "Ocena musi być w zakresie od 1 do 5.")]
        [Display(Name = "Ocena (1-5)")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Opinia jest wymagana.")]
        [StringLength(500, ErrorMessage = "Opinia nie może mieć więcej niż 500 znaków.")]
        [Display(Name = "Opinia")]
        public string Opinion { get; set; }

        [StringLength(1000, ErrorMessage = "Komentarz nie może mieć więcej niż 1000 znaków.")]
        [Display(Name = "Komentarze/Wskazówki")]
        public string AdditionalComments { get; set; }
    }
}
