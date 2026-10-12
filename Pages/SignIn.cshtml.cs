using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PA1Mac.Pages;

public class SignInModel : PageModel
{
    [BindProperty]
    public string Username { get; set; } = "";

    [BindProperty]
    public string Password { get; set; } = "";

    public string Message { get; set; } = "";

    public void OnPost()
    {
        Message = $"Username entered: {Username}. Password entered: {Password}.";
    }
}