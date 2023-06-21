using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; } = null!;

        public string? SecondName { get; set; }

        public string Surname { get; set; } = null!;

        public string? SecondSurname { get; set; }

        public DateTime Birthday { get; set; }

        public string? PlaceOfBirth { get; set; }

        public string CitizenshipNumber { get; set; } = null!;

        public DateTime JobStartDate { get; set; }

        public DateTime JobQuitDate { get; set; }

        public int JobId { get; set; }

        public int DepartmentId { get; set; }

        public string? PhotoUri { get; set; }

        public bool Active { get; set; }

        public string CompanyName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Address { get; set; }

        public decimal Salary { get; set; }


        public Job Job { get; set; } = null!;

        public Department Department { get; set; } = null!;
    }
}
