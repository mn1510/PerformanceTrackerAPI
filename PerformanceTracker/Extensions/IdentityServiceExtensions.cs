﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PerformanceTrackerAPI.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServiceExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"])),
                            ValidateIssuer = false,
                            ValidateAudience = false,
                        };
                    });
            return services;
        }
    }
}
