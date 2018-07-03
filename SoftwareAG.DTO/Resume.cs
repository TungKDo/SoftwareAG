using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoftwareAG.DTO
{
    public class Resume
    {
        public PersonalInformation PersonalInformation { get; set; }

        [XmlElement("WorkExperience")]
        public List<WorkExperience> WorkExperiences { get; set; }

        [XmlElement("Education")]
        public List<Education> Education { get; set; }

        [XmlElement("Language")]
        public List<Language> Languages { get; set; }
    }
}
