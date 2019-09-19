using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProRecruiter.Models
{    
    public class Job
    {
        private int jobId, companyId;
        private string jobTitle, JobDescription;
        private float salary;

        public int JobId { get => jobId; set => jobId = value; }
        public int CompanyId { get => companyId; set => companyId = value; }
        public string JobTitle { get => jobTitle; set => jobTitle = value; }
        public string JobDescription1 { get => JobDescription; set => JobDescription = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}