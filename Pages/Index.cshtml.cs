using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace qrcode.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [Required(ErrorMessage="informe o conteúdo para o QR Code!")]
    public string ContentQrCode { get; set; } = string.Empty;
    
    public void OnGet()
    {
        
    }
}
