namespace DotLive02.Server.Entities
{
    public class JobApplication
    {
        public JobApplication(string userId, Guid jobId)
        {

            Id = Guid.NewGuid();
            UserId = userId;
            JobId = jobId;

            ApplieAt = DateTime.Now;
        }

        public Guid Id { get; private set; }

        public string UserId { get; private set; }
        public Guid JobId { get; private set; }
        //VARIAVEL DE NAVEGACAO
        public Job Job { get; private set; }
        public DateTime ApplieAt { get; private set; }

    }
}
