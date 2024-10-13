using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto;

public class LoginUserDto
{
    [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
    public string Username { get; set; }
    [Required(ErrorMessage = "Şifre alanı gereklidir.")]
    public string Password { get; set; }
   
}
