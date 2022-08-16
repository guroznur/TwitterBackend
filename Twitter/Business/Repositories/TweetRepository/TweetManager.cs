using Business.Aspects.Secured;
using Business.Repositories.TweetRepository.Constants;
using Business.Repositories.TweetRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.TweetRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.TweetParameterRepository
{
    public class TweetManager : ITweetService
    {
        private readonly ITweetDal _tweetDal;

        public TweetManager(ITweetDal tweetDal)
        {
            _tweetDal = tweetDal;
        }

        //[SecuredAspect("admin,tweet.add")]
        [ValidationAspect(typeof(TweetValidator))]
        [RemoveCacheAspect("IOperationClaimService.Get")]
        public async Task<IResult> Add(Tweet tweet)
        {
            await _tweetDal.Add(tweet);
            return new SuccessResult(TweetMessages.AddedText);
        }

        [SecuredAspect("admin,tweet.delete")]
        [RemoveCacheAspect("ITweetService.Get")]
        public async Task<IResult> Delete(Tweet tweet)
        {
            await _tweetDal.Delete(tweet);
            return new SuccessResult(TweetMessages.DeletedText);
        }

        [SecuredAspect("admin,tweet.get")]
        public async Task<IDataResult<Tweet>> GetById(int id)
        {
            return new SuccessDataResult<Tweet>(await _tweetDal.Get(p => p.Id == id));
        }

        //[SecuredAspect("admin,tweet.get")]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<Tweet>>> GetList()
        {
            return new SuccessDataResult<List<Tweet>>(await _tweetDal.GetAll());
        }

        [SecuredAspect("admin,tweet.update")]
        [ValidationAspect(typeof(TweetValidator))]
        [RemoveCacheAspect("ITweetService.Get")]
        public async Task<IResult> Update(Tweet tweet)
        {
            await _tweetDal.Update(tweet);
            return new SuccessResult(TweetMessages.UpdatesText);
        }
    }
}
