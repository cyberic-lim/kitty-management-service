using KittyManagementService.Controllers;
using KittyManagementService.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace KittyManagementServiceTest.TestMethods
{
    class KittensControllerTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestGetKittens()
        {
            KittensController kittensController = new KittensController();
            KittenDto kittenDto = kittensController.GetKittens();
            Assert.IsTrue(kittenDto.Name == "Mango");
        }

    }
}
