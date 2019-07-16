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
        public void Map_Should_MapHumanToHumanViewModel()
        {
            Mapper.AssertConfigurationIsValid();

            var entity = new Human();
            var vm = Mapper.Map<HumanViewModel>(entity);

            Assert.NotNull(vm);
            Assert.IsInstanceOf(typeof(HumanViewModel), vm);
        }

        [Test]
        public void Map_Should_MapHumanViewModelToHuman()
        {
            Mapper.AssertConfigurationIsValid();

            var vm = new HumanViewModel();
            var entity = Mapper.Map<Human>(vm);

            Assert.NotNull(vm);
            Assert.IsInstanceOf(typeof(Human), entity);
        }
    }
}