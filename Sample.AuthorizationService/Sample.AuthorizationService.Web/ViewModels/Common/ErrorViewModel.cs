using System.ComponentModel.DataAnnotations;

namespace Sample.AuthorizationService.Web.ViewModels.Common;

public class ErrorViewModel
{
    [Display(Name = "Error")]
    public string Error { get; set; }

    [Display(Name = "Description")]
    public string ErrorDescription { get; set; }
}

