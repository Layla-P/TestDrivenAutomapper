namespace TestDrivenAutoMapping.Common.ViewModels
{
    public class JobViewModel
    {
        public string Name { get; set; }
        public int ManagerId { get; set; }
        public HumanViewModel Manager { get; set; }
    }
}
