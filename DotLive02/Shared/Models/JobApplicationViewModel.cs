﻿namespace DotLive02.Shared.Models
{
    public class JobApplicationViewModel
    {
        public JobApplicationViewModel(Guid id, Guid jobId, string title, string company, string location, decimal salary, DateTime appliedAt)
        {
            Id = id;
            JobId = jobId;
            Title = title;
            Company = company;
            Location = location;
            Salary = salary;
            AppliedAt = appliedAt;
        }

        public Guid Id { get;  private set; }
        public Guid JobId { get; private set; }
        public string Title { get; private set; }
        public string Company { get; private set; }
        public string Location { get; private set; }
        public Decimal Salary { get; private set; }
        public DateTime AppliedAt { get; private set; }
    }
}

