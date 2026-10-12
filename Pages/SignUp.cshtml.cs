using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PA1Mac.Pages;

public class SignUpModel : PageModel
{
    [BindProperty]
    public string FullName { get; set; } = "";

    [BindProperty]
    public string Email { get; set; } = "";

    [BindProperty]
    public int Age { get; set; }

    [BindProperty]
    public string ProfileDescription { get; set; } = "";

    public string Message { get; set; } = "";

    public void OnPost()
    {
        Message =
            $"Name: {FullName}. Email: {Email}. Age: {Age}. " +
            $"Description: {ProfileDescription}";
    }
}