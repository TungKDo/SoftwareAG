using Microsoft.AspNetCore.Mvc;
using SoftwareAG.DTO;
using SoftwareAG.Infrastructure;
using SoftwareAG.Models;
using SoftwareAG.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareAG.Controllers
{
    public class ResumeController : Controller
    {
        private readonly IResumeService resumeService;
        private readonly IMappingProvider mapper;

        public ResumeController(IResumeService resumeService, IMappingProvider mapper)
        {
            this.resumeService = resumeService;
            this.mapper = mapper;
        }


        /// <summary>
        /// Visualize the resume.
        /// </summary>
        public IActionResult ViewResume()
        {
            var resumeDto = this.resumeService.OpenResume();

            var resume = mapper.MapTo<ResumeViewModel>(resumeDto);
            return this.View(resume);
        }

        /// <summary>
        /// Edit View for the resume.
        /// </summary>
        [HttpGet]
        public IActionResult EditResume()
        {   
            var resumeDto = this.resumeService.OpenResume();
            var resume = mapper.MapTo<ResumeViewModel>(resumeDto);

            return this.View(resume);
        }

        /// <summary>
        /// Post a resume update.
        /// </summary>
        [HttpPost]
        public IActionResult EditResume(ResumeViewModel resumeViewModel)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (!this.ModelState.IsValid)
            {
                return View(resumeViewModel);
            }
            var resume = mapper.MapTo<Resume>(resumeViewModel);

            resumeService.SaveResume(resume);

            return this.ViewResume();
        }
    }
}
