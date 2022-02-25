﻿using Core.DataAccess.Concrete.EntityFramework;
using RCM.DataAccess.Abstract;
using RCM.DataAccess.Concrete.EntityFramework.Context;
using RCM.Model.Domain;

namespace RCM.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfBranchCaseTypeFlowRepo : EfRepositoryBase<RCMContext, BranchCaseTypeFlow>, IBranchCaseTypeFlowRepo

    {
    }
}
