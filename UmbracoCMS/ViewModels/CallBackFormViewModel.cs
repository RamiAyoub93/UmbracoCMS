using System.ComponentModel.DataAnnotations;

namespace UmbracoCms.ViewModels
{
    public class CallBackFormViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = null!;


        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Please select an option")]
        public string SelectedOption { get; set; } = null!;

    }
}
