using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class HRContextSeed
    {
        public static async Task SeedAsync(HRContext db)
        {
            await db.Database.MigrateAsync();

            if (await db.Employees.AnyAsync() || await db.Jobs.AnyAsync() || await db.Departments.AnyAsync())
                return;

            var j1 = new Job() { Name = "Software Developer" };
            var j2 = new Job() { Name = "Scrum Master" };
            var j3 = new Job() { Name = "Product Owner" };

            var d1 = new Department() { Name = "Information Technology" };
            var d2 = new Department() { Name = "Research and Development" };
            var d3 = new Department() { Name = "Marketing" };

            db.Employees.AddRange(
                new Employee {
                    Name = "John",
                    SecondName = "Albert",
                    Surname = "Doe",
                    Birthday = new DateTime(1985, 6, 15),
                    PlaceOfBirth = "New York",
                    CitizenshipNumber = "1234567890",
                    JobStartDate = new DateTime(2015, 3, 10),
                    Active = true,
                    CompanyName = "ABC Inc.",
                    PhoneNumber = "555-1234",
                    Email = "john.doe@bilgeadamboost.com",
                    Address = "123 Main St., New York",
                    Salary = 50000,
                    Job = j1,
                    Department = d1
                },
                new Employee
                {
                    Name = "Jane",
                    SecondName = "Marie",
                    Surname = "Smith",
                    Birthday = new DateTime(1990, 12, 28),
                    PlaceOfBirth = "Los Angeles",
                    CitizenshipNumber = "0987654321",
                    JobStartDate = new DateTime(2018, 9, 1),
                    JobId = 2,
                    DepartmentId = 2,
                    Active = true,
                    CompanyName = "XYZ Corp.",
                    PhoneNumber = "555-5678",
                    Email = "jane.smith@bilgeadamboost.com",
                    Address = "456 Elm St., Los Angeles",
                    Salary = 60000,
                    Job = j2,
                    Department = d2
                },
                new Employee
                {
                    Name = "Robert",
                    Surname = "Johnson",
                    Birthday = new DateTime(1978, 3, 8),
                    CitizenshipNumber = "1357924680",
                    JobStartDate = new DateTime(2005, 7, 1),
                    JobQuitDate = new DateTime(2022, 2, 15),
                    Active = false,
                    CompanyName = "DEF LLC",
                    PhoneNumber = "555-9876",
                    Email = "robert.johnson@bilgeadamboost.com",
                    Address = "789 Oak St., Chicago",
                    Salary = 75000,
                    Job = j3,
                    Department = d3
                },
                new Employee
                {
                    Name = "Steven",
                    SecondName = "Andrew",
                    Surname = "Smith",
                    Birthday = new DateTime(1988, 10, 7),
                    CitizenshipNumber = "9638527410",
                    JobStartDate = new DateTime(2014, 9, 1),
                    Active = true,
                    CompanyName = "ABC Inc.",
                    PhoneNumber = "555-2345",
                    Email = "steven.smith@bilgeadamboost.com",
                    Salary = 55000,
                    Job = j2,
                    Department = d1
                },
                new Employee
                {
                    Name = "Samantha",
                    Surname = "Williams",
                    Birthday = new DateTime(1993, 4, 29),
                    CitizenshipNumber = "8523697410",
                    JobStartDate = new DateTime(2019, 8, 1),
                    Active = true,
                    CompanyName = "XYZ Corp.",
                    PhoneNumber = "555-9876",
                    Email = "samantha.williams@bilgeadamboost.com",
                    Salary = 65000,
                    Job = j3,
                    Department = d1
                });

            await db.SaveChangesAsync();
        }
    }
}
