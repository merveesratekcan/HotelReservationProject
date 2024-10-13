using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto;

public class CreateNewUserDto
{
    [Required(ErrorMessage = "İsim alanı gereklidir.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Soyisim alanı gereklidir.")]
    public string Surname { get; set; }
    [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Email alanı gereklidir.")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Şifre alanı gereklidir.")]
    public string Password { get; set; }
    [Required(ErrorMessage = "Şifre tekrarı alanı gereklidir.")]
    [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
    public string ConfirmPassword { get; set; }
    public string City { get; set; }
}
