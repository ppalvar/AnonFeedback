namespace Profiles;

using AutoMapper;
using Dtos.Incoming;
using Dtos.Outgoing;
using Models;

public class ReviewProfile : Profile
{
    public ReviewProfile()
    {
        CreateMap<Review, ReviewInfo>()
            .ForMember(
                dest => dest.Score,
                src => src.MapFrom(opt => opt.Score)
            )
            .ForMember(
                dest => dest.Comment,
                src => src.MapFrom(opt => opt.Comment)
            )
            .ForMember(
                dest => dest.Date,
                src => src.MapFrom(opt => opt.Date)
            );
        
        CreateMap<NewReviewRequest, Review>()
            .ForMember(
                dest => dest.Score,
                src => src.MapFrom(opt => opt.Score)
            )
            .ForMember(
                dest => dest.Comment,
                src => src.MapFrom(opt => opt.Comment)
            )
            .ForMember(
                dest => dest.Date,
                src => src.MapFrom(opt => DateTime.Now)
            )
            .ForMember(
                dest => dest.ProductId,
                src => src.MapFrom(opt => opt.ProductId)
            );
    }
}