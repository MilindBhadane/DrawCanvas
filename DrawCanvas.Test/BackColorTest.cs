using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawCanvas.Parsers;
using DrawCanvas.Commands;

namespace DrawCanvas.Test
{
    [TestClass]
    public class BackColorTest
    {
        [TestMethod()]
        public void Test_BackColor_Positive()
        {
            string commandText = "B 5 10 *";
            char commandName = 'B';
            int x = 5;
            int y = 10;
            char charToPrint = '*';

            BackColorParser parser = new BackColorParser(commandText);
            CmdBackColor command = (CmdBackColor)parser.ParseCommand();

            Assert.AreEqual(command.CommandName, commandName, "Command Name parsed correctly.");
            Assert.AreEqual(command.Point.X, x, "Command Point x parsed properly.");
            Assert.AreEqual(command.Point.Y, y, "Command Point y parsed properly..");
            Assert.AreEqual(command.CharToPrint, charToPrint, "Command Color parsed correctly.");
        }

        [TestMethod()]
        public void Test_BackColor_Negative()
        {
            string commandText = "B 5 10 c";
            char commandName = 'R';
            int x = 1;
            int y = -1;
            char charToPrint = ' ';

            BackColorParser parser = new BackColorParser(commandText);
            CmdBackColor command = (CmdBackColor)parser.ParseCommand();

            Assert.AreNotEqual(command.CommandName, commandName, "Command Name not parsed correctly.");
            Assert.AreNotEqual(command.Point.X, x, "Command Point x not parsed properly.");
            Assert.AreNotEqual(command.Point.Y, y, "Command Point y not parsed properly..");
            Assert.AreNotEqual(command.CharToPrint, charToPrint, "Command Color not parsed correctly.");
        }
    }
}
