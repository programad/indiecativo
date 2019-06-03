﻿using IndieVisible.Domain.Interfaces.Repository;
using IndieVisible.Domain.Models;
using IndieVisible.Infra.Data.Context;

namespace IndieVisible.Infra.Data.Repository
{
    public class FeaturedContentRepository : Repository<FeaturedContent>, IFeaturedContentRepository
    {
        public FeaturedContentRepository(IndieVisibleContext context) : base(context)
        {

        }
    }
}
