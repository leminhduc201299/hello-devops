using MISA.Fresher.CukCuk.Core.Entities;
using MISA.Fresher.CukCuk.Core.Interfaces.Repository;
using MISA.Fresher.CukCuk.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Fresher.CukCuk.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity>
    {
        IBaseRepository<TEntity> _baseRepository;
        protected ServiceResult _serviceResult;

        #region Contructor
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
            _serviceResult = new ServiceResult();
        }
        #endregion

        #region Method
        
        #endregion
    }
}
