using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IApplicationFormBLL
    {
        Task<string> Save(ApplicationFormFormat applicationFormFormat);
        Task<string> Update(ApplicationFormFormat applicationFormFormat);
        Task<ApplicationFormFormat> GetFormFormat(string formId);
        Task<string> InsertFormData(ApplicationFormData item);
    }
}
