using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProRecruiter.Models
{    
    public class Job
    {
        private string jobTitle, jobDescription;
        private int jobId, companyId;
        private float salary;

        public string JobName { get => jobTitle; set => jobTitle = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public int JobId { get => jobId; set => jobId = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}