﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sample.AuthorizationService.Web.ViewModels.Manage;

public class ConfigureTwoFactorViewModel
{
    public string SelectedProvider { get; set; }

    public ICollection<SelectListItem> Providers { get; set; }
}

