﻿using BussinesLayer.Repositories.Core;
using Common.Models.BuyCartDetails;
using DataLayer.ViewModels.BuyCartDetails;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinesLayer.Interfaces.BuyCartDetails
{
    public interface IBuyCartDetailsService : IRepository<BuyCartDetail, BuyCartDetailViewModel>
    {
        public Task<IEnumerable<BuyCartDetail>> GetUserCartDetail(int id);

    }
}
