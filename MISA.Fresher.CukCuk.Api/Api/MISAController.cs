using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Fresher.CukCuk.Core;
using MISA.Fresher.CukCuk.Core.Entities;
using MISA.Fresher.CukCuk.Core.Interfaces.Repository;
using MISA.Fresher.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Fresher.CukCuk.Api.Api
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MISAController<TEntity> : ControllerBase
    {
        #region Field
        IBaseService<TEntity> _baseService;
        IBaseRepository<TEntity> _baseRepository;
        private ServiceResult service = new ServiceResult();
        #endregion

        #region Contructor
        public MISAController(IBaseService<TEntity> baseService, IBaseRepository<TEntity> baseRepository)
        {
            _baseService = baseService;
            _baseRepository = baseRepository;
        }
        #endregion

        #region Method
        
        #endregion
    }
}
