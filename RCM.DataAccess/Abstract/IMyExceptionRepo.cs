using Core.DataAccess.Abstract;
using RCM.Model.Domain;
using System;

namespace RCM.DataAccess.Abstract
{
    public interface IMyExceptionRepo : IRepository<MyException>
    {
    }
}
