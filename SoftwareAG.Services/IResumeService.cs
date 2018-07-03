using SoftwareAG.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAG.Services
{
    public interface IResumeService
    {
        Resume OpenResume();
        void SaveResume(Resume resume);
    }
}
