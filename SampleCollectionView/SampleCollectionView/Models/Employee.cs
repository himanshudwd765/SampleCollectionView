using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCollectionView.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileImage { get; set; }
        public string Designation { get; set; }
        public string FullName => FirstName + " " + LastName;
    }
}
