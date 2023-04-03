﻿using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels.Candidate
{
    public class CandidateResendMailVM
    {
        public int IdCandidate { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public string Password { get; set; }

        public List<Test> Tests { get; set; }
    }
}