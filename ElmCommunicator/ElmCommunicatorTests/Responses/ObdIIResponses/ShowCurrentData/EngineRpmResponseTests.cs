﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElmCommunicator.Responses.ObdIIResponses.ShowCurrentData;
using NUnit.Framework;

namespace ElmCommunicatorTests.Responses.ObdIIResponses.ShowCurrentData
{
    [TestFixture]
    public class EngineRpmResponseTests
    {
        private EngineRpmResponse _response;

        [SetUp]
        public void SetUp()
        {
            this._response = new EngineRpmResponse();
        }

        [Test]
        public void  ShouldGetTheCommand()
        {
            string message = "41 01 55 55";
            string expectedCommand = "4101";
            _response.Parse(message);
            Assert.AreEqual(expectedCommand, _response.Command);
        }

        [Test]
        public void ShouldCalculateTheRpmFromTheResponse()
        {
            string data = "5554";
            double expectedRpm = 5461;
            double actualRpm = _response.CalculateRpm(data);
            Assert.AreEqual(expectedRpm, actualRpm);
        }

        [Test]
        public void ShouldGetTheRpm()
        {
            string message = "41 01 55 54";
            double expectedData = 5461;
            _response.Parse(message);
            Assert.AreEqual(expectedData, _response.Rpm);
        }
    }
}
