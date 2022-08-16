using Core.DataAccess.EntityFramework;
using DataAccess.Context.EntityFramework;
using Entities.Concrete;


namespace DataAccess.Repositories.TweetRepository
{
    public class EfTweetDal : EfEntityRepositoryBase<Tweet,SimpleContextDb>, ITweetDal
    {
    }
}
