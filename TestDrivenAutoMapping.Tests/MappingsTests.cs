using System;
using AutoMapper;
using NUnit.Framework;
using TestDrivenAutoMapping.Common.Mappings;
using TestDrivenAutoMapping.Common.Models;
using TestDrivenAutoMapping.Common.ViewModels;

namespace TestDrivenAutoMapping.Tests
{
    [TestFixture]
    public class MappingsTests
    {

        [OneTimeSetUp]
        [Obsolete]
        public void Init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<Mappings>();
            });
        }

        [Test]
        public void Map_Should_HaveValidConfig()
        {
            Mapper.AssertConfigurationIsValid();
        }

        [Test]
        public void Map_Should_MapPersonToPersonViewModel()
        {
            var entity = new Person();
            var vm = Mapper.Map<PersonViewModel>(entity);

            Assert.NotNull(vm);
            Assert.IsInstanceOf(typeof(PersonViewModel), vm);
        }

        [Test]
        public void Map_Should_MapPersonViewModelToPerson()
        {
            var vm = new PersonViewModel();
            var entity = Mapper.Map<Person>(vm);

            Assert.NotNull(vm);
            Assert.IsInstanceOf(typeof(Person), entity);
        }
    }
}