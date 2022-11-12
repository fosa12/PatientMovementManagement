using Microsoft.EntityFrameworkCore;
using PatientMovementManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientMovementManagement.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            //Add 5 doctor
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee()
                {
                    Id = 1,
                    UserGuid = new Guid("98fa81c6-6138-46c2-b8f3-48423d8ba2b8"),
                    Position = "Lekarz",
                    Specialization = "Ortopeda",
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Jan",
                    LastName = "Kowalski"

                });
            }
                );
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee()
                {
                    Id = 2,
                    UserGuid = new Guid("de29efab-23ff-4bed-a8db-63f35ca033e5"),
                    Position = "Lekarz",
                    Specialization = "Chirurg ogólny",
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Andrzej",
                    LastName = "Lesno"
                });
            }
    );
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee()
                {
                    Id = 3,
                    UserGuid = new Guid("d10e1087-20e1-447b-8345-6e9611afd586"),
                    Position = "Lekarz",
                    Specialization = "Kardiolog",
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Edward",
                    LastName = "Abramczuk"
                });
            }
    );
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee()
                {
                    Id = 4,
                    UserGuid = new Guid("ce6b5893-e96b-4205-8782-76054a2e3784"),
                    Position = "Lekarz",
                    Specialization = "Okulista",
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Ewa",
                    LastName = "Kowalska"
                });
            }
    );
            modelBuilder.Entity<Employee>(e =>
            {
                e.HasData(new Employee()
                {
                    Id = 5,
                    UserGuid = new Guid("b6d34076-64cd-4939-9a6e-35fa89938241"),
                    Position = "Lekarz",
                    Specialization = "Onkolog",
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Janina",
                    LastName = "Konieczna"
                });
            }
);
            //add 5 patient 
            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(new Patient()
                {
                    Id = 1,
                    UserGuid = new Guid("6207233a-1fd5-4032-80c5-039bf7f62a13"),
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Piotr",
                    LastName = "Konieczny",
                    PESEL = "99050443415"
                });
            });
            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(new Patient()
                {
                    Id = 2,
                    UserGuid = new Guid("4ce5d169-aeb9-44ca-864b-9e02959fce38"),
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Andrzej",
                    LastName = "Wajda",
                    PESEL = "48080132121"
                });
            });
            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(new Patient()
                {
                    Id = 3,
                    UserGuid = new Guid("2728354a-70c3-4dbc-a7f9-078b27a6fd1e"),
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Jan",
                    LastName = "Jagiełło",
                    PESEL = "92030332444"
                });
            });
            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(new Patient()
                {
                    Id = 4,
                    UserGuid = new Guid("c41ebf5c-bb1e-4173-af49-13a2be331269"),
                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Krystyna",
                    LastName = "Kowalska",
                    PESEL = "05241477321"
                });
            });
            modelBuilder.Entity<Patient>(p =>
            {
                p.HasData(new Patient()
                {
                    Id = 5,
                    UserGuid = new Guid("0df563c6-7033-44a6-bb2f-c82706f02cb8"),

                    Created = DateTime.Now,
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    FirstName = "Michał",
                    LastName = "Żabiński",
                    PESEL = "04300798759"
                });
            });
            //add 5 planed visit
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 1,
                    EmployeeId = 1,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 9, 11, 14, 30,0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = false,
                    VisitCode = "TEST01"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 2,
                    EmployeeId = 2,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 10, 12, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = false,
                    VisitCode = "TEST02"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 3,
                    EmployeeId = 2,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 10, 20, 12, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = false,
                    VisitCode = "TEST03"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 4,
                    EmployeeId = 3,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 10, 20, 12, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = false,
                    VisitCode = "TEST04"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 5,
                    EmployeeId = 4,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 10, 26, 15, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = false,
                    VisitCode = "TEST05"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 6,
                    EmployeeId = 5,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 10, 24, 14, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = false,
                    VisitCode = "TEST06"
                });
            });
            //add 5 ended visit
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 7,
                    EmployeeId = 1,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 25, 11, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = true,
                    Diagnosis = "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw",
                    NextVisitRecomended = "Za tydzień",
                    VisitCode = "TEST07"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 8,
                    EmployeeId = 2,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 17, 13, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = true,
                    Diagnosis = "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw",
                    NextVisitRecomended = "Za tydzień",
                    VisitCode = "TEST08"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 9,
                    EmployeeId = 2,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 20, 16, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = true,
                    Diagnosis = "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw",
                    NextVisitRecomended = "Za tydzień",
                    VisitCode = "TEST09"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 10,
                    EmployeeId = 3,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 15, 12, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = true,
                    Diagnosis = "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw",
                    NextVisitRecomended = "Za tydzień",
                    VisitCode = "TEST011"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 11,
                    EmployeeId = 4,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 17, 12, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = true,
                    Diagnosis = "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw",
                    NextVisitRecomended = "Za trzy tygodnie",
                    VisitCode = "TEST010"
                });
            });
            modelBuilder.Entity<Visit>(v =>
            {
                v.HasData(new Visit()
                {
                    Id = 12,
                    EmployeeId = 5,
                    PatientId = 1,
                    VisitDateTime = new DateTime(2022, 11, 20, 13, 30, 0),
                    CreatedBy = "SYSTEM",
                    StatusId = 1,
                    IsVisitTookPlace = true,
                    Diagnosis = "Testpwa diagnoza zdiagnozowano wiele rzeczy: dawdaw, dwadaw, dwadw, dwadadw, dwadwa, awddwdawa, dwadwaadw",
                    NextVisitRecomended = "Za dwa tygodnie",
                    VisitCode = "TEST12"
                });
            });
        }
    }
}

