using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.TweetParameterRepository
{
    public interface ITweetService
    {
        Task<IResult> Add(Tweet tweet);
        Task<IResult> Update(Tweet tweet);
        Task<IResult> Delete(Tweet tweet);
        Task<IDataResult<List<Tweet>>> GetList();
        Task<IDataResult<Tweet>> GetById(int id);
    }
}
