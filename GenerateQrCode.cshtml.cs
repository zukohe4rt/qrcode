using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace qrcode.Pages;

public class GenerateQrCode : PageModel
{
    private readonly ILogger<GenerateQrCode> _logger;

    public GenerateQrCode(ILogger<GenerateQrCode> logger)
    {
        _logger = logger;
    }

    [Required(ErrorMessage="Favor informar o conteúdo do QR Code!")]
    public string ContentQrCode { get; set; } = string.Empty;
    
    public void OnGet()
    {
        
    }
}