﻿namespace Sample.AuthorizationService.Bll.Services;

public interface ISmsSender
{
    Task SendSmsAsync(string number, string message);
}
