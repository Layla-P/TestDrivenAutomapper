using System;
using System.Collections.Generic;
using TestDrivenAutoMapping.Common.Models;

namespace TestDrivenAutoMapping.Common.ViewModels
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string HouseName { get; set; }
        public JobViewModel JobViewModel { get; set; }
        public IList<string> Jobs { get; set; }
    }
}
