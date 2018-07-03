using System;

namespace SoftwareAG.DTO
{
    public class Education
    {      
        public string Subject { get; set; }
  
        public string Institution { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}