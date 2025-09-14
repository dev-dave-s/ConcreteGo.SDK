using System.ComponentModel.DataAnnotations;

namespace ConcreteGo.Api.Client.Models.Options
{
    public class ConcreteGoApiOptions
    {
        public const string Section = "ConcreteGoApi";

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "AppId is required")]
        public string AppId { get; set; } = string.Empty;

        [Required(ErrorMessage = "AppKey is required")]
        public string AppKey { get; set; } = string.Empty;

        public string? Slug { get; set; }
    }
}
