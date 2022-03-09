using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarOpgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOpgave1.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car car;

        [TestInitialize]
        public void Init()
        {
            car = new Car(1, "Mercedes", 6000.00, "AB66777");
        }

        [TestMethod()]
        public void IdTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Id = 0);
        }

        [TestMethod()]
        public void ModelTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Model = "Bil");
            Assert.ThrowsException<ArgumentNullException>(() => car.Model = null);
            Assert.ThrowsException<ArgumentException>(() => car.Model = "");
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Price = 0);
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "AB");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.LicensePlate = "AB667775");
        }

    }
}