﻿using EatTogether.Application.AuthenticationFeature.Common;
using EatTogether.Contracts.AuthenticationContracts;
using Mapster;

namespace EatTogether.WebApi.Mapping;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Token, src => src.Token)
            .Map(dest => dest, src => src.User);
    }
}