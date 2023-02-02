using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using System;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.Utilities
{
    public class Conversion
    {
        public static UserDTO ConvertToUserDTO(User user, List<Role> roles, List<Permission> permissions)
        {
            return  new UserDTO
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                RegistrationDate = user.RegistrationDate,
                Roles = roles,
                Permissions = permissions
            };
        }

        public static Candidate ConvertToCandidate(CandidateVM candidateVM)
        {
            return new Candidate
            {
                IdRole = candidateVM.IdRole,
                IdPuesto = candidateVM.IdPuesto,
                Username = "MGLR",
                Email = candidateVM.Email,
                Password = candidateVM.Password,
                RegistrationDate = DateTime.Now,
            };
        }
        
        public static Expedient ConvertToExpedient(ExpedientVM expedientVM, byte[] filePDFInBytes)
        {
            return new Expedient
            {
                DUI = expedientVM.DUI,
                Names = expedientVM.Names,
                Lastnames = expedientVM.Lastnames,
                Email = expedientVM.Email,
                MovilePhoneNumber = expedientVM.MovilePhoneNumber,
                LandlineNumber = expedientVM.LandlineNumber,
                DateOfBirth = expedientVM.DateOfBirth,
                Gender = expedientVM.Gender,
                CivilStatus = expedientVM.CivilStatus,
                Stall = expedientVM.Stall,
                AcademicTraining = expedientVM.AcademicTraining,
                Certificate = expedientVM.Certificate,
                CurriculumVitae = filePDFInBytes,
                Country = expedientVM.Country,
                Department = expedientVM.Department,
                Municipality = expedientVM.Municipality,
                Direction = expedientVM.Direction
            };
        }
        
        public static CandidateDTO ConvertToCandidateDTO(Candidate candidate, List<Permission> permissions)
        {
            return new CandidateDTO
            {
                IdUser = candidate.IdUser,
                Username = "MGLR",
                Email = candidate.Email,
                Password = candidate.Password,
                RegistrationDate = DateTime.Now,
                Role = candidate.Role,
                Permissions = permissions
            };
        }
        
        public static CandidateSendDTO ConvertToCandidateSendDTO(CandidateVM candidateVM)
        {
            return new CandidateSendDTO
            {
                Email = candidateVM.Email,
                Password = candidateVM.Password,
            };
        }
    }
}
