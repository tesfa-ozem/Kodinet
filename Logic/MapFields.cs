using Kodinet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

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
                return new RegesteredPersonResult() {
                    OnePerson = dbPerson,
                    StatusCode = 200,
                    Message = "success"

                };
            }
            catch (Exception e)
            {
                return new RegesteredPersonResult()
                {
                    Message = e.Message,
                   
                };

            }
            
           
        }

        public RegesteredPersonResult GetPerson(string Id)
        {
            Person dbFingerPrint = new Person();
            try
            {

                
                    using (var dbContext = new KodinetDbContext())
                    {
                        dbFingerPrint = dbContext.Person
                            .Where(b =>b.IdNumber.Contains(Id))
                            .FirstOrDefault();

                    } 
                
            }
            catch (Exception)
            {

            }
            return new RegesteredPersonResult() {
                StatusCode = (int)HttpStatusCode.OK,
                OnePerson = dbFingerPrint,
                Message = HttpStatusCode.OK.ToString()
            };
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
            catch (Exception)
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
                            .ToList()
            };
        }

        public CompanyResults RegisterCompany(CompayDTO compayDTO)
        {
            try
            {
                Company company = new Company()
                {
                    CompanyName = compayDTO.CompanyName,
                    Email = compayDTO.Email,
                    Initials = compayDTO.Initials,
                    numid_nat = compayDTO.numid_nat,
                    AvenueLoc = compayDTO.AvenueLoc,
                    Commune = compayDTO.Commune,
                    description = compayDTO.description,
                    Pobox = compayDTO.Pobox,
                    Prov = compayDTO.Prov,
                    QuarterSect = compayDTO.QuarterSect,
                    tax_num_dgi = compayDTO.tax_num_dgi,
                    TownDist = compayDTO.TownDist
                };
                context.Add(company);
                context.SaveChanges();
                return new CompanyResults()
                {
                    StatusCode=200
                };
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AppRegisterResult RegisterApp(AppRegisterDto RegisterUse)
        {
            AppRegisterResult result = new AppRegisterResult();
            try
            {
                AppRegistration appRegistration = new AppRegistration()
                {
                    UserName = RegisterUse.UserName,
                    FullName = RegisterUse.FullName,
                    pin = RegisterUse.pin,
                    PhoneNumber = RegisterUse.PhoneNumber,
                    FingerPrint = RegisterUse.FingerPrint

                };
                context.Add(appRegistration);
                context.SaveChanges();


                result = new AppRegisterResult()
                {
                    appRegistration = RegisterUse,
                    StatusCode = (int)HttpStatusCode.OK,
                    Message = HttpStatusCode.OK.ToString()
                };
                
            }
            catch (Exception ex)
            {
                result = new AppRegisterResult { appRegistration=null, Message=ex.Message, StatusCode=(int)HttpStatusCode.InternalServerError };
            }
            return result;
        }

        public LoginResult LoginAccount(Login login)
        {
            try
            {
                
                    var user=context.AppRegistrations
                    .Where(l => l.UserName == login.UserName && l.pin == login.pin)
                    .FirstOrDefault();
                if (user!=null)
                {
                    return new LoginResult()
                    {
                        StatusCode = (int)HttpStatusCode.OK,
                        Message = HttpStatusCode.OK.ToString(),
                        GetAppRegistrations = user

                    };
                }
                return new LoginResult()
                {
                    StatusCode = (int)HttpStatusCode.NotFound,
                    Message = HttpStatusCode.NotFound.ToString(),
                    GetAppRegistrations = user
                };
               

            }
            catch (Exception)
            {

                throw;
            }
        }

        //public RegesteredPersonResult Get


    }
}