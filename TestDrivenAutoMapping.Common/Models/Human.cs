using System;

namespace TestDrivenAutoMapping.Common.Models
{
    public class Human
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
