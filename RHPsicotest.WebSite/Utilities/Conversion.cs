﻿using RHPsicotest.WebSite.DTOs;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.ViewModels;
using RHPsicotest.WebSite.ViewModels.Candidate;
using RHPsicotest.WebSite.ViewModels.Role;
using RHPsicotest.WebSite.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RHPsicotest.WebSite.Utilities
{
    public class Conversion
    {
        // Usuario
        public static UserDTO ConvertToUserDTO(User user, List<string> roles)
        {
            return  new UserDTO
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                RegistrationDate = user.RegistrationDate,
                Roles = roles
            };
        }

        public static User ConvertToUser(UserVM userVM)
        {
            return new User
            {
                Name = userVM.Name.Trim(),
                Email = userVM.Email.Trim(),
                EmailNormalized = userVM.Email.ToUpper().Trim(),
                Password = userVM.Password.Trim(),
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En")),
            };
        }
        
        public static User ConvertToUser(User user, UserUpdateVM userUpdateVM)
        {
            return new User
            {
                IdUser = userUpdateVM.IdUser,
                Name = userUpdateVM.Name.Trim(),
                Email = userUpdateVM.Email.Trim(),
                EmailNormalized = userUpdateVM.Email.ToUpper().Trim(),
                Password = user.Password.Trim(),
                RegistrationDate = user.RegistrationDate
            };
        }

        public static UserUpdateVM ConvertToUserUpdateVM(User user, List<int> roles)
        {
            return new UserUpdateVM
            {
                IdUser = user.IdUser,
                Name = user.Name,
                Email = user.Email,
                Password = string.Empty,
                RolesId = roles
            };
        }

        // Puesto
        public static Position ConvertToPosition(PositionVM positionVM)
        {
            return new Position
            {
                PositionName = positionVM.PositionName.Trim(),
                PositionHigher = positionVM.PositionHigher.Trim(),
                Department = positionVM.Department.Trim(),
                CreationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            };
        }
        
        public static PositionDTO ConvertToPositionDTO(Position position)
        {
            return new PositionDTO
            {
                IdPosition = position.IdPosition,
                PositionName = position.PositionName,
                PositionHigher = position.PositionHigher,
                Department = position.Department,
                CreationDate = position.CreationDate
            };
        }
        
        public static Position ConvertToPosition(Position position, PositionUpdateVM positionUpdateVM)
        {
            return new Position
            {
                IdPosition = positionUpdateVM.IdPosition,
                PositionName = positionUpdateVM.PositionName.Trim(),
                PositionHigher = positionUpdateVM.PositionHigher.Trim(),
                Department = positionUpdateVM.Department.Trim(),
                CreationDate = position.CreationDate
            };
        }
        
        public static PositionUpdateVM ConvertToPositionUpdateVM(Position position, List<int> testsId)
        {
            return new PositionUpdateVM
            {
                IdPosition = position.IdPosition,
                PositionName = position.PositionName,
                PositionHigher = position.PositionHigher,
                Department = position.Department,
                TestsId = testsId
            };
        }
        
        // Rol
        public static Role ConvertToRole(RoleVM roleVM)
        {
            return new Role
            {
                RoleName = roleVM.RoleName.Trim(),
                RoleNameNormalized = roleVM.RoleName.ToUpper().Trim()
            };
        }
        
        public static Role ConvertToRole(RoleUpdateVM roleUpdateVM)
        {
            return new Role
            {
                IdRole = roleUpdateVM.IdRole,
                RoleName = roleUpdateVM.RoleName.Trim(),
                RoleNameNormalized = roleUpdateVM.RoleName.ToUpper().Trim()
            };
        }
        
        public static RoleUpdateVM ConvertToRoleUpdateVM(Role role, List<int> permissions)
        {
            return new RoleUpdateVM
            {
                IdRole = role.IdRole,
                RoleName = role.RoleName,
                PermissionsId = permissions
            };
        }
        
        // Candidato
        public static Candidate ConvertToCandidate(CandidateVM candidateVM)
        {
            return new Candidate
            {
                IdRole = candidateVM.IdRole,
                IdPosition = candidateVM.IdPosition,
                Email = candidateVM.Email.Trim(),
                EmailNormalized = candidateVM.Email.Trim().ToUpper(),
                Password = candidateVM.Password.Trim(),
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En")),
            };
        }
        
        public static CandidateDTO ConvertToCandidateDTO(Candidate candidate)
        {
            return new CandidateDTO
            {
                IdCandidate = candidate.IdCandidate,
                Email = candidate.Email,
                Password = candidate.Password,
                Position = candidate.Position.PositionName,
                RegistrationDate = candidate.RegistrationDate
            };
        }

        public static CandidateSendVM ConvertToCandidateSendVM(CandidateVM candidateVM)
        {
            return new CandidateSendVM
            {
                Email = candidateVM.Email.Trim(),
                Password = candidateVM.Password.Trim()
            };
        }
        
        public static CandidateResendMailVM ConvertToCandidateResendMailVM(Candidate candidate, List<Test> tests)
        {
            return new CandidateResendMailVM
            {
                IdCandidate = candidate.IdCandidate,
                Email = candidate.Email,
                Password = candidate.Password,
                Tests = tests
            };
        }

        // Expediente
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
        
        public static Expedient ConvertToExpedient(Expedient expedient, ExpedientUpdateVM expedientUpdateVM)
        {
            return new Expedient
            {
                IdExpedient = expedientUpdateVM.IdExpedient,
                IdCandidate = expedient.IdCandidate,
                DUI = expedientUpdateVM.DUI,
                Names = expedientUpdateVM.Names,
                Lastnames = expedientUpdateVM.Lastnames,
                Email = expedient.Email,
                MovilePhoneNumber = expedientUpdateVM.MovilePhoneNumber,
                LandlineNumber = expedientUpdateVM.LandlineNumber,
                EvaluationDate = expedient.EvaluationDate,
                Age = expedientUpdateVM.Age,
                Gender = expedientUpdateVM.Gender,
                CivilStatus = expedientUpdateVM.CivilStatus,
                Position = expedient.Position,
                AcademicTraining = expedientUpdateVM.AcademicTraining,
                Certificate = expedientUpdateVM.Certificate,
                CurriculumVitae = expedient.CurriculumVitae,
                Country = expedientUpdateVM.Country,
                Department = expedientUpdateVM.Department,
                Municipality = expedientUpdateVM.Municipality,
                Direction = expedientUpdateVM.Direction
            };
        }
        
        public static ExpedientDTO ConvertToExpedientDTO(Expedient expedient)
        {
            return new ExpedientDTO
            {
                IdExpedient = expedient.IdExpedient,
                DUI = expedient.DUI,
                Names = expedient.Names,
                Lastnames = expedient.Lastnames,
                Email = expedient.Email,
                Position = expedient.Position
            };
        }
        
        public static ExpedientUpdateVM ConvertToExpedientUpdateVM(Expedient expedient)
        {
            return new ExpedientUpdateVM
            {
                IdExpedient = expedient.IdExpedient,
                DUI = expedient.DUI,
                Names = expedient.Names,
                Lastnames = expedient.Lastnames,
                MovilePhoneNumber= expedient.MovilePhoneNumber,
                LandlineNumber = expedient.LandlineNumber,
                Age = expedient.Age,
                Gender = expedient.Gender,
                CivilStatus = expedient.CivilStatus,
                AcademicTraining = expedient.AcademicTraining,
                Certificate = expedient.Certificate,
                Country = expedient.Country,
                Department = expedient.Department,
                Municipality = expedient.Municipality,
                Direction = expedient.Direction
            };
        }
        
        // Resultado
        public static Result ConvertToResult(int expedientId, int testId, int factorId, byte scoreFactor, byte scorePercentile, string description)
        {
            return new Result
            {
                IdExpedient = expedientId,
                IdTest = testId,
                IdFactor = factorId,
                Score = scoreFactor,
                Percentile = scorePercentile,
                Description = description,
            };
        }
        
        public static ResultDTO ConvertToResultDTO(int testId, List<Result> results)
        {
            return new ResultDTO
            {
                IdTest = testId,
                Results = results
            };
        }
        
        // Prueba
        public static TestDTO ConvertToTestDTO(Test test, bool status)
        {
            return new TestDTO
            {
                NameTest = test.NameTest,
                Time = test.Time,
                Link = test.Link,
                Status = status
            };
        }
    }
}
