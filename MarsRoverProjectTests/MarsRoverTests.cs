using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverProject.Tests
{
    [TestClass()]
    public class MarsRoverTests
    {
        [TestMethod()]
        [DataRow("5 5\n\r1 2 N\n\rLMLMLMLMM\n\r3 3 E\n\rMMRMMRMRRM", "1 3 N\r\n5 1 E\r\n")]
        [DataRow("5 5\r\n0 0 N\r\nL", "0 0 W\r\n")]
        [DataRow("5 5\r\n1 1 W\r\nM", "0 1 W\r\n")]
        public void MarsRoverTest(string input, string expectedOutput)
        {
            MarsRover marsRover = new MarsRover();
            string output = marsRover.Execute(input);
            Assert.AreEqual(expectedOutput, output);
        }
       
    }
}