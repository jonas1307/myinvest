﻿using MyInvest.Domain.Entities;
using MyInvest.Domain.Interfaces.Services;

namespace MyInvest.Application
{
    public class TipoInvestimentoAppService : AppServiceBase<TipoInvestimento>
    {
        public TipoInvestimentoAppService(IServiceBase<TipoInvestimento> serviceBase)
            : base(serviceBase)
        { }
    }
}