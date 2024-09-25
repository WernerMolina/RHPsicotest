using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using RHPsicotest.WebSite.Repositories.Contracts;
using RHPsicotest.WebSite.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RHPsicotest.WebSite.Repositories
{
    public class MergeRepository : IMergeRepository
    {
        private readonly IServiceProvider _serviceProvider;
        public MergeRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task GenerateMergeDb()
        {
            using var scope = _serviceProvider.CreateScope();

            var _contextMerge = scope.ServiceProvider.GetRequiredService<RHPsicotestDbContext>();
            var _contextDb1 = scope.ServiceProvider.GetRequiredService<RHPV1DbContext>();
            var _contextDb2 = scope.ServiceProvider.GetRequiredService<RHPV2DbContext>();

            if (!await _contextMerge.Expedients.AnyAsync())
            {
                await GetDataDb1(_contextMerge, _contextDb1);
                await GetDataDb2(_contextMerge, _contextDb2);
            }
        }

        private async Task GetDataDb1(RHPsicotestDbContext _contextMerge, RHPV1DbContext _contextDb1)
        {
            List<Position> positions = await _contextDb1.Positions
                .AsNoTracking()
                .Include(f => f.Tests)
                .ToListAsync();
            foreach (var position in positions)
            {
                Position newPosition = new Position
                {
                    PositionName = position.PositionName,
                    PositionHigher = position.PositionHigher,
                    Department = position.Department,
                    CreationDate = position.CreationDate,
                };

                await _contextMerge.Positions.AddAsync(newPosition);
                await _contextMerge.SaveChangesAsync();

                if (position.Tests != null)
                {
                    List<Test_Position> newTestPositions = new List<Test_Position>();
                    foreach (var test in position.Tests)
                    {
                        newTestPositions.Add(new Test_Position
                        {
                            IdPosition = newPosition.IdPosition,
                            IdTest = test.IdTest
                        });
                    }
                    await _contextMerge.Test_Positions.AddRangeAsync(newTestPositions);
                    await _contextMerge.SaveChangesAsync();
                }
            }

            List<Candidate> candidates = await _contextDb1.Candidates
                .AsNoTracking()
                .Include(f => f.Position)
                .ToListAsync();
            foreach (var candidate in candidates)
            {
                Position position = await _contextMerge.Positions.FirstOrDefaultAsync(f => f.PositionName == candidate.Position.PositionName);
                Candidate newCandidate = new Candidate
                {
                    IdRole = candidate.IdRole,
                    IdPosition = position.IdPosition,
                    Email = candidate.Email.Trim(),
                    EmailNormalized = candidate.Email.Trim().ToUpper(),
                    Password = candidate.Password.Trim(),
                    RegistrationDate = candidate.RegistrationDate,
                };

                await _contextMerge.Candidates.AddAsync(newCandidate);
                await _contextMerge.SaveChangesAsync();

                List<Test_Candidate> testCandidates = await _contextDb1.Test_Candidates
                    .AsNoTracking()
                    .Where(f => f.IdCandidate == candidate.IdCandidate)
                    .ToListAsync();

                if (testCandidates != null)
                {
                    List<Test_Candidate> newTestCandidates = new List<Test_Candidate>();
                    foreach (var testCandidate in testCandidates)
                    {
                        newTestCandidates.Add(new Test_Candidate
                        {
                            IdCandidate = newCandidate.IdCandidate,
                            IdTest = testCandidate.IdTest,
                            Status = testCandidate.Status
                        });
                    }
                    await _contextMerge.Test_Candidates.AddRangeAsync(newTestCandidates);
                    await _contextMerge.SaveChangesAsync();
                }

                Expedient expedient = await _contextDb1.Expedients
                    .AsNoTracking()
                    .FirstOrDefaultAsync(f => f.IdCandidate == candidate.IdCandidate);

                if (expedient != null)
                {
                    Expedient newExpedient = new Expedient
                    {
                        IdCandidate = newCandidate.IdCandidate,
                        DUI = expedient.DUI.Trim(),
                        Names = expedient.Names.Trim(),
                        Lastnames = expedient.Lastnames.Trim(),
                        Email = expedient.Email,
                        MovilePhoneNumber = expedient.MovilePhoneNumber.Trim(),
                        LandlineNumber = expedient.LandlineNumber.Trim(),
                        EvaluationDate = expedient.EvaluationDate,
                        Age = expedient.Age,
                        Gender = expedient.Gender.Trim(),
                        CivilStatus = expedient.CivilStatus.Trim(),
                        Position = expedient.Position,
                        AcademicTraining = expedient.AcademicTraining.Trim(),
                        Certificate = expedient.Certificate.Trim(),
                        CurriculumVitae = null,
                        Country = expedient.Country.Trim(),
                        Department = expedient.Department.Trim(),
                        Municipality = expedient.Municipality.Trim(),
                        Direction = expedient.Direction.Trim()
                    };

                    var stream = new MemoryStream(expedient.CurriculumVitae);
                    FormFile formFile = new FormFile(stream, 0, stream.Length, "file", "Cv.pdf");
                    string userNameFull = $"{newExpedient.Names}{newExpedient.Lastnames}".Replace(" ", "");
                    string newFileName = await FileServices.SaveCurriculum(formFile, userNameFull);

                    newExpedient.FileName = newFileName;
                    await _contextMerge.Expedients.AddAsync(newExpedient);
                    await _contextMerge.SaveChangesAsync();

                    List<Result> results = await _contextDb1.Results
                    .AsNoTracking()
                    .Where(f => f.IdExpedient == expedient.IdExpedient)
                    .ToListAsync();

                    if (results != null)
                    {
                        List<Result> newResults = new List<Result>();
                        foreach (var result in results)
                        {
                            Result newResult = new Result
                            {
                                IdFactor = result.IdFactor,
                                IdTest = result.IdTest,
                                Percentile = result.Percentile,
                                Score = result.Score,
                                Description = result.Description,
                                IdExpedient = newExpedient.IdExpedient
                            };
                            newResults.Add(newResult);
                        }
                        await _contextMerge.Results.AddRangeAsync(newResults);
                        await _contextMerge.SaveChangesAsync();
                    }
                }

            }
        }

        private async Task GetDataDb2(RHPsicotestDbContext _contextMerge, RHPV2DbContext _contextDb2)
        {
            List<Position> positions = await _contextDb2.Positions.Include(f => f.Tests).ToListAsync();
            foreach (var position in positions)
            {
                Position newPosition = new Position
                {
                    PositionName = position.PositionName,
                    PositionHigher = position.PositionHigher,
                    Department = position.Department,
                    CreationDate = position.CreationDate,
                };

                bool exists = await _contextMerge.Positions.AnyAsync(f => f.PositionName == position.PositionName);
                if (exists) continue;

                await _contextMerge.Positions.AddAsync(newPosition);
                await _contextMerge.SaveChangesAsync();

                if (position.Tests != null)
                {
                    List<Test_Position> newTestPositions = new List<Test_Position>();
                    foreach (var test in position.Tests)
                    {
                        newTestPositions.Add(new Test_Position
                        {
                            IdPosition = newPosition.IdPosition,
                            IdTest = test.IdTest
                        });
                    }
                    await _contextMerge.Test_Positions.AddRangeAsync(newTestPositions);
                    await _contextMerge.SaveChangesAsync();
                }
            }

            List<Candidate> candidates = await _contextDb2.Candidates
                .Include(f => f.Position)
                .ToListAsync();
            foreach (var candidate in candidates)
            {
                Position position = await _contextMerge.Positions.FirstOrDefaultAsync(f => f.PositionName == candidate.Position.PositionName);
                Candidate newCandidate = new Candidate
                {
                    IdRole = candidate.IdRole,
                    IdPosition = position.IdPosition,
                    Email = candidate.Email.Trim(),
                    EmailNormalized = candidate.Email.Trim().ToUpper(),
                    Password = candidate.Password.Trim(),
                    RegistrationDate = candidate.RegistrationDate,
                };
                await _contextMerge.Candidates.AddAsync(newCandidate);
                await _contextMerge.SaveChangesAsync();

                List<Test_Candidate> testCandidates = await _contextDb2.Test_Candidates
                    .AsNoTracking()
                    .Where(f => f.IdCandidate == candidate.IdCandidate)
                    .ToListAsync();

                if (testCandidates != null)
                {
                    List<Test_Candidate> newTestCandidates = new List<Test_Candidate>();
                    foreach (var testCandidate in testCandidates)
                    {
                        newTestCandidates.Add(new Test_Candidate
                        {
                            IdCandidate = newCandidate.IdCandidate,
                            IdTest = testCandidate.IdTest,
                            Status = testCandidate.Status
                        });
                    }
                    await _contextMerge.Test_Candidates.AddRangeAsync(newTestCandidates);
                    await _contextMerge.SaveChangesAsync();
                }

                Expedient expedient = await _contextDb2.Expedients
                    .AsNoTracking()
                    .FirstOrDefaultAsync(f => f.IdCandidate == candidate.IdCandidate);

                if (expedient != null)
                {
                    Expedient newExpedient = new Expedient
                    {
                        IdCandidate = newCandidate.IdCandidate,
                        DUI = expedient.DUI.Trim(),
                        Names = expedient.Names.Trim(),
                        Lastnames = expedient.Lastnames.Trim(),
                        Email = expedient.Email,
                        MovilePhoneNumber = expedient.MovilePhoneNumber.Trim(),
                        LandlineNumber = expedient.LandlineNumber.Trim(),
                        EvaluationDate = expedient.EvaluationDate,
                        Age = expedient.Age,
                        Gender = expedient.Gender.Trim(),
                        CivilStatus = expedient.CivilStatus.Trim(),
                        Position = expedient.Position,
                        AcademicTraining = expedient.AcademicTraining.Trim(),
                        Certificate = expedient.Certificate.Trim(),
                        CurriculumVitae = null,
                        Country = expedient.Country.Trim(),
                        Department = expedient.Department.Trim(),
                        Municipality = expedient.Municipality.Trim(),
                        Direction = expedient.Direction.Trim()
                    };

                    var stream = new MemoryStream(expedient.CurriculumVitae);
                    FormFile formFile = new FormFile(stream, 0, stream.Length, "file", "Cv.pdf");
                    string userNameFull = $"{newExpedient.Names}{newExpedient.Lastnames}".Replace(" ", "");
                    string newFileName = await FileServices.SaveCurriculum(formFile, userNameFull);

                    newExpedient.FileName = newFileName;
                    await _contextMerge.Expedients.AddAsync(newExpedient);
                    await _contextMerge.SaveChangesAsync();

                    List<Result> results = await _contextDb2.Results
                        .AsNoTracking()
                        .Where(f => f.IdExpedient == expedient.IdExpedient)
                        .ToListAsync();

                    if (results != null)
                    {
                        List<Result> newResults = new List<Result>();
                        foreach (var result in results)
                        {
                            Result newResult = new Result
                            {
                                IdFactor = result.IdFactor,
                                IdTest = result.IdTest,
                                Percentile = result.Percentile,
                                Score = result.Score,
                                Description = result.Description,
                                IdExpedient = newExpedient.IdExpedient
                            };
                            newResults.Add(newResult);
                        }
                        await _contextMerge.Results.AddRangeAsync(newResults);
                        await _contextMerge.SaveChangesAsync();
                    }
                }
            }
        }
    }
}
