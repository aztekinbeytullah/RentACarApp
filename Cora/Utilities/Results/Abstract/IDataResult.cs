using Core.Utilities.Abstract.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
