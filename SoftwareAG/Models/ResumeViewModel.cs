using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareAG.Models
{
    public class ResumeViewModel
    {
        public PersonalInformationViewModel PersonalInformation { get; set; }

        public IList<WorkExperienceViewModel> WorkExperiences { get; set; }

        public IList<EducationViewModel> Education { get; set; }

        public IList<LanguageViewModel> Languages { get; set; }
    }
}
