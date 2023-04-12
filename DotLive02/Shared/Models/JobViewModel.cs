namespace DotLive02.Shared.Models
{
    public class JobViewModel
    {
        public JobViewModel(Guid id, string title, string description, string company, string location, decimal salary)
        {
            Id = id;
            Title = title;
            Description = description;
            Company = company;
            Location = location;
            Salary = salary;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public Decimal Salary { get; set; }
    }
}
