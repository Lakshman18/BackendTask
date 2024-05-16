using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class ApplicationFormFormat
    {
        public string? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PersonalInfo PersonalInfo { get; set; } = null!;
        public List<QuestionDto> ParagraphQuestion { get; set; } = null!;
        public List<QuestionDto> NumericQuestion { get; set; } = null!;
        public List<QuestionDto> DateQuestion { get; set; } = null!;
        public List<QuestionDto> YesNoQuestion { get; set; } = null!;
        public List<DropdownQuestion> DropdownQuestion { get; set; } = null!;
        public List<MultipleChoiceQuestion> MultipleChoiceQuestion { get; set; } = null!;

    }

    public partial class PersonalInfo
    {
        public PersonalInfoOption? FirstName { get; set; }
        public PersonalInfoOption? LastName { get; set; }
        public PersonalInfoOption? Email { get; set; }
        public PersonalInfoOption? Phone { get; set; }
        public PersonalInfoOption? Nationality { get; set; }
        public PersonalInfoOption? CurrentResidence { get; set; }
        public PersonalInfoOption? IdNumber { get; set; }
        public PersonalInfoOption? DateofBirth { get; set; }
        public PersonalInfoOption? Gender { get; set; }


    }

    public partial class PersonalInfoOption
    {
        public bool? Internal { get; set; }
        public bool? Hide { get; set; }
        public string? Answer { get; set; }
    }

    public partial class QuestionDto
    {
        public string? Question { get; set; }
    }

    public partial class DropdownQuestion : QuestionDto
    {
        public List<ChoiceDto> Choice { get; set; } = null!;
    }

    public partial class MultipleChoiceQuestion : DropdownQuestion
    {
        public int MaxChoice { get; set; }
    }

    public partial class ChoiceDto
    {
        public string? Choice { get; set; }
    }

    //Models related with saving the Application Form By candidate.

    public partial class ApplicationFormData
    {
        public string? Id { get; set; }
        public string? ApplicationFormId { get; set; }
        public PersonalInfo PersonalInfo { get; set; } = null!;
        public List<AnswerDto> ParagraphQuestion { get; set; } = null!;
        public List<AnswerDto> NumericQuestion { get; set; } = null!;
        public List<AnswerDto> DateQuestion { get; set; } = null!;
        public List<AnswerDto> YesNoQuestion { get; set; } = null!;
        public List<AnswerDto> DropdownQuestion { get; set; } = null!;
        public List<MultipleAnswerDto> MultipleChoiceQuestion { get; set; } = null!;

    }

    public partial class AnswerDto : QuestionDto
    {
        public string? Answer { get; set; }
    }

    public partial class MultipleAnswerDto : QuestionDto
    {
        public List<string>? Answer { get; set; }
    }




}
