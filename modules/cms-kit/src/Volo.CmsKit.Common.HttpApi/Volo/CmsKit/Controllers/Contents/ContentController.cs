﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.CmsKit.Contents;

namespace Volo.CmsKit.Controllers.Contents
{
    
    [RemoteService(Name = CmsKitCommonRemoteServiceConsts.RemoteServiceName)]
    [Area("cms-kit")]
    [Route("api/cms-kit/contents")]
    public class ContentController : CmsKitControllerBase, IContentAppService
    {
        protected readonly IContentAppService _contentAppService;

        public ContentController(IContentAppService contentAppService)
        {
            _contentAppService = contentAppService;
        }

        [HttpGet]
        public virtual Task<ContentDto> GetAsync(GetContentInput input)
        {
            return _contentAppService.GetAsync(input);
        }
    }
}
