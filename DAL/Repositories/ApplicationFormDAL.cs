using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ApplicationFormDAL : IApplicationFormDAL
    {
        private readonly ProgramContext db;

        public ApplicationFormDAL()
        {
            db = new ProgramContext();
        }

        public async Task<string> Save(ApplicationFormFormat applicationFormFormat)
        {
            try
            {
                if (applicationFormFormat.Id is null)
                {
                    applicationFormFormat.Id = Guid.NewGuid().ToString();
                    db.ApplicationFormFormats?.Add(applicationFormFormat);

                    await db.SaveChangesAsync();
                }

                return applicationFormFormat.Id;
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
                if (applicationFormFormat.Id is not null)
                {
                    ApplicationFormFormat updateItem = db.ApplicationFormFormats.Where(x => x.Id == applicationFormFormat.Id).FirstOrDefault();

                    if (updateItem != null)
                    {
                        updateItem.Title = applicationFormFormat.Title;
                        updateItem.Description = applicationFormFormat.Description;

                        updateItem.PersonalInfo = applicationFormFormat.PersonalInfo;
                        updateItem.ParagraphQuestion = applicationFormFormat.ParagraphQuestion;
                        updateItem.NumericQuestion = applicationFormFormat.NumericQuestion;
                        updateItem.DateQuestion = applicationFormFormat.DateQuestion;
                        updateItem.YesNoQuestion = applicationFormFormat.YesNoQuestion;
                        updateItem.DropdownQuestion = applicationFormFormat.DropdownQuestion;
                        updateItem.MultipleChoiceQuestion = applicationFormFormat.MultipleChoiceQuestion;

                        db.ApplicationFormFormats?.Update(updateItem);
                    }

                    await db.SaveChangesAsync();
                }

                return applicationFormFormat.Id;
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
                ApplicationFormFormat selectedFormData = db.ApplicationFormFormats.Where(x => x.Id == formId).FirstOrDefault();
                return selectedFormData;
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
                if (item.Id is null)
                {
                    item.Id = Guid.NewGuid().ToString();
                    db.ApplicationFormDataSet?.Add(item);

                    await db.SaveChangesAsync();
                }

                return item.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
