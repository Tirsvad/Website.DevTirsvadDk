// Copyright (c) 2026 Tirsvad and its affiliates. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using Microsoft.Extensions.DependencyInjection;

namespace Tirsvad.Website.DevTirsvadDk.Infrastructure.Data;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureData(this IServiceCollection services)
    {
        _ = services.AddInfrastructure();
        return services;
    }
}
