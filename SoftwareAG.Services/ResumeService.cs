using SoftwareAG.DTO;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SoftwareAG.Services
{
    /// <summary>
    /// Contains Open and Save functionality for the resume.
    /// </summary>
    public class ResumeService : IResumeService
    {
        private readonly XmlSerializer serializer;

        public ResumeService()
        {
            this.serializer = new XmlSerializer(typeof(Resume));
        }

        
        /// <summary>
        /// Deserialize the xml file and return a resume.
        /// </summary>
        public Resume OpenResume()
        {
            using (var streamReader = new StreamReader($"Resume.xml"))
            {
                var resume = (Resume)serializer.Deserialize(streamReader);                

                return resume;
            }        
        }


        /// <summary>
        /// Serialize the resume into xml file.
        /// </summary>
        public void SaveResume(Resume resume)
        {
            if (resume == null)
            {
                throw new ArgumentException("Resume should not be null.");
            }

            using (var streamWriter = new StreamWriter($"Resume.xml"))
            {
                serializer.Serialize(streamWriter, resume);
            }
           
        }
    }
}
