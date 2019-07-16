namespace TestDrivenAutoMapping.Common.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public Human Manager { get; set; }
    }
}
