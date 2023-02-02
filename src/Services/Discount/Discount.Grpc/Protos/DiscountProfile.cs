using AutoMapper;
using Discount.Grpc.Entities;

namespace Discount.Grpc.Protos;

public class DiscountProfile : Profile
{
    public DiscountProfile()
    {
        CreateMap<Coupon, CouponModel>().ReverseMap();
    }
}