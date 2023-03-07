using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.ViewModels.Role;
using RHPsicotest.WebSite.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RHPsicotest.WebSite.Utilities
{
    public class Conversion
    {
        public static UserDTO ConvertToUserDTO(User user, List<string> roles, List<string> permissions = null)
        {
            return  new UserDTO
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                RegistrationDate = user.RegistrationDate,
                Roles = roles,
                Permissions = permissions
            };
        }

        public static User ConvertToUser(UserVM userVM)
        {
            return new User
            {
                Name = userVM.Name,
                Email = userVM.Email,
                Password = userVM.Password,
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En")),
            };
        }
        
        public static User ConvertToUser(User user, UserUpdateVM userUpdateVM)
        {
            return new User
            {
                IdUser = userUpdateVM.IdUser,
                Name = userUpdateVM.Name,
                Email = userUpdateVM.Email,
                Password = user.Password,
                RegistrationDate = user.RegistrationDate
            };
        }
        
        public static Role ConvertToRole(RoleVM roleVM)
        {
            return new Role
            {
                RoleName = roleVM.RoleName
            };
        }
        
        public static Role ConvertToRole(RoleUpdateVM roleUpdateVM)
        {
            return new Role
            {
                IdRole = roleUpdateVM.IdRole,
                RoleName = roleUpdateVM.RoleName
            };
        }
        
        public static RoleUpdateVM ConvertToRoleUpdateVM(Role role)
        {
            return new RoleUpdateVM
            {
                IdRole = role.IdRole,
                RoleName = role.RoleName
            };
        }
        
        public static UserUpdateVM ConvertToUserUpdateVM(User user)
        {
            return new UserUpdateVM
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                Password = string.Empty
            };
        }
        
        public static Candidate ConvertToCandidate(CandidateVM candidateVM)
        {
            return new Candidate
            {
                IdRole = candidateVM.IdRole,
                IdPosition = candidateVM.IdPuesto,
                Email = candidateVM.Email,
                Password = candidateVM.Password,
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En")),
            };
        }
        
        public static Expedient ConvertToExpedient(ExpedientVM expedientVM, (string, string, string) currentCandidate)
        {
            return new Expedient
            {
                IdCandidate = Convert.ToInt16(currentCandidate.Item1),
                DUI = expedientVM.DUI,
                Names = expedientVM.Names,
                Lastnames = expedientVM.Lastnames,
                Email = currentCandidate.Item2,
                MovilePhoneNumber = expedientVM.MovilePhoneNumber,
                LandlineNumber = expedientVM.LandlineNumber,
                EvaluationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En")),
                Age = Helper.CalculateAge(expedientVM.DateOfBirth),
                Gender = expedientVM.Gender,
                CivilStatus = expedientVM.CivilStatus,
                Position = currentCandidate.Item3,
                AcademicTraining = expedientVM.AcademicTraining,
                Certificate = expedientVM.Certificate,
                CurriculumVitae = Helper.FilePDFConvertToArrayOfBytes(expedientVM.CurriculumVitae),
                Country = expedientVM.Country,
                Department = expedientVM.Department,
                Municipality = expedientVM.Municipality,
                Direction = expedientVM.Direction
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

        public static Result ConvertToResult(int expedientId, int factorId, byte scoreFactor, byte scorePercentile)
        {
            return new Result
            {
                IdExpedient = expedientId,
                IdFactor = factorId,
                Score = scoreFactor,
                Percentile = scorePercentile
            };
        }
    }
}
