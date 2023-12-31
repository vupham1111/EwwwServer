﻿using Application.Contracts.Driven.Auth0;
using Application.Contracts.Driven.EwwwDb;
using Application.Contracts.Driven.EwwwDb.Repositories;
using Application.Services;
using Application.UseCases;
using Auth0;
using EwwwDb;
using EwwwDb.Repositories;

namespace StartUp;

public static class ApplicationServiceConfig
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        #region database

        services.AddScoped<IEwwwDbCtx>(
            sp => sp.GetRequiredService<EwwwDbCtx>());

        services.AddScoped<IUserRepository, UserRepository>();
        
        #endregion

        #region auth0

        services.AddScoped<IAuth0Driven, Auth0Driven>();

        #endregion

        #region services

        services.AddScoped<IUserService, UserService>();

        #endregion

        #region usecases

        services.AddScoped<IRegisterNewUser, RegisterNewUser>();

        #endregion
    }
}