﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.Fresher.CukCuk.Core;
using MISA.Fresher.CukCuk.Core.Entities;
using MISA.Fresher.CukCuk.Core.Interfaces.Repository;
using MISA.Fresher.CukCuk.Core.Interfaces.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Fresher.CukCuk.Api.Api
{
    public class ImportController : MISAController<ImportDetail>
    {
        IImportService _importService;

        public ImportController(IImportService importService, IBaseService<ImportDetail> baseService, IBaseRepository<ImportDetail> baseRepository) :
            base(baseService, baseRepository)
        {
            _importService = importService;
        }

        /// <summary>
        /// Thực hiện thêm 1 bản ghi chi tiết xuất nhập khẩu
        /// </summary>
        /// </returns>
        [HttpPost]
        public async Task<ServiceResult> InsertImport(ImportDetail importDetail)
        {
            var serviceResult = new ServiceResult();

            try
            {
                serviceResult = await _importService.InsertImport(importDetail);

                return serviceResult;
            }
            catch (Exception ex)
            {
                serviceResult.Success = false;

                return serviceResult;
            }
        }

        /// <summary>
        /// Thực hiện tìm kiếm chi tiết xuất nhập khẩu
        /// </summary>
        /// </returns>
        [HttpGet]
        public async Task<ServiceResult> SearchImport([FromQuery] string textSearch)
        {
            var serviceResult = new ServiceResult();

            try
            {
                serviceResult.Data = await _importService.SearchImport(textSearch);

                return serviceResult;
            }
            catch (Exception ex)
            {
                serviceResult.Success = false;

                return serviceResult;
            }
        }

        /// <summary>
        /// Thực hiện tìm kiếm chi tiết xuất nhập khẩu
        /// </summary>
        /// </returns>
        [HttpDelete]
        public async Task<ServiceResult> DeleteImport([FromQuery] string vote, [FromQuery] string materialCode)
        {
            var serviceResult = new ServiceResult();

            try
            {
                serviceResult.Data = await _importService.DeleteImport(vote, materialCode);

                return serviceResult;
            }
            catch (Exception ex)
            {
                serviceResult.Success = false;

                return serviceResult;
            }
        }

        /// <summary>
        /// Test API
        /// </summary>
        /// </returns>
        [HttpGet("Test")]
        public async Task<ServiceResult> Test()
        {
            var serviceResult = new ServiceResult();

            try
            {
                serviceResult.Data = await _importService.SearchImport("");

                return serviceResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.ToString());

                serviceResult.Success = false;

                return serviceResult;
            }
        }
    }
}
