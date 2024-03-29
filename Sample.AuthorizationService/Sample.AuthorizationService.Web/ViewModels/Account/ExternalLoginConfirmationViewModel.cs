﻿using System.ComponentModel.DataAnnotations;

namespace Sample.AuthorizationService.Web.ViewModels.Account;

public class ExternalLoginConfirmationViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}
