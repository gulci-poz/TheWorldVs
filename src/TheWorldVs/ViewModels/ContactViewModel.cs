using System;
using System.ComponentModel.DataAnnotations;

namespace TheWorldVs.ViewModels
{
    public class ContactViewModel
    {
        // prop + tab*2
        // walidacja za pomocą anotacji
        // walidacja jakościowa, nie biznesowa
        // będziemy robili walidację po stronie klienta i serwera
        // tutaj mamy po stronie serwera

        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(1024, MinimumLength = 5)]
        public string Message { get; set; }
    }
}
