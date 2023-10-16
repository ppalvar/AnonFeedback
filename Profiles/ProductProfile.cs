namespace Profiles;

using AutoMapper;
using Dtos.Outgoing;
using Google.Protobuf.WellKnownTypes;
using Models;

public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<Product, ProductInfo>()
            .ForMember(
                dest => dest.Score,
                src => src.MapFrom<AverageScoreResolver>()
            )
            .ForMember(
                dest => dest.Name,
                src => src.MapFrom(opt => opt.Name)
            );

        CreateMap<Product, ProductDetail>()
            .ForMember(
                dest => dest.Score,
                src => src.MapFrom<_AverageScoreResolver>()
            )
            .ForMember(
                dest => dest.Name,
                src => src.MapFrom(opt => opt.Name)
            )
            .ForMember(
                dest => dest.Description,
                src => src.MapFrom(opt => opt.Description)
            );
    }
}