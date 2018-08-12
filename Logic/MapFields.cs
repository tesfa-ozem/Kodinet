using System.Linq;
using System.Threading.Tasks;
using Kodinet.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Kodinet.Logic
{
    public class MapFields
    {
        KodinetDbContext context = new KodinetDbContext();
        public RegesteredPersonResult CreatePerson(PersonMap map)
        {
            try
            {
                Person dbPerson = new Person()
                {
                    FingerPrintId = map.FingerPrintId,
                    Name = map.FirstName,
                    LastName = map.LastName,
                    NickName = map.NickName,
                    Photo = map.Photo,
                    Email = map.Email,
                    BirthPlace = map.BirthPlace,
                    BirthDate = map.BirthDate,
                    Nationality = map.Nationality,
                    IdNumber = map.IdNumber,
                    Pobox = map.POBox,
                    Prov = map.Prov,
                    TownDist = map.TownDist,
                    Commune = map.Commune,
                    QuarterSect = map.QuarterSect,
                    AvenueLoc = map.AvenueLoc,
                    Number = map.Number,
                    ChipNumber = map.ChipNumber,
                    Discriminator = map.Discriminator,
                    Signature = map.signature
                };
                context.Add(dbPerson);
                context.SaveChanges();
            }
            catch (Exception)
            {

            }

            return new RegesteredPersonResult()
            {
                Message = "Success",
                StatusCode = 200
            };
        }

        public Person GetPerson(string fingerPrintId)
        {
            Person dbFingerPrint = new Person();
            try
            {
                using (var dbContext = new KodinetDbContext())
                {
                    dbFingerPrint = dbContext.Person
                        .Where(b => b.FingerPrintId.Contains(fingerPrintId))
                        .FirstOrDefault();

                }
            }
            catch (Exception)
            {

            }
            return dbFingerPrint;
        }

        public RegesteredPersonResult FetchAllUsers()
        {
            List<Person> AllPersons = new List<Person>();
            RegesteredPersonResult result = new RegesteredPersonResult();
            try
            {
                using (KodinetDbContext GetPersonContext = new KodinetDbContext())
                {
                    AllPersons = GetPersonContext.Person
                        .ToList<Person>();
                }

                return new RegesteredPersonResult()
                {
                    person = AllPersons,
                    Message = "Success",
                    StatusCode = 200
                };
            }
            catch (Exception ex)
            {
                throw;
                
            }
        }

        public void ResgesterDl(DlDTO dl, string Fingerprint)
        {
            try
            {
                DrivingLicences drivingLicence = new DrivingLicences()
                {

                    CategoryA = dl.CategoryA,
                    CategoryB = dl.CategoryB,
                    CategoryC = dl.CategoryC,
                    CategoryD = dl.CategoryD,
                    CategoryE = dl.CategoryE,
                    DateOfIssue = dl.PlaceOfIssue
                };
            }
            catch (Exception)
            {

            }

        }

        public WokerResult RegisterWorker(WorkerDTO workerDTO)
        {
            Workers worker = new Workers()
            {
                PersonId = workerDTO.personId,
                EntityId = workerDTO.EntityId,
                GradeId = workerDTO.GradeId,
                JobDescription = workerDTO.JobDescription
            };
            try
            {

                context.Add(worker);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                if (worker.PersonId == null)
                {
                    return new WokerResult()
                    {
                        Message = "Not Available"
                    };
                }
            }
            return new WokerResult()
            {

            };

        }

        public WokerResult FetchAllWorkers()
        {
            try
            {
            }
            catch (Exception)
            {

            }
            return new WokerResult()
            {
                StatusCode = 200,
                Message = "Success",
                workers = context.Workers
                            .Include(p => p.Person)
                            .ToList()
            };
        }

    }
}