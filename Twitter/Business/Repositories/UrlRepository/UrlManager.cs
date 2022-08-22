using Business.Aspects.Secured;
using Business.Repositories.UrlRepository.Constants;
using Business.Repositories.UrlRepository.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Validation;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.UrlRepository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories.UrlRepository
{
    public class UrlManager : IUrlService
    {

        private readonly IUrlDal _urlDal;

        public UrlManager(IUrlDal urlDal)
        {
            _urlDal = urlDal;
        }

        //[SecuredAspect()]
        [ValidationAspect(typeof(UrlValidator))]
        [RemoveCacheAspect("UrlService.Get")]
        public async Task<IResult> Add(Url url)
        {
            await _urlDal.Add(url);
            return new SuccessResult(UrlMessages.AddedTweetUrl);
        }

        //[SecuredAspect("admin")]
        [RemoveCacheAspect("UrlService.Get")]
        public async Task<IResult> Delete(Url url)
        {
            await _urlDal.Delete(url);
            return new SuccessResult(UrlMessages.DeletedTweetUrl);
        }

        public async Task<IDataResult<Url>> GetById(int id)
        {
            return new SuccessDataResult<Url>(await _urlDal.Get(p => p.UserId == id));
        }

        [CacheAspect()]
        public async Task<IDataResult<List<Url>>> GetList()
        {
            return new SuccessDataResult<List<Url>>(await _urlDal.GetAll());
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(UrlValidator))]
        [RemoveCacheAspect("UrlService.Get")]
        public async Task<IResult> Update(Url url)
        {
            await _urlDal.Update(url);
            return new SuccessResult(UrlMessages.UpdatesTweetUrl);
        }
    }
}
