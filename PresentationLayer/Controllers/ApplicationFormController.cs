using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationFormController : Controller
    {
        private readonly IApplicationFormBLL _ApplicationFormBL;

        public ApplicationFormController(IApplicationFormBLL applicationFormBLL)
        {
            _ApplicationFormBL = applicationFormBLL;
        }

        [HttpPost]
        [Route("Save")]
        public Task<string> Save([FromBody] ApplicationFormFormat item)
        {
            try
            {
                return _ApplicationFormBL.Save(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("Update")]
        public Task<string> Update([FromBody] ApplicationFormFormat item)
        {
            try
            {
                return _ApplicationFormBL.Update(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("GetFormFormat")]
        public Task<ApplicationFormFormat> GetFormFormat(string formId)
        {
            try
            {
                return _ApplicationFormBL.GetFormFormat(formId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("InsertFormData")]
        public Task<string> InsertFormData([FromBody] ApplicationFormData item)
        {
            try
            {
                return _ApplicationFormBL.InsertFormData(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
