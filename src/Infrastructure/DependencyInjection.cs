// Copyright (c) 2026 Tirsvad and its affiliates. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using Microsoft.Extensions.DependencyInjection;

using Tirsvad.Website.DevTirsvadDk.Application;

namespace Tirsvad.Website.DevTirsvadDk.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        _ = services.AddApplication();
        return services;
    }
}
