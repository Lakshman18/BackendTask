using BLL.Interfaces;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ApplicationFormBLL: IApplicationFormBLL
    {
        private readonly IApplicationFormDAL _ApplicationFormDAL;

        public ApplicationFormBLL(IApplicationFormDAL applicationFormDAL)
        {
            _ApplicationFormDAL = applicationFormDAL;
        }

        public async Task<string> Save(ApplicationFormFormat applicationFormFormat)
        {
            try
            {
                return await _ApplicationFormDAL.Save(applicationFormFormat);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> Update(ApplicationFormFormat applicationFormFormat)
        {
            try
            {
                return await _ApplicationFormDAL.Update(applicationFormFormat);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ApplicationFormFormat> GetFormFormat(string formId)
        {
            try
            {
                return await _ApplicationFormDAL.GetFormFormat(formId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> InsertFormData(ApplicationFormData item)
        {
            try
            {
                return await _ApplicationFormDAL.InsertFormData(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
