using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawCanvas.Parsers;
using DrawCanvas.Commands;

namespace DrawCanvas.Test
{
    [TestClass]
    public class LineTest
    {
        [TestMethod()]
        public void Test_CreateLine_Positive()
        {
            string strCommand = "L 4 3 4 7";
            char commandName = 'L';
            double x1 = 4;
            double y1 = 3;
            double x2 = 4;
            double y2 = 7;

            LineParser parser = new LineParser(strCommand);
            CmdLine cmdLine = (CmdLine)parser.ParseCommand();

            Assert.AreEqual(cmdLine.CommandName, commandName, "Command Name parsed correctly.");
            Assert.AreEqual(cmdLine.StartPoint.X, x1, "Command Start Point X parsed properly.");
            Assert.AreEqual(cmdLine.StartPoint.Y, y1, "Command Start Point Y parsed properly.");
            Assert.AreEqual(cmdLine.EndPoint.X, x2, "Command End Point X parsed properly.");
            Assert.AreEqual(cmdLine.EndPoint.Y, y2, "Command End Point Y parsed properly.");

        }

        [TestMethod()]
        public void Test_CreateLine_Negative()
        {
            string strCommand = "L 5 5 5 10";
            char commandName = 'M';
            double x1 = 4;
            double y1 = 3;
            double x2 = 4;
            double y2 = 7;

            LineParser parser = new LineParser(strCommand);
            CmdLine cmdLine = (CmdLine)parser.ParseCommand();

            Assert.AreNotEqual(cmdLine.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreNotEqual(cmdLine.StartPoint.X, x1, "Command Start Point X not parsed properly.");
            Assert.AreNotEqual(cmdLine.StartPoint.Y, y1, "Command Start Point Y not parsed properly..");
            Assert.AreNotEqual(cmdLine.EndPoint.X, x2, "Command End Point X not parsed properly.");
            Assert.AreNotEqual(cmdLine.EndPoint.Y, y2, "Command End Point Y not parsed properly..");

        }
    }
}
