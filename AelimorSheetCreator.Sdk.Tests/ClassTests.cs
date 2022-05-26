using AelimorSheetCreator.Models;
using AelimorSheetCreator.Sdk.Proxy;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.Sdk.Tests
{
    [TestClass]
    public class ClassTests
    {
        private static IConfiguration configuration;

        private static IReadOnlyDictionary<string, string> Endpoints { get; } = new Dictionary<string, string> { ["ProxyConfig:" + ProxyConstants.Controller] = @"https://localhost:7036" };

        public IClassProxy _classProxy = CreateClassProxy(configuration);

        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            var configBuilder = new ConfigurationBuilder()
                .AddInMemoryCollection(Endpoints)
                .Build();

            configuration = configBuilder;
        }

        [TestMethod]
        public async Task Get_AllClasses_IsNotNull()
        {
            var classes = await _classProxy.GetAllClasses();

            Assert.IsNotNull(classes);
        }

        [TestMethod]
        public async Task Get_ClassById_IsNotNull()
        {
            var singleClass = await _classProxy.GetClassById(1);

            Assert.IsNotNull(singleClass);
        }

        [TestMethod]
        public async Task Post_Class_IsSuccess()
        {
            var newClass = new Class()
            {
                ClassName = "NotFighter",
                BaseHp = 20,
                BaseStamina = 20,
                BaseNatArmor = 20,
                BaseWearLimit = 20,
                WeaponProf = "Big Swords",
                Description = "I Swing big weapons",
                Profession = false
            };

            int singleClass = await _classProxy.PostClass(newClass);

            Assert.IsTrue(singleClass == 200);
        }

        [TestMethod]
        public async Task Update_Class_IsSuccess()
        {
            var newClass = new Class()
            {
                ClassName = "TEST",
                BaseHp = 1,
                BaseStamina = 1,
                BaseNatArmor = 1,
                BaseWearLimit = 1,
                WeaponProf = "TEST",
                Description = "TEST",
                Profession = true
            };

            int singleClass = await _classProxy.UpdateClassById(48, newClass);

            Assert.IsTrue(singleClass == 200);
        }

        [TestMethod]
        public async Task Delete_ClassById_IsSuccess()
        {
            var deleteResponse = await _classProxy.DeleteClassById(48);

            Assert.IsTrue(deleteResponse == 200);
        }

        private static ClassProxy CreateClassProxy(IConfiguration config)
        {
            return new ClassProxy(config);
        }
    }
}