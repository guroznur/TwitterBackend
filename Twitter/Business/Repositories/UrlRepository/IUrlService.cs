using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.UrlRepository
{
    public interface IUrlService
    {
        Task<IResult> Add(Url url);
        Task<IResult> Update(Url url);
        Task<IResult> Delete(Url url);
        Task<IDataResult<List<Url>>> GetList();
        Task<IDataResult<Url>> GetById(int id);
    }
}
