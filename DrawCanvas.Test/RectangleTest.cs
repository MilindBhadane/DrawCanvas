using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawCanvas.Parsers;
using DrawCanvas.Commands;

namespace DrawCanvas.Test
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod()]
        public void Test_Reactangle_Positive()
        {
            string commandText = "R 5 5 10 10";
            char commandName = 'R';
            int x1 = 5;
            int y1 = 5;
            int x2 = 10;
            int y2 = 10;

            ReactangleParser parser = new ReactangleParser(commandText);
            CmdReactangle command = (CmdReactangle)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name parsed correctly.");
            Assert.AreEqual(command.TopLeft.X, x1, "Command TopLeft Point X parsed properly.");
            Assert.AreEqual(command.TopLeft.Y, y1, "Command TopLeft Point Y parsed properly..");
            Assert.AreEqual(command.RightBottom.X, x2, "Command RightBottom Point X parsed properly.");
            Assert.AreEqual(command.RightBottom.Y, y2, "Command Rightbottom Point Y parsed properly..");
        }

        [TestMethod()]
        public void Test_Reactangle_Negative()
        {
            string commandText = "Test 1 4 3 7";
            char commandName = 'Q';
            int x1 = -1;
            int y1 = 0;
            int x2 = -11;
            int y2 = 100;

            ReactangleParser parser = new ReactangleParser(commandText);
            CmdReactangle command = (CmdReactangle)parser.ParseCommand();

            Assert.AreNotEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreNotEqual(command.TopLeft.X, x1, "Command TopLeft Point X not parsed properly.");
            Assert.AreNotEqual(command.TopLeft.Y, y1, "Command TopLeft Point Y not parsed properly..");
            Assert.AreNotEqual(command.RightBottom.X, x2, "Command RightBottom Point X not parsed properly.");
            Assert.AreNotEqual(command.RightBottom.Y, y2, "Command Rightbottom Point Y not parsed properly..");
        }
    }
}
