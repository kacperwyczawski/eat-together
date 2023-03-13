using EatTogether.Application.MenuFeature.CreateMenu;
using EatTogether.Contracts.MenuContracts;
using EatTogether.Domain.Features.MenuAggregate;
using Mapster;

namespace EatTogether.WebApi.Mapping;

public class MenuMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(CreateMenuRequest request, string hostId), CreateMenuCommand>()
            .Map(dest => dest.HostId, src => src.hostId)
            .Map(dest => dest, src => src.request);

        config.NewConfig<Menu, CreateMenuResponse>()
            .Map(dest => dest.AverageRating,
                src => src.AverageRating == null ? null : (float?)src.AverageRating);
    }
}