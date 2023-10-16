namespace Profiles;

using AutoMapper;
using Dtos.Outgoing;
using Models;

public class AverageScoreResolver : IValueResolver<Product, ProductInfo, int>
{
    public int Resolve(Product source, ProductInfo destination, int destMember, ResolutionContext context)
    {
        int count = 0;
        int total = 0;

        foreach (var r in source.Reviews)
        {
            count++;
            total += r.Score;
        }

        return count != 0 ? total / count : 0;
    }
}

public class _AverageScoreResolver : IValueResolver<Product, ProductDetail, int>
{
    public int Resolve(Product source, ProductDetail destination, int destMember, ResolutionContext context)
    {
        int count = 0;
        int total = 0;

        foreach (var r in source.Reviews)
        {
            count++;
            total += r.Score;
        }

        return count != 0 ? total / count : 0;
    }
}